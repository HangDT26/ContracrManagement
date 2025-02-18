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
    public partial class MainForm : Form
    {
        private User m_user = null;
        ContractManagementEntities dbcontext = new ContractManagementEntities();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var loginFrm = new LoginFrm();
            if (loginFrm.ShowDialog() == DialogResult.OK)
            {
                m_user = loginFrm.m_user;
            }
            else
            {
                this.Close();
            }
            LoadContracts(dbcontext.Contracts.ToList());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addNewFrm = new AddNewContractForm();
            if(addNewFrm.ShowDialog() == DialogResult.OK)
            {
                var listObj = dbcontext.Contracts.ToList();
                LoadContracts(listObj);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ContractsDgv.SelectedRows[0].Tag as Contract;
            if (selectedItem != null)
            {
                var addNewFrm = new AddNewContractForm();
                addNewFrm.m_contract = selectedItem;

                if (addNewFrm.ShowDialog() == DialogResult.OK)
                {
                    var listObj = dbcontext.Contracts.ToList();
                    LoadContracts(listObj);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = ContractsDgv.SelectedRows[0].Tag as Contract;
                if (selectedItem != null) 
                {
                    dbcontext.Contracts.Remove(selectedItem);
                    dbcontext.SaveChanges();

                    var listObj = dbcontext.Contracts.ToList();
                    LoadContracts(listObj);
                }

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var listContract = dbcontext.Contracts.ToList();
                var listRs = listContract.FindAll(x => x.ContractName.Contains(SearchTxt.Text));

                if (listRs != null)
                {
                    LoadContracts(listRs);
                }
            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void ContractTab_Click(object sender, EventArgs e)
        {

        }

        private void LoadContracts(List<Contract> listContracts)
        {
            try
            {
                ContractsDgv.Rows.Clear();
                if(listContracts != null)
                {
                    for (int i = 0; i < listContracts.Count; i++)
                    {
                        var obj = listContracts[i];

                        int index = ContractsDgv.Rows.Add();

                        var row = ContractsDgv.Rows[index];
                       
                        row.Cells[0].Value = obj.ContractName;
                        row.Cells[2].Value = obj.ContractType.TypeName;
                        row.Cells[3].Value = obj.SigningDate;
                        row.Cells[4].Value = obj.Duration;
                        row.Cells[5].Value = obj.ExpireDate;

                        row.Tag = obj;

                    }
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }
    }
}
