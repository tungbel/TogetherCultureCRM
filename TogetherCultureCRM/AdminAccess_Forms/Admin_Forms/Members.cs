using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\happy\source\repos\TogetherCultureCRM\TogetherCultureCRM\Database\dbTogetherCultuture.mdf;Integrated Security=True;Connect Timeout=30";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            MemberProgress memberProgress = new MemberProgress();
            memberProgress.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get User Inputs 
            String firstName = txtFirstName.Text.Trim();
            String lastName = txtLastName.Text.Trim();
            String email = txtEmail.Text.Trim();
            String phone = txtPhone.Text.Trim();
            String interests = txtInterests.Text.Trim();
            String membershipType = cmbMembershipType.Text.Trim();
            DateTime joinedDate = dtpJoinedDate.Value;

            // Validate inputs
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phone)
                || String.IsNullOrEmpty(interests)) 
            {
                MessageBox.Show("Please fill in all required field (First Name, Last Name, Email).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the database
            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO AddMemberTbl (FirstName, LastName, Email, Phone, Interests, MembershipType, JoinedDate) " +
                        "VALUES (@FirstName, @LastName, @Email, @Phone, @Interests, @MembershipType, @JoinedDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con)) 
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Emai", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Inersts", interests);
                        cmd.Parameters.AddWithValue("@MembershipType", membershipType);
                        cmd.Parameters.AddWithValue("@JoinedDate", joinedDate);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0) 
                        {

                        }
                    }

                }
                catch (Exception ex) 
                { 

                }
            }

        }
    }
}
