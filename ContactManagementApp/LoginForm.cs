using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManagementApp.Model;

namespace ContactManagementApp
{
    public partial class LoginFrm : Form
    {
        ContractManagementEntities dbcontext = new ContractManagementEntities();
        public User m_user = new User();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var userName = UserNameTxt.Text;
            var password = PasswordTxt.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                errorMsg.Text = "Username and password can not be left blank!";
                return ;
            }

            if(!Login(userName,password))
            {
                errorMsg.Text = "Username and password are not correct!";
                return ;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Login(string username, string password)
        {
            try
            {
                var listUsers = dbcontext.Users.ToList();
                var acc = listUsers.SingleOrDefault(x => x.Username == username
                && x.Password == password);

                if (acc != null)
                {
                    m_user = acc;
                    return true;
                }
                   

                return false;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

    }
}
