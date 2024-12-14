// Importing required namespaces for UI, data handling, and SQL operations
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    // Represents the Events form in the CRM application
    public partial class Events : Form
    {
        // Singleton instance for database connections
        private readonly TogetherCultureCRM.DBConnect.DBConnections db = TogetherCultureCRM.DBConnect.DBConnections.GetInstance();

        // Tracks the ID of the selected event for editing or deletion
        private int SelectedEventId = 0;

        // Constructor for the Events form
        public Events()
        {
            InitializeComponent(); // Initialize UI components
            ConfigureDataGridView(); // Configure the DataGridView properties
        }

        // Event handler for form load event
        private void Events_Load(object sender, EventArgs e)
        {
            PopulateEvents(); // Populate DataGridView with events from the database
        }

        // Populates the DataGridView with event records
        private void PopulateEvents()
        {
            try
            {
                // Execute query to fetch all events
                DataTable dt = db.ExecuteQuery(Constants.SelectAllEventsQuery);
                EventDgv.DataSource = dt; // Bind data to DataGridView
            }
            catch (Exception ex)
            {
                // Display error message if data fetching fails
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Configures the visual and functional properties of the DataGridView
        private void ConfigureDataGridView()
        {
            EventDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            EventDgv.MultiSelect = false; // Disallow multiple row selection
            EventDgv.ReadOnly = true; // Make DataGridView read-only
            EventDgv.AllowUserToAddRows = false; // Prevent manual row addition
            EventDgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Highlight color for selected rows
            EventDgv.DefaultCellStyle.SelectionForeColor = Color.Black; // Text color for selected rows
        }

        // Handles the Add button click event to add a new event
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user inputs and construct parameters
                if (!ValidateInputs(out SqlParameter[] parameters))
                    return;

                // Execute insert query
                int rowsAffected = db.ExecuteNonQuery(Constants.InsertEventQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateEvents(); // Refresh the DataGridView
                    ClearInputs(); // Clear input fields
                }
                else
                {
                    MessageBox.Show("Failed to add the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display error message if event addition fails
                MessageBox.Show($"Error adding event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Edit button click event to update an existing event
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure an event is selected for editing
                if (SelectedEventId == 0)
                {
                    MessageBox.Show("Please select an event to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate user inputs and construct parameters
                if (!ValidateInputs(out SqlParameter[] parameters))
                    return;

                // Add the Event ID to the parameter list
                Array.Resize(ref parameters, parameters.Length + 1);
                parameters[parameters.Length - 1] = new SqlParameter("@EventId", SelectedEventId);

                // Execute update query
                int rowsAffected = db.ExecuteNonQuery(Constants.UpdateEventQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateEvents(); // Refresh the DataGridView
                    ClearInputs(); // Clear input fields
                }
                else
                {
                    MessageBox.Show("Failed to update the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display error message if event update fails
                MessageBox.Show($"Error updating event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the Delete button click event to remove an existing event
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure an event is selected for deletion
                if (SelectedEventId == 0)
                {
                    MessageBox.Show("Please select an event to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                var confirmation = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.No)
                    return;

                // Execute delete query
                SqlParameter[] parameters = { new SqlParameter("@EventId", SelectedEventId) };
                int rowsAffected = db.ExecuteNonQuery(Constants.DeleteEventQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateEvents(); // Refresh the DataGridView
                    ClearInputs(); // Clear input fields
                }
                else
                {
                    MessageBox.Show("Failed to delete the event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display error message if event deletion fails
                MessageBox.Show($"Error deleting event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates user inputs and constructs SQL parameters
        private bool ValidateInputs(out SqlParameter[] parameters)
        {
            parameters = null;

            // Retrieve and trim input values
            string eventTitle = Title.Text.Trim();
            string eventLocation = LocationInput.Text.Trim();
            string eventOrganiser = Organiser.Text.Trim();
            string eventDescription = Description.Text.Trim();
            DateTime eventDate = Date.Value;
            DateTime createdDate = CreatedDate.Value;

            // Perform validations on the user input
            // Ensuring all user input are in correct data type

            // Validate Location: Must not be empty and only contain letters, numbers, or spaces
            if (string.IsNullOrEmpty(eventTitle) || !System.Text.RegularExpressions.Regex.IsMatch(eventTitle, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Event Title must contain only letters and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Must not be empty and only contain letters, numbers, or spaces
            if (string.IsNullOrEmpty(eventLocation) || !System.Text.RegularExpressions.Regex.IsMatch(eventLocation, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Event Location must contain only letters, numbers, and spaces, and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Must not be empty and only contain letters, numbers, or spaces
            if (string.IsNullOrEmpty(eventOrganiser) || !System.Text.RegularExpressions.Regex.IsMatch(eventOrganiser, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Event Organiser must contain only letters, numbers, spaces and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //  Must not be empty
            if (string.IsNullOrEmpty(eventDescription))
            {
                MessageBox.Show("Event Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Must be a valid positive integer
            if (!int.TryParse(Capacity.Text, out int eventCapacity) || eventCapacity <= 0)
            {
                MessageBox.Show("Event Capacity must be a valid positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Set Current Capacity to 0 if not specified
            if (string.IsNullOrEmpty(current_Capacity.Text))
            {
                current_Capacity.Text = "0";
            }
            //  Must be a valid positive integer and less than or equal to Event Capacity
            if (!int.TryParse(current_Capacity.Text, out int currentCapacity) || currentCapacity < 0 || currentCapacity > eventCapacity)
            {
                MessageBox.Show("Current Capacity must be between 0 and the Event Capacity.", "Validation Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //  Must be a future date
            if (eventDate <= DateTime.Now)
            {
                MessageBox.Show("Event Date must be a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //  Must not be a future date
            if (createdDate > DateTime.Now)
            {
                MessageBox.Show("Created Date cannot be a future date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Construct SQL parameters
            parameters = new SqlParameter[]
            {
              new SqlParameter("@Title", eventTitle),
              new SqlParameter("@Date", eventDate),
              new SqlParameter("@Location", eventLocation),
              new SqlParameter("@Organiser", eventOrganiser),
              new SqlParameter("@Description", eventDescription),
              new SqlParameter("@Capacity", eventCapacity),
              new SqlParameter("@Current_Capacity", currentCapacity),
              new SqlParameter("@CreatedDate", createdDate)
            };

            return true;
        }

        // Clears all input fields
        private void ClearInputs()
        {
            Title.Clear();
            LocationInput.Clear();
            Organiser.Clear();
            Description.Clear();
            Capacity.Clear();
            current_Capacity.Clear();
            Date.Value = DateTime.Now;
            CreatedDate.Value = DateTime.Now;
            SelectedEventId = 0;
        }

        // Handles DataGridView cell click to populate input fields for editing
        private void EventDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = EventDgv.Rows[e.RowIndex];

                SelectedEventId = Convert.ToInt32(selectedRow.Cells["Event_Id"].Value);
                Title.Text = selectedRow.Cells["Title"].Value.ToString();
                // Populate other fields...
            }
        }

        

    }
}
