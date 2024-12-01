using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCultureCRM.DBConnect;

namespace TogetherCultureCRM.DBConnect
{
    internal class DBConnections
    {
        //private object of the class itself
        // Singleton pattern to ensure a single instance
        private static DBConnections instance;

        //connection to string
        private string connStr;

        // Database connection object 
        private SqlConnection connToDB;

        // Private constructor to initialize the connection string
        private DBConnections() 
        {
            connStr = Properties.Settings.Default.TogetherCultureDBConstr;
        }

        // Public method to get the instance of the class
        public static DBConnections GetInstance()
        {
            if (instance == null)
            {
                instance = new DBConnections();
            }
            return instance;
        }

        public string ValidateLogin(string username, string password)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.ValidateLoginUnifiedQuery; // Use the unified query from Constants

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    var result = cmd.ExecuteScalar();
                    return result?.ToString(); // Returns Role if found, null otherwise
                }
            }
        }


        // Get Total Events Joined by Member
        public int GetTotalEventsJoined(int member_Id)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.QueryTotalEventsJoined;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Member_Id", member_Id);

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result ?? 0); // Return 0 if null
                }
            }
        }

        // Get Upcoming Events
        public DataTable GetUpcomingEvents()
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.QueryUpcomingEvents;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        // Add event to booking
        public void AddBooking(int memberId, int eventId)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = "INSERT INTO Booking (Member_Id, Event_Id) VALUES (@Member_Id, @Event_Id)";

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Member_Id", memberId);
                    cmd.Parameters.AddWithValue("@Event_Id", eventId);

                    cmd.ExecuteNonQuery(); // Execute the insert command
                }
            }
        }

        // Get Benefits Used for a Member
        public void UseBenefit(int memberId, int benefitId)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = "INSERT INTO Member_Benefit_Usage (Member_Id, Benefit_Id, Usage_Date) VALUES (@Member_Id, @Benefit_Id, @Usage_Date)";

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Member_Id", memberId);
                    cmd.Parameters.AddWithValue("@Benefit_Id", benefitId);
                    cmd.Parameters.AddWithValue("@Usage_Date", DateTime.Now);

                    cmd.ExecuteNonQuery(); // Executes the insert command
                }
            }
        }

        // Get Benefits Summary for a Member
        public DataRow GetBenefitsSummary(int member_Id)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.QueryBenefitsSummary;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Member_Id", member_Id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
                    }
                }
            }
        }

        // Get Benefits Used List
        public DataTable GetBenefitsUsedList(int member_Id)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                using (SqlCommand cmd = new SqlCommand(Constants.QueryBenefitsUsed, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Member_Id", member_Id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        // Get Benefits Available List
        public DataTable GetBenefitsAvailableList()
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                using (SqlCommand cmd = new SqlCommand(Constants.QueryBenefitsAvailable, connToDB))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }


        // Get Latest Digital Content
        public DataTable GetLatestDigitalContent()
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.QueryLatestDigitalContent;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        // Get All Events for Form
        public DataTable GetAllEventsForForm()
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.QueryAllEventsForForm;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public DataTable GetConnectionsByType(string connectionType)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();

                // Use the query from the Constants class
                string query = Constants.GetConnectionsByTypeQuery;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    // Add the parameter for the connection type
                    cmd.Parameters.AddWithValue("@ConnectionType", connectionType);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Fill and return the DataTable with the results
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public void PostNewConnection(string Type, string title, string description, string category, string contact_Details)
        {
            using (connToDB = new SqlConnection(connStr))
            {
                connToDB.Open();
                string query = Constants.InsertNewConnection;

                using (SqlCommand cmd = new SqlCommand(query, connToDB))
                {
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Contact_Details", contact_Details);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Is_Active", 1); // Assuming all new connections are active initially

                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
