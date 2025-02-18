using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManagementApp.Model;

namespace ContactManagementApp
{
    public partial class AddNewContractForm : Form
    {
        public Contract m_contract = null;
        bool m_isUpdate = false;
        ContractManagementEntities dbcontext = new ContractManagementEntities();
        public AddNewContractForm()
        {
            InitializeComponent();
        }

        private void AddNewContractForm_Load(object sender, EventArgs e)
        {
            m_lblErrorMsg.Text = string.Empty;
            
            if (m_contract != null)
            {
                m_nameTxt.Text = m_contract.ContractName;
                m_durationTxt.Text = m_contract.Duration.ToString();
                m_ExpirationDtPicker.Value = m_contract.ExpireDate;
                m_SigningDtPicker.Value = m_contract.SigningDate;
                m_isUpdate = true;
            }
            else
            {
                m_nameTxt.Text = string.Empty;
                m_durationTxt.Text = "0";
                m_ExpirationDtPicker.Value = DateTime.Now;
                m_SigningDtPicker.Value = DateTime.Now;
            }

            LoadContractType();
            LoadContractStatus();

        }

        private void m_btnOk_Click(object sender, EventArgs e)
        {
            if(!ValidateData())
            {
                return;
            }

            try
            {
                m_lblErrorMsg.Text = string.Empty;
                var duration = 0;
                int.TryParse(m_durationTxt.Text, out duration);
                var contractType = m_TypeCbx.SelectedItem as ContractType;
                var status = m_statusCbx.SelectedItem as ContactStatu;
                
                if (m_isUpdate)
                {
                    var ct = dbcontext.Contracts.FirstOrDefault(x => x.Id == m_contract.Id);
                    if(ct != null)
                    {
                        ct.Duration = duration;
                        ct.ContractName = m_nameTxt.Text; ;
                        ct.ContractType = contractType;

                        ct.SigningDate = m_SigningDtPicker.Value;
                        ct.ExpireDate = m_ExpirationDtPicker.Value;

                        ct.ContactStatus.Add(status);
                    }
                }
                else
                {
                    var _contract = new Contract();
                    _contract.Duration = duration;
                    _contract.ContractName = m_nameTxt.Text; ;
                    _contract.ContractType = contractType;

                    _contract.SigningDate = m_SigningDtPicker.Value;
                    _contract.ExpireDate = m_ExpirationDtPicker.Value;

                    _contract.ContactStatus.Add(status);
                    dbcontext.Contracts.Add(_contract);
                }
                
                dbcontext.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                return;
            }
            
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadContractType()
        {
            try
            {
                var listTypes = dbcontext.ContractTypes.ToList();
                int typeId = m_contract == null ? -1 : m_contract.ContractTypeId;
                if(listTypes != null && listTypes.Count >0)
                {
                    foreach (ContractType _type in listTypes)
                    {
                        var index = m_TypeCbx.Items.Add(_type);
                        if(_type.Id == typeId)
                        {
                            m_TypeCbx.SelectedIndex = index;
                        }
                    }

                    m_TypeCbx.DisplayMember = "TypeName";
                    m_TypeCbx.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void LoadContractStatus()
        {
            try
            {
                var listTypes = dbcontext.Status.ToList();
                if (listTypes != null && listTypes.Count > 0)
                {
                    foreach (Status _type in listTypes)
                    {
                        m_statusCbx.Items.Add(_type);
                    }
                    m_statusCbx.DisplayMember = "StatusName";
                    m_statusCbx.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private bool ValidateData()
        {
            if(string.IsNullOrEmpty(m_nameTxt.Text) || string.IsNullOrEmpty(m_durationTxt.Text))
            {
                m_lblErrorMsg.Text = "Data fields cannot be left blank!";
                return false;
            }
            var duration = 0;
            int.TryParse(m_durationTxt.Text, out duration);

            if(duration <0)
            {
                m_lblErrorMsg.Text = "Duration must be greater than 0!";
                return false;
            }

            var signDate = m_SigningDtPicker.Value;
            var expirationDate = m_ExpirationDtPicker.Value;

            if(expirationDate < signDate)
            {
                m_lblErrorMsg.Text = "Expiration date must be greater than Signing date!";
                return false;
            }
            
            return true;
        }

    }
}
