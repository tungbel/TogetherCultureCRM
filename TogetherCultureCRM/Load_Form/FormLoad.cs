using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.Login_Form; // To Access Login_Form
using TogetherCultureCRM.MemberAccess_Forms; // To Access MemberMainMenu

namespace TogetherCultureCRM.Load_Form
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 2;
            if (panel1.Width >= 860)
            {
                timer1.Stop();
                // Create an instance of MemberMainMenu
                FormLogin formLogin = new FormLogin();

                // Show the form and hide the current one
                formLogin.Show();
                this.Hide();
            }

        }

        private void FormLoad_Load(object sender, EventArgs e)
        {

        }
    }
}
