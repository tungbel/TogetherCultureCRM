using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    public partial class Profile : Form
    {
        private readonly DBConnections db; // Instance of DBConnections for database interactions

        public Profile()
        {
            InitializeComponent();
            db = DBConnections.GetInstance(); // Initialize the singleton DB connection instance
        }


        // Method to load member details into the list box
        private void LoadMemberDetails()
        {
            try
            {
                // Fetch member data (replace '1' with the currently logged-in member's ID)
                DataTable memberData = db.GetMemberDetailsById(1);

                if (memberData.Rows.Count > 0) // Ensure there is at least one row
                {
                    DataRow memberRow = memberData.Rows[0]; // Get the first row of the result

                    // Populate the list box with member details
                    listBoxMemberDetails.Items.Clear();
                    listBoxMemberDetails.Items.Add($"First Name: {memberRow["FirstName"]}");
                    listBoxMemberDetails.Items.Add($"Last Name: {memberRow["LastName"]}");
                    listBoxMemberDetails.Items.Add($"Email: {memberRow["Email"]}");
                    listBoxMemberDetails.Items.Add($"Phone: {memberRow["Phone"]}");
                    listBoxMemberDetails.Items.Add($"Interests: {memberRow["Interests"]}");
                    listBoxMemberDetails.Items.Add($"Membership Type: {memberRow["MembershipType"]}");
                    listBoxMemberDetails.Items.Add($"Joined Date: {Convert.ToDateTime(memberRow["JoinedDate"]).ToString("dd-MM-yyyy")}");
                    listBoxMemberDetails.Items.Add($"Gender: {memberRow["Gender"]}");
                    listBoxMemberDetails.Items.Add($"Date of Birth: {Convert.ToDateTime(memberRow["DateOfBirth"]).ToString("dd-MM-yyyy")}");
                    listBoxMemberDetails.Items.Add($"Benefits: {memberRow["BenefitsS"]}");
                    listBoxMemberDetails.Items.Add($"Password: {memberRow["Password"]}");

                    // Load the member's picture into the PictureBox
                    if (memberRow["ProfilePicture"] != DBNull.Value)
                    {
                        byte[] pictureData = (byte[])memberRow["ProfilePicture"];
                        using (MemoryStream ms = new MemoryStream(pictureData))
                        {
                            pictureBoxProfile.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxProfile.Image = null; // Set to null if no picture is available
                    }
                }
                else
                {
                    MessageBox.Show("No member details found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event to allow users to upload a profile picture
        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter for image file types
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Validate if the selected file exists
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            // Load the image into the PictureBox
                            pictureBoxProfile.Image = Image.FromFile(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected file does not exist. Please try again.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }



        private void listBoxMemberDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemberDetails(); // Populate the list box with member information when the form loads
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBoxProfile.Image = Image.FromFile(filePath); // Load the selected image into PictureBox

                    // Convert the image to byte array and update the database
                    byte[] imageBytes = File.ReadAllBytes(filePath);
                    db.UpdateMemberProfilePicture(1, imageBytes); // Replace '1' with the logged-in member's ID
                    MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadMemberDetails(); // Populate the list box with member information when the form loads

        }
    }
}
