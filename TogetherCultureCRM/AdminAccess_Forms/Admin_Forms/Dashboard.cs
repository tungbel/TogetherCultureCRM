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
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    public partial class Dashboard : Form
    {
        private readonly DBConnections db;
        public Dashboard()
        {
            InitializeComponent();
            db = DBConnections.GetInstance();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch and display total members
                int totalMembers = db.GetTotalMembers();
                LblTotalMember.Text = $"Members: {totalMembers}";

                // Fetch and display total events
                int totalEvents = db.GetTotalEvents();
                lblTotalEvents.Text = $"Events: {totalEvents}";

                // Fetch and display recent bookings count
                int recentBookingsCount = db.GetRecentBookingsCount();
                lblRecentBookings.Text = $"Bookings: {recentBookingsCount}";

                // Fetch and display the latest event title
                string latestEventTitle = db.GetLatestEventTitle();
                lblLatestEvent.Text = latestEventTitle;
            }
            catch (Exception ex)
            {
                // Handle errors gracefully and inform the user
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelNested_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }


}
