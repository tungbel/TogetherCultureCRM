using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnect; // Import for DBConnections


namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    public partial class Dashboard : Form
    {
        private DBConnections db = DBConnections.GetInstance();
        private int memberId = 1; // Replace with the actual logged-in member's ID

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData(); // Load data when the form is initialized
        }

        private void LoadDashboardData()
        {
            // Load Total Events Joined
            lblEventJoinedCount.Text = $"{db.GetTotalEventsJoined(memberId)}";
            lblEventJoinedCount.Refresh();

            // Load Benefits Summary
            DataRow benefit = db.GetBenefitsSummary(memberId);
            if (benefit != null)
            {
                lblUsedCount.Text = $" {benefit["Benefit_Used"]}";
                lblAvailableCount.Text = $" {benefit["Benefit_Available"]}";
            }

            // Load Benefits Used List into DataGridView
            dgvBenefitsUsed.DataSource = db.GetBenefitsUsedList(memberId);

            // Load Benefits Available List into DataGridView
            dgvBenefitsAvailable.DataSource = db.GetBenefitsAvailableList();

            // Load Upcoming Events into DataGridView
            dgvUpcomingEvents.DataSource = db.GetUpcomingEvents();

            // Load Latest Digital Content into ListBox
            lstDigitalContent.Items.Clear(); // Clear old data
            DataTable contentTable = db.GetLatestDigitalContent();
            foreach (DataRow row in contentTable.Rows)
            {
                lstDigitalContent.Items.Add(row["Title"].ToString());
            }
        }

        // Adjust column widths and headers for Benefits Used DataGridView
        private void AdjustBenefitsUsedDataGridView()
        {
            dgvBenefitsUsed.Columns[0].HeaderText = "Benefit Name";
            dgvBenefitsUsed.Columns[1].HeaderText = "Description";
            dgvBenefitsUsed.Columns[2].HeaderText = "Usage Date";

            dgvBenefitsUsed.Columns[0].Width = 150;
            dgvBenefitsUsed.Columns[1].Width = 300;
            dgvBenefitsUsed.Columns[2].Width = 120;
            dgvBenefitsUsed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        // Adjust column widths and headers for Benefits Available DataGridView
        private void AdjustBenefitsAvailableDataGridView()
        {
            dgvBenefitsAvailable.Columns[0].HeaderText = "Benefit Name";
            dgvBenefitsAvailable.Columns[1].HeaderText = "Description";
            dgvBenefitsAvailable.Columns[2].HeaderText = "Total Available";

            dgvBenefitsAvailable.Columns[0].Width = 150;
            dgvBenefitsAvailable.Columns[1].Width = 300;
            dgvBenefitsAvailable.Columns[2].Width = 120;
            dgvBenefitsAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
