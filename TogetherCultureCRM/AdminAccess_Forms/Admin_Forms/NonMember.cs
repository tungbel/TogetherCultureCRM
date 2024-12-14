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
using TogetherCultureCRM.AdminAccess_Forms;
using TogetherCultureCRM.AdminAccess_Forms.Admin_Forms;
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM
{
    // Namespace for the NonMember form
    public partial class NonMember : Form
    {
        // Create a singleton instance of the DBConnections class to manage database interactions
        private readonly DBConnections db = DBConnections.GetInstance();

        // Variable to track the selected Non-Member ID for edit or delete operations
        private int selectedNonMemberID = 0;

        private AdminMainMenu adminMainMenu;

        // Constructor initializes the form and its components
        public NonMember(AdminMainMenu adminMenu)
        {
            // Initialize UI components
            InitializeComponent();
            this.adminMainMenu = adminMenu;
        }

       

        // Populate DataGridView with Non-Member data
        private void PopulateNonMembers()
        {
            try
            {
                DataTable dt = db.GetNonMembers();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found in Non_Member table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNonMember.DataSource = null;
                }
                else
                {
                    dgvNonMember.AutoGenerateColumns = true; // Ensure automatic column mapping
                    dgvNonMember.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading non-members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for the Add button click to add a new Non-Member
        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate user input before proceeding
                if (!ValidateInputs(out SqlParameter[] parameters))
                    return;

                // Call the database method to insert a new Non-Member
                int rowsAffected = db.InsertNonMember(parameters);

                if (rowsAffected > 0)
                {
                    // Show success message and refresh the DataGridView
                    MessageBox.Show("Non-Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateNonMembers();
                    ClearFields(); // Clear input fields
                }
                else
                {
                    // Show an error message if the insertion failed
                    MessageBox.Show("Failed to add Non-Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exceptions that occur
                MessageBox.Show($"Error adding Non-Member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Edit button click to update an existing Non-Member
        private void Editbtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Check if a Non-Member is selected for editing
                if (selectedNonMemberID <= 0)
                {
                    MessageBox.Show("Please select a Non-Member to edit.", "Edit Non-Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate user input before proceeding
                if (!ValidateInputs(out SqlParameter[] parameters))
                    return;

                // Add the Non-Member ID as a parameter for the update query
                Array.Resize(ref parameters, parameters.Length + 1);
                parameters[parameters.Length - 1] = new SqlParameter("@Non_MemberId", selectedNonMemberID);

                // Call the database method to update the Non-Member
                int rowsAffected = db.UpdateNonMember(parameters);

                if (rowsAffected > 0)
                {
                    // Show success message and refresh the DataGridView
                    MessageBox.Show("Non-Member details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateNonMembers();
                    ClearFields(); // Clear input fields
                }
                else
                {
                    // Show an error message if the update failed
                    MessageBox.Show("Failed to update Non-Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exceptions that occur
                MessageBox.Show($"Error editing Non-Member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Event handler for the Delete button click to remove a Non-Member
        private void Deletebtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Check if a Non-Member is selected for deletion
                if (selectedNonMemberID == 0)
                {
                    MessageBox.Show("Please select a Non-Member to delete.", "Delete Non-Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Non-Member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Add the Non-Member ID as a parameter for the delete query
                    SqlParameter[] parameters = { new SqlParameter("@Non_MemberId", selectedNonMemberID) };
                    int rowsAffected = db.DeleteNonMember(parameters);

                    if (rowsAffected > 0)
                    {
                        // Show success message and refresh the DataGridView
                        MessageBox.Show("Non-Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateNonMembers();
                        ClearFields(); // Clear input fields
                    }
                    else
                    {
                        // Show an error message if the deletion failed
                        MessageBox.Show("Failed to delete Non-Member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exceptions that occur
                MessageBox.Show($"Error deleting Non-Member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for when a cell in the DataGridView is clicked
        private void dgvNonMember_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dgvNonMember.Rows[e.RowIndex];

                // Populate the input fields with data from the selected row
                selectedNonMemberID = Convert.ToInt32(row.Cells["Non_MemberId"].Value);
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtInterests.Text = row.Cells["Interests"].Value.ToString();
                txtMembershipType.Text = row.Cells["MembershipType"].Value.ToString();
            }

        }

        // Method to validate user inputs
        private bool ValidateInputs(out SqlParameter[] parameters)
        {
            parameters = null;

            // Retrieve and validate input field values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string interests = txtInterests.Text.Trim();
            string membershipType = txtMembershipType.Text.Trim();

            // Check if any required fields are empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(interests) || string.IsNullOrEmpty(membershipType))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Create SQL parameters from the input values
            parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Interests", interests),
                new SqlParameter("@MembershipType", membershipType)
            };

            return true; // Validation passed
        }


        // Method to clear all input fields
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtInterests.Clear();
            txtMembershipType.Clear();
            selectedNonMemberID = 0; // Reset the selected Non-Member ID

        }

        // Searches and displays non-members based on the search term
        private void SearchNonMembers(string searchTerm)
        {
            try
            {
                // Prepare SQL parameter for the search term
                SqlParameter[] parameters = { new SqlParameter("@SearchTerm", searchTerm) };

                // Execute the query
                DataTable dt = db.ExecuteQuery(Constants.SearchNonMemberQuery, parameters);

                if (dt.Rows.Count > 0)
                {
                    dgvNonMember.DataSource = dt; // Bind search results to the DataGridView
                }
                else
                {
                    MessageBox.Show("No matching non-members found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateNonMembers(); // Reload all members to restore the previous data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching non-members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim(); // Get the search term from the TextBox

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchNonMembers(searchTerm); // Perform the search
        }

        // Back button click event to navigate back to the Member form
        private void Backbtn_Click(object sender, EventArgs e)
        {
            adminMainMenu.Show(); // Show the existing AdminMainMenu form
            this.Close(); // Close the NonMember form
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NonMember_Load_1(object sender, EventArgs e)
        {
            PopulateNonMembers();
            
        }
    }
    
}
