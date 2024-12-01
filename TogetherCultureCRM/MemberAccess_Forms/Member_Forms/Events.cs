using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    public partial class Events : Form
    {
        private DBConnections db = DBConnections.GetInstance();
        private int memberId = 1; // Replace with the actual logged-in member's ID
        public Events()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Events_Load(object sender, EventArgs e)
        {
            // Fetch events from the database
            DBConnections db = DBConnections.GetInstance();
            DataTable events = db.GetAllEventsForForm();

            // Loop through the events and create a card for each one
            foreach (DataRow row in events.Rows)
            {
                // Create a new card (UserControl or Panel)
                Panel card = new Panel
                {
                    Size = new Size(600, 200),  // Set size as per your design
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // Create the labels for event details
                Label titleLabel = new Label
                {
                    Text = row["Title"].ToString(),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Size = new Size(580, 25)
                };

                Label descriptionLabel = new Label
                {
                    Text = row["Description"].ToString(),
                    Font = new Font("Arial", 10),
                    Location = new Point(10, 40),
                    Size = new Size(580, 40)  // Adjusted height for multiline text
                };

                Label organiserLabel = new Label
                {
                    Text = "Organiser: " + row["Organiser"].ToString(),
                    Font = new Font("Arial", 10),
                    Location = new Point(10, 80),
                    Size = new Size(280, 20)
                };

                Label locationLabel = new Label
                {
                    Text = "Location: " + row["Location"].ToString(),
                    Font = new Font("Arial", 10),
                    Location = new Point(330, 80),  // Placed next to the organiser
                    Size = new Size(280, 20)
                };

                Label dateLabel = new Label
                {
                    Text = "Date: " + DateTime.Parse(row["Date"].ToString()).ToString("dd MMM yyyy"),
                    Font = new Font("Arial", 10),
                    Location = new Point(10, 110),
                    Size = new Size(280, 20)
                };

                Label capacityLabel = new Label
                {
                    Text = $"Capacity: {row["Capacity"]}",
                    Font = new Font("Arial", 10),
                    Location = new Point(330, 110),  // Placed next to the date
                    Size = new Size(280, 20)
                };

                // Create a button for the card
                Button joinButton = new Button
                {
                    Text = "Book Event",
                    Font = new Font("Arial", 10),
                    Location = new Point(240, 150),  // Positioned at the bottom of the card
                    Size = new Size(100, 30)
                };

                // Add click event to the button
                joinButton.Click += (s, args) =>
                {
                    int eventId = Convert.ToInt32(row["Id"]);
                    db.AddBooking(memberId, eventId); // Call the method to add the booking
                    int totalEventsJoined = db.GetTotalEventsJoined(memberId); // Fetch the updated count
                    MessageBox.Show($"You have joined the event: {row["Title"]}. Total Events Joined: {totalEventsJoined}");
                };

                // Add labels to the card
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(organiserLabel);
                card.Controls.Add(locationLabel);
                card.Controls.Add(dateLabel);
                card.Controls.Add(capacityLabel);
                card.Controls.Add(joinButton);

                // Add the card to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void filterAndSortEvents()
        {
            // Fetch events again (based on filter criteria)
            DBConnections db = DBConnections.GetInstance();
            DataTable events = db.GetUpcomingEvents();

            // Apply the filters based on CheckBoxes
            if (chkBoxUpcoming.Checked)
            {
                events = events.AsEnumerable()
                               .Where(row => DateTime.Parse(row["Date"].ToString()) > DateTime.Now)
                               .CopyToDataTable();
            }

            if (chkBoxPast.Checked)
            {
                events = events.AsEnumerable()
                               .Where(row => DateTime.Parse(row["Date"].ToString()) < DateTime.Now)
                               .CopyToDataTable();
            }

            if (chkBoxFull.Checked)
            {
                events = events.AsEnumerable()
                               .Where(row => Convert.ToInt32(row["Capacity"]) == Convert.ToInt32(row["Current_Attendees"]))
                               .CopyToDataTable();
            }


                // Apply sorting based on ComboBox selection
                string sortColumn = string.Empty;
            if (cboBoxSort.SelectedItem != null)
            {
                switch (cboBoxSort.SelectedItem.ToString())
                {
                    case "Sort by Title":
                        sortColumn = "Title";
                        break;
                    case "Sort by Date":
                        sortColumn = "Date";
                        break;
                    case "Sort by Organiser":
                        sortColumn = "Organiser";
                        break;
                    case "Sort by Capacity":
                        sortColumn = "Capacity";
                        break;
                }

                if (!string.IsNullOrEmpty(sortColumn))
                {
                    events.DefaultView.Sort = sortColumn + " ASC"; // Ascending order
                    events = events.DefaultView.ToTable();
                }
            }

            // Clear the FlowLayoutPanel before adding new cards
            flowLayoutPanel1.Controls.Clear();

            // Loop through the filtered and sorted events and create cards again
            foreach (DataRow row in events.Rows)
            {
                Panel card = new Panel
                {
                    Size = new Size(300, 150),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                Label titleLabel = new Label
                {
                    Text = row["Title"].ToString(),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Size = new Size(280, 25)
                };

                Label descriptionLabel = new Label
                {
                    Text = row["Description"].ToString(),
                    Location = new Point(10, 40),
                    Size = new Size(280, 50)
                };

                Label dateLabel = new Label
                {
                    Text = DateTime.Parse(row["Date"].ToString()).ToString("dd MMM yyyy"),
                    Location = new Point(10, 90),
                    Size = new Size(280, 25)
                };

                Label locationLabel = new Label
                {
                    Text = "Location: " + row["Location"].ToString(),
                    Location = new Point(10, 120),
                    Size = new Size(280, 20)
                };

                // Add the labels to the card
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(dateLabel);
                card.Controls.Add(locationLabel);

                // Add the card to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void checkBoxLocation_CheckedChanged(object sender, EventArgs e)
        {
            filterAndSortEvents();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterAndSortEvents();
        }
    }
}


    

