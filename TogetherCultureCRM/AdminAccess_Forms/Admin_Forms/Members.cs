using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient; // Provides SQL Server database connectivity
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView; // Provides ListView element styling
using TogetherCultureCRM.DBConnect; // Provides database connection and constants

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    public partial class Members : Form
    {
        // Singleton instance of DBConnections for database interactions
        private readonly TogetherCultureCRM.DBConnect.DBConnections db = TogetherCultureCRM.DBConnect.DBConnections.GetInstance();

        // Tracks the selected member's ID for update or delete operations
        private int selectedAddMemberID = 0;

        // Iniciate private instace of AdminMainMenue
        private AdminMainMenu adminMainMenu;

        // Constructor to accept AdminMainMenu instance
        public Members(AdminMainMenu adminMainMenu)
        {
            InitializeComponent(); // Initializes the form components
            this.adminMainMenu = adminMainMenu;
        }

        // Handles form load event to populate controls and data
        private void Members_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes(); // Populates the combo boxes with predefined values
            PopulateMembers(); // Loads members into the DataGridView
            PopulateBenefits(); // Loads benefits into the respective DataGridView
            ConfigureDataGridView(); // Configure the DataGridView
        }

        // Opens the MemberProgress form and hides the current form
        private void View_Click(object sender, EventArgs e)
        {
            MemberProgress memberProgress = new MemberProgress(); // Create MemberProgress form instance
            memberProgress.Show(); // Display MemberProgress form
            this.Hide(); // Hide current Members form
        }

        // Fetches and displays all members in the DataGridView
        private void PopulateMembers()
        {
            try
            {
                DataTable dt = db.ExecuteQuery(Constants.SelectAllMembersQuery); // Executes query to fetch all members
                dgvMember.DataSource = dt; // Binds the result to the DataGridView
            }
            catch (Exception ex)
            {
                // Displays error message in case of failure
                MessageBox.Show($"Error loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Populates combo boxes with predefined options for Membership Type and Gender
        private void PopulateComboBoxes()
        {
            // Populate MembershipType ComboBox
            cmbMembershipType.Items.Clear(); // Clear existing items
            cmbMembershipType.Items.AddRange(new string[] { "Key Access Member", "Workspace Member", "Community Member" });

            // Populate Gender ComboBox
            cmbGender.Items.Clear(); // Clear existing items
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Others" });

            // Set default selection for both combo boxes
            cmbMembershipType.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
        }

        // Configures the DataGridView for displaying member data
        private void ConfigureDataGridView()
        {
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            dgvMember.MultiSelect = false; // Disallow multiple row selection
            dgvMember.ReadOnly = true; // Make DataGridView read-only
            dgvMember.AllowUserToAddRows = false; // Prevent manual row addition
            dgvMember.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Highlight color for selected rows
            dgvMember.DefaultCellStyle.SelectionForeColor = Color.Black; // Text color for selected rows
        }


        // Adds a new member to the database
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs(out SqlParameter[] parameters)) // Validates user inputs
                    return;

                int rowsAffected = db.ExecuteNonQuery(Constants.InsertMemberQuery, parameters); // Executes the insert query

                if (rowsAffected > 0) // Checks if the insert was successful
                {
                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateMembers(); // Refreshes the member list
                    ClearFields(); // Clears the input fields
                }
                else
                {
                    MessageBox.Show("Failed to add member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Displays error message in case of failure
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error Details: {ex.Message}"); // Logs the error
            }
        }

        // Updates the selected member's details
        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAddMemberID <= 0) // Ensures a member is selected
                {
                    MessageBox.Show("Please select a member to edit.", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInputs(out SqlParameter[] parameters)) // Validates user inputs
                    return;

                // Adds the selected member ID as a parameter for the update query
                Array.Resize(ref parameters, parameters.Length + 1);
                parameters[parameters.Length - 1] = new SqlParameter("@Member_Id", selectedAddMemberID);

                int rowsAffected = db.ExecuteNonQuery(Constants.UpdateMemberQuery, parameters); // Executes the update query

                if (rowsAffected > 0) // Checks if the update was successful
                {
                    MessageBox.Show("Member details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateMembers(); // Refreshes the member list
                    ClearFields(); // Clears the input fields
                }
                else
                {
                    MessageBox.Show("Failed to update member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Displays error message in case of failure
                MessageBox.Show($"Error editing member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deletes the selected member
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAddMemberID == 0) // Ensures a member is selected
                {
                    MessageBox.Show("Please select a member to delete.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirms deletion from the user
                var confirmation = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.No)
                    return;

                // Executes the delete query
                SqlParameter[] parameters = { new SqlParameter("@Member_Id", selectedAddMemberID) };
                int rowsAffected = db.ExecuteNonQuery(Constants.DeleteMemberQuery, parameters);

                if (rowsAffected > 0) // Checks if the delete was successful
                {
                    MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateMembers(); // Refreshes the member list
                    ClearFields(); // Clears the input fields
                }
                else
                {
                    MessageBox.Show("Failed to delete member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Displays error message in case of failure
                MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates the user inputs before performing database operations
        private bool ValidateInputs(out SqlParameter[] parameters)
        {
            parameters = null;

            // Retrieve input values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string interests = txtInterests.Text.Trim();
            string membershipType = cmbMembershipType.SelectedItem?.ToString();
            DateTime joinedDate = dtpJoinedDate.Value;
            string gender = cmbGender.SelectedItem?.ToString();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string password = txtPassword.Text.Trim();
            string benefits = BenefitsTb.Text.Trim();

            // Perform validations

            // First Name and Last Name: Must contain only characters
            if (string.IsNullOrEmpty(firstName) || !System.Text.RegularExpressions.Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("First Name must contain only letters and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(lastName) || !System.Text.RegularExpressions.Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Last Name must contain only letters and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Email Must be in email format
            if (string.IsNullOrEmpty(email) || !System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if email already exists
            bool emailExists = db.IsEmailUnique(email);
            if (!emailExists)
            {
                MessageBox.Show("This email address is already in use. Please use a different email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Phone Must contain only numbers
            if (string.IsNullOrEmpty(phone) || !System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show("Phone number must contain only numbers and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Interests and Benefits Must contain only letters
            if (string.IsNullOrEmpty(interests) || !System.Text.RegularExpressions.Regex.IsMatch(interests, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Interests must contain only letters and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(benefits) || !System.Text.RegularExpressions.Regex.IsMatch(benefits, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Benefits must contain only letters and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Gender Must be selected
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Membership Type Must be selected
            if (string.IsNullOrEmpty(membershipType))
            {
                MessageBox.Show("Please select a membership type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Date of Birth Must indicate age 18 or older
            if ((DateTime.Now.Year - dateOfBirth.Year) < 18 || (DateTime.Now.Year - dateOfBirth.Year == 18 && DateTime.Now.DayOfYear < dateOfBirth.DayOfYear))
            {
                MessageBox.Show("Member must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password Must not be empty
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Construct parameters
            parameters = new SqlParameter[]
            {
              new SqlParameter("@FirstName", firstName),
              new SqlParameter("@LastName", lastName),
              new SqlParameter("@Email", email),
              new SqlParameter("@Phone", phone),
              new SqlParameter("@Interests", interests),
              new SqlParameter("@MembershipType", membershipType),
              new SqlParameter("@JoinedDate", joinedDate),
              new SqlParameter("@Gender", gender),
              new SqlParameter("@DateOfBirth", dateOfBirth),
              new SqlParameter("@Password", password),
              new SqlParameter("@Benefits", benefits)
            };

            return true;
        }


        // Clears all input fields
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtInterests.Clear();
            txtPassword.Clear();
            BenefitsTb.Clear();
            cmbMembershipType.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            dtpJoinedDate.Value = DateTime.Now;
            dtpDateOfBirth.Value = DateTime.Now;
            selectedAddMemberID = 0;
        }

        // Handles cell click events in the DataGridView to populate fields for editing
        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensures a valid row is selected
            {
                DataGridViewRow row = dgvMember.Rows[e.RowIndex];

                // Populates the input fields with the selected row's data
                selectedAddMemberID = Convert.ToInt32(row.Cells["Member_Id"].Value);
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtInterests.Text = row.Cells["Interests"].Value.ToString();

                // Set selected value for MembershipType
                string membershipType = row.Cells["MembershipType"].Value?.ToString();
                cmbMembershipType.SelectedItem = cmbMembershipType.Items.Contains(membershipType) ? membershipType : null;

                // Set selected value for Gender
                string gender = row.Cells["Gender"].Value?.ToString();
                cmbGender.SelectedItem = cmbGender.Items.Contains(gender) ? gender : null;

                dtpJoinedDate.Value = row.Cells["JoinedDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["JoinedDate"].Value)
                    : DateTime.Now;

                dtpDateOfBirth.Value = row.Cells["DateOfBirth"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value)
                    : DateTime.Now;

                txtPassword.Text = row.Cells["Password"].Value?.ToString();
                BenefitsTb.Text = row.Cells["Benefits"].Value?.ToString();
            }
        }

        // Populates the benefits DataGridView with data
        private void PopulateBenefits()
        {
            try
            {
                DataTable dt = db.GetBenefits(); // Fetches benefits data from the database

                if (dt == null || dt.Rows.Count == 0) // Checks if there are no benefits
                {
                    MessageBox.Show("No benefits found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBenefits.DataSource = null;
                }
                else
                {
                    dgvBenefits.AutoGenerateColumns = true; // Auto-generate columns
                    dgvBenefits.DataSource = dt; // Bind the DataTable to the DataGridView
                }
            }
            catch (Exception ex)
            {
                // Displays error message in case of failure
                MessageBox.Show($"Error loading benefits: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTb.Text.Trim(); // Get the search term from the TextBox

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchMembers(searchTerm); // Call the search method
        }



        // Fetches and displays members based on the search term
        private void SearchMembers(string searchTerm)
        {
            try
            {
                // Define the search query with the search term as a parameter
                SqlParameter[] parameters = { new SqlParameter("@SearchTerm", searchTerm) };
                DataTable dt = db.ExecuteQuery(Constants.SearchMemberQuery, parameters); // Executes the query

                if (dt.Rows.Count > 0)
                {
                    dgvMember.DataSource = dt; // Bind results to the DataGridView
                }
                else
                {
                    MessageBox.Show("No members found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateMembers(); // Reload all members to restore the previous data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Navigates to the NonMember form
        private void NonMemberbtn_Click(object sender, EventArgs e)
        {
            NonMember nonMember = new NonMember(adminMainMenu); // Pass AdminMainMenu instance
            nonMember.Show(); // Display NonMember form
            this.Hide(); // Hide current Members form
        }


    }
}
