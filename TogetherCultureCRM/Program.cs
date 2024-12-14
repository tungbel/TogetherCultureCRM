using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.AdminAccess_Forms.Admin_Forms;
using TogetherCultureCRM.Load_Form;
using TogetherCultureCRM.Login_Form;
using TogetherCultureCRM.MemberAccess_Forms.Member_Forms;

namespace TogetherCultureCRM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Profile());
        }
    }
}
