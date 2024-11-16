using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TogetherCultureCRM.Login_Form;
using TogetherCultureCRM.Navigation_Control;

namespace TogetherCultureCRM.MemberAccess_Forms
{
    // Main form for the member access menu
    public partial class MemberMainMenu : Form
    {
        private readonly NavigationManager _navManager;
        // Constructor for initializing the form and setting default properties
        public MemberMainMenu()
        {
            InitializeComponent();
           
            this.Text = string.Empty; // Remove title text from the form
            this.ControlBox = false; // Disable the control box (minimize, maximize, close buttons)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Prevent form from being maximized outside the screen bounds

            _navManager = new NavigationManager(); // Initialize the NavigationManager class

            // Subscribe to the Load event of the form to load the initial dashboard
            this.Load += MemberMainMenu_Load;
        }

        // External functions for handling form movement (dragging) and messages using Windows API
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture(); // Releases mouse capture to allow dragging
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        // Sends message to window for moving
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void MemberMainMenu_Load(object sender, EventArgs e)
        {
            // Load the default child form (Dashboard) when the main menu loads
            _navManager.LoadDefaultChildForm(
                this,
                new Member_Forms.Dashboard(),  // Default form to load
                btnDashboard,                // Default button to activate
                panelDisplay,                // Panel to display the child form
                panelMenu,                   // Panel containing the menu buttons
                Color.FromArgb(222, 24, 96)  // Active color for the button
            );
        }       

     
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Member_Forms.Dashboard(), panelDisplay);
        }

        private void btnEvents_Click_2(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Member_Forms.Events(), panelDisplay);
        }

        private void btnDigitalContents_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Member_Forms.Digital(), panelDisplay);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Member_Forms.Profile(), panelDisplay);
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Member_Forms.Chats(), panelDisplay);
        }

        private void linkLblStory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.togetherculture.com/story-of-us");
        }

        private void linkLblPrivacyPolicy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://static1.squarespace.com/static/63bc104e8f7c476406bd6221/t/63eb86ae583c021a4fbf916b/1676379822886/Privacy+and+Data+Protection+Statement_Together+Culture+2023.pdf");
        }

        private void linkLblContact_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.togetherculture.com/contact");
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Release the mouse capture
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Send the message to move the form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            FormLogin loginForm = new FormLogin();

            // Show the login form
            loginForm.Show();

            // Close the current form
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}