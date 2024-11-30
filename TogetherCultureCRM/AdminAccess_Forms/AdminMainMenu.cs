using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TogetherCultureCRM.Login_Form;
using TogetherCultureCRM.Navigation_Control;

namespace TogetherCultureCRM.AdminAccess_Forms
{
    // Main form for the admin access menu
    public partial class AdminMainMenu : Form
    {
        private readonly NavigationManager _navManager;

        // Constructor for initializing the form and setting default properties
        public AdminMainMenu()
        {
            InitializeComponent(); // Automatically generated method for component initialization
            this.Text = string.Empty; // Remove title text from the form
            this.ControlBox = false; // Disable the control box (minimize, maximize, close buttons)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Prevent form from being maximized outside the screen bounds

            // Initialize the NavigationManager
            _navManager = new NavigationManager();

            // Subscribe to the Load event of the form to load the initial dashboard
            this.Load += AdminMainMenu_Load;
        }
        // External functions for handling form movement (dragging) and messages using Windows API
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture(); // Releases mouse capture to allow dragging
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        // Sends message to window for moving
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        //Methods
        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            // Load the default child form (Dashboard) when the main menu loads
            _navManager.LoadDefaultChildForm(
                this,
                new Admin_Forms.Dashboard(),  // Default form to load
                btnDashboard,                // Default button to activate
                panelDisplay,                // Panel to display the child form
                panelMenu,                   // Panel containing the menu buttons
                Color.FromArgb(222, 24, 96)  // Active color for the button
            );
        }


        // Button click Dashboard to open the Dashboard form
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Dashboard(), panelDisplay); // Load the FormDashboard on start
        }

        // Button click Member to open the Menmbers form
        private void btnMembers_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Members(), panelDisplay);
        }

        // Button click event to open the Events form
        private void btnEvents_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Events(), panelDisplay);
        }

        // Button click Digital Content Modules to open the Digital Content Modules form
        private void btnDigitalContents_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Digital(), panelDisplay);
        }

        // Button click Report to open the reports form
        private void btnReports_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Reports(), panelDisplay);
        }

        // Button click event to Chat the chats form
        private void btnChats_Click(object sender, EventArgs e)
        {
            _navManager.ActivateButton(sender, panelMenu, Color.FromArgb(222, 24, 96));
            _navManager.OpenChildForm(this, new Admin_Forms.Chats(), panelDisplay);
        }


        // Mouse down event to allow dragging of the form
        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Release the mouse capture
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Send the message to move the form
        }

        // Logout Button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            FormLogin loginForm = new FormLogin();

            // Show the login form
            loginForm.Show();

            // Close the current form
            this.Close();
        }

        // Minimize button click event to minimize the form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Maximize/Restore button click event to toggle window state
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Exit button click event to close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblStory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            System.Diagnostics.Process.Start("https://www.togetherculture.com/story-of-us");
        }

        private void linkLblPrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            System.Diagnostics.Process.Start("https://static1.squarespace.com/static/63bc104e8f7c476406bd6221/t/63eb86ae583c021a4fbf916b" +
                "/1676379822886/Privacy+and+Data+Protection+Statement_Together+Culture+2023.pdf");
        }

        private void linkLblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            System.Diagnostics.Process.Start("https://www.togetherculture.com/contact");
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
