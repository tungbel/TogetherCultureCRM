using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnections;

namespace TogetherCultureCRM.Login_Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            string username = txtPassword.Text.Trim();
            string password = txtUsername.Text.Trim();

            // Validate credentials
            string role = TogetherCultureCRM.DBConnections.DBConnections.GetInstance().ValidateLogin(username, password);

            if (role == "Member")
            {
                // Load MemberMainMenu
                new MemberAccess_Forms.MemberMainMenu().Show();
                this.Hide();
            }
            else if (role == "Admin")
            {
                // Load AdminMainMenu
                new AdminAccess_Forms.AdminMainMenu().Show();
                this.Hide();
            }
            else if (role == "Super_Admin")
            {
                // Load SuperAdminMainMenu
                new SuperAdminAccess_Forms.SuperAdminMainMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Constants.InvalidLoginMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
