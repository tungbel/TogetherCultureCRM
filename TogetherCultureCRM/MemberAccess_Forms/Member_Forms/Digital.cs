using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    public partial class Digital : Form
    {
        private DBConnections dbConnections = DBConnections.GetInstance();

        public Digital()
        {
            InitializeComponent();
            LoadConnections();
        }

        // Load needs and offers into a DataGridView or ListView
        private void LoadConnections()
        {
            DataTable needsConnections = dbConnections.GetConnectionsByType("Needs");  // Fetch "Needs" data
            dgvNeeds.DataSource = needsConnections;

            DataTable offersConnections = dbConnections.GetConnectionsByType("Offers");  // Fetch "Offers" data
            dgvOffers.DataSource = offersConnections;
        }

        // Post a new connection when the Submit button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve values from form controls
            string connectionType = cboConnectionType.SelectedItem.ToString(); // ComboBox for "Needs" or "Offers"
            string title = txtTitle.Text; // TextBox for Description
            string description = txtDescription.Text; // TextBox for Description
            string category = txtCategory.Text; // TextBox for Category
            string contactDetails = txtContactDetails.Text; // TextBox for Contact Details

            // Validate that the required fields are filled
            if (string.IsNullOrWhiteSpace(connectionType) || string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(contactDetails))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Call the method to insert the new connection into the database
                dbConnections.PostNewConnection(connectionType, title, description, category, contactDetails);
                MessageBox.Show("New connection posted successfully!");
                LoadConnections(); // Refresh the displayed connections
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error posting connection: {ex.Message}");
            }
        }




    }

}
