using System;
using System.Data;
using System.Net.Mime;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    public partial class Digital : Form
    {
        // Create an instance of the database connection class
        private readonly DBConnections db;

        // Variable to store the ID of the currently selected digital content
        private int selectedContentID = 0;

        public Digital()
        {
            InitializeComponent(); // Initialize form components
            db = DBConnections.GetInstance(); // Get the singleton instance of the database connection
        }

        private void Digital_Load(object sender, EventArgs e)
        {
            Populate(); // Load and display digital content data when the form loads
        }

        // Method to populate the DataGridView with digital content data from the database
        private void Populate()
        {
            try
            {
                DataTable dt = db.GetDigitalContent(); // Fetch digital content data from the database
                Contentdgv.DataSource = dt; // Bind the data to the DataGridView
            }
            catch (Exception ex)
            {
                // Display an error message if data fetching fails
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for selecting a row in the DataGridView
        private void Contentdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row index is valid
            {
                try
                {
                    // Get the selected row
                    DataGridViewRow row = Contentdgv.Rows[e.RowIndex];

                    // Populate text fields with data from the selected row
                    TitleTb.Text = row.Cells["Title"].Value?.ToString() ?? "";
                    DescripTb.Text = row.Cells["Description"].Value?.ToString() ?? "";

                    // Safely parse and set the upload date
                    var uploadDateValue = row.Cells["Upload_Date"].Value;
                    if (uploadDateValue != null && DateTime.TryParse(uploadDateValue.ToString(), out DateTime uploadDate))
                    {
                        UploadDate.Value = uploadDate;
                    }
                    else
                    {
                        UploadDate.Value = DateTime.Now; // Default to the current date if parsing fails
                    }

                    // Populate other fields
                    ContentType.Text = row.Cells["Content_Type"].Value?.ToString() ?? "";
                    ContentLocationTb.Text = row.Cells["Content_Location"].Value?.ToString() ?? "";
                    DurationTb.Text = row.Cells["Duration"].Value?.ToString() ?? "";
                    AccessTypeCb.SelectedItem = row.Cells["Access_Type"].Value?.ToString() ?? "";
                    PriceTb.Text = row.Cells["Price"].Value?.ToString() ?? "0.00";
                    StatusCb.SelectedItem = row.Cells["Status"].Value?.ToString() ?? "";

                    // Safely parse and set the selected content ID
                    var contentIDValue = row.Cells["Digital_Content_Id"].Value;
                    if (contentIDValue != null && int.TryParse(contentIDValue.ToString(), out int contentID))
                    {
                        selectedContentID = contentID;
                    }
                    else
                    {
                        selectedContentID = 0; // Default to 0 if parsing fails
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if data population fails
                    MessageBox.Show($"Error loading row data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to add a new digital content record to the database
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                string title = TitleTb.Text.Trim();
                string description = DescripTb.Text.Trim();
                DateTime uploadDate = UploadDate.Value;
                string contType = ContentType.Text.Trim();
                string contentLocation = ContentLocationTb.Text.Trim();
                string duration = DurationTb.Text.Trim();
                string accessType = AccessTypeCb.SelectedItem?.ToString();
                decimal price = decimal.Parse(PriceTb.Text.Trim());
                string status = StatusCb.SelectedItem?.ToString();

                // Validate inputs
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(contType) ||
                    string.IsNullOrEmpty(contentLocation) || string.IsNullOrEmpty(duration) ||
                    string.IsNullOrEmpty(accessType) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the new record to the database
                int rowsAffected = db.InsertDigitalContent(title, description, uploadDate, contType, contentLocation, duration, accessType, price, status);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Digital content added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Clear input fields
                    Populate(); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("Failed to add digital content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if adding the record fails
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to edit an existing digital content record in the database
        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedContentID == 0) // Ensure a record is selected
                {
                    MessageBox.Show("Please select a record to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve input values
                string title = TitleTb.Text.Trim();
                string description = DescripTb.Text.Trim();
                DateTime uploadDate = UploadDate.Value;
                string contType = ContentType.Text.Trim();
                string contentLocation = ContentLocationTb.Text.Trim();
                string duration = DurationTb.Text.Trim();
                string accessType = AccessTypeCb.SelectedItem?.ToString();
                decimal price = decimal.Parse(PriceTb.Text.Trim());
                string status = StatusCb.SelectedItem?.ToString();

                // Update the record in the database
                int rowsAffected = db.UpdateDigitalContent(selectedContentID, title, description, uploadDate, contType, contentLocation, duration, accessType, price, status);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Digital content updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Populate(); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("Failed to update digital content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if updating the record fails
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to delete a digital content record from the database
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedContentID == 0) // Ensure a record is selected
                {
                    MessageBox.Show("Please select a record to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int rowsAffected = db.DeleteDigitalContent(selectedContentID); // Delete the record

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Digital content deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Populate(); // Refresh the data grid view
                        ClearFields(); // Clear input fields
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete digital content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if deleting the record fails
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear input fields
        private void ClearFields()
        {
            TitleTb.Clear();
            DescripTb.Clear();
            UploadDate.Value = DateTime.Now;
            ContentType.Clear();
            ContentLocationTb.Clear();
            DurationTb.Clear();
            AccessTypeCb.SelectedIndex = -1;
            PriceTb.Clear();
            StatusCb.SelectedIndex = -1;
            selectedContentID = 0; // Reset selected content ID
        }

      
    }
}
