using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            MemberProgress memberProgress = new MemberProgress();
            memberProgress.Show();
            this.Hide();
        }
    }
}
