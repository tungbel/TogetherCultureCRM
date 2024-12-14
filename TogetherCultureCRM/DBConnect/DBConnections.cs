using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mime;
//using TogetherCultureCRM.DBConnections;

namespace TogetherCultureCRM.DBConnect
{
    internal class DBConnections
    {
      
            // Singleton instance to ensure only one instance of DBConnections exists
            private static DBConnections instance;

            // Connection string for the database
            private string connStr;

            // SQL connection object
            private SqlConnection connToDB;

            // Private constructor to initialize the connection string from application settings
            private DBConnections()
            {
                connStr = Properties.Settings.Default.TogetherCultureDBConstr;
            }

            // Public method to retrieve the singleton instance of the class
            public static DBConnections GetInstance()
            {
                if (instance == null)
                {
                    instance = new DBConnections();
                }
                return instance;
            }

            // Validates user login by checking username and password against the database
            public string ValidateLogin(string username, string password)
            {
                using (connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open(); // Open the database connection

                    string query = Constants.ValidateLoginUnifiedQuery; // Unified query for login validation

                    using (SqlCommand cmd = new SqlCommand(query, connToDB))
                    {
                        // Add parameters to the SQL query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query and return the result
                        var result = cmd.ExecuteScalar();
                        return result?.ToString(); // If no result, return null
                    }
                }
            }

            // Retrieves the total number of members from the database
            public int GetTotalMembers()
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.GetTotalMembersQuery, connToDB))
                    {
                        return (int)cmd.ExecuteScalar(); // Execute the query and return the result as an integer
                    }
                }
            }

            // Fetches all non-members from the database
            public DataTable GetNonMembers()
            {
                try
                {
                    return ExecuteQuery(Constants.SelectAllNonMembersQuery);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error retrieving non-members: {ex.Message}");
                }
            }

            // Inserts a new non-member into the database
            public int InsertNonMember(SqlParameter[] parameters)
            {
                return ExecuteNonQuery(Constants.InsertNonMemberQuery, parameters);
            }

            // Updates an existing non-member's information in the database
            public int UpdateNonMember(SqlParameter[] parameters)
            {
                return ExecuteNonQuery(Constants.UpdateNonMemberQuery, parameters);
            }

            // Deletes a non-member from the database
            public int DeleteNonMember(SqlParameter[] parameters)
            {
                return ExecuteNonQuery(Constants.DeleteNonMemberQuery, parameters);
            }

            // Retrieves the total number of events from the database
            public int GetTotalEvents()
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.GetTotalEventsQuery, connToDB))
                    {
                        return (int)cmd.ExecuteScalar(); // Execute query and return the count
                    }
                }
            }

            // Retrieves the count of recent bookings
            public int GetRecentBookingsCount()
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.GetRecentBookingsCountQuery, connToDB))
                    {
                        return (int)cmd.ExecuteScalar(); // Execute query and return the count
                    }
                }
            }

            // Retrieves the title of the most recent event
            public string GetLatestEventTitle()
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.GetLatestEventTitleQuery, connToDB))
                    {
                        var result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : "No Events Found"; // Return result or default message
                    }
                }
            }

            // Retrieves all digital content from the database
            public DataTable GetDigitalContent()
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.GetDigitalContentQuery, connToDB))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt); // Fill the DataTable with query results
                            return dt;
                        }
                    }
                }
            }

            // Inserts new digital content into the database
            public int InsertDigitalContent(string title, string description, DateTime uploadDate, string contType, string contentLocation, string duration, string accessType, decimal price, string status)
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.InsertDigitalContentQuery, connToDB))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@UploadDate", uploadDate);
                        cmd.Parameters.AddWithValue("@ContentType", contType);
                        cmd.Parameters.AddWithValue("@ContentLocation", contentLocation);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@AccessType", accessType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);

                        return cmd.ExecuteNonQuery(); // Execute the query and return rows affected
                    }
                }
            }

            // Updates an existing digital content record in the database
            public int UpdateDigitalContent(int contentId, string title, string description, DateTime uploadDate, string contType, string contentLocation, string duration, string accessType, decimal price, string status)
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.UpdateDigitalContentQuery, connToDB))
                    {
                        cmd.Parameters.AddWithValue("@ContentId", contentId);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@UploadDate", uploadDate);
                        cmd.Parameters.AddWithValue("@ContentType", contType);
                        cmd.Parameters.AddWithValue("@ContentLocation", contentLocation);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@AccessType", accessType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }

            // Deletes digital content from the database
            public int DeleteDigitalContent(int contentId)
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(Constants.DeleteDigitalContentQuery, connToDB))
                    {
                        cmd.Parameters.AddWithValue("@ContentId", contentId);
                        return cmd.ExecuteNonQuery(); // Execute and return rows affected
                    }
                }
            }

            // Retrieves all benefits
            public DataTable GetBenefits()
            {
                try
                {
                    return ExecuteQuery(Constants.SelectAllBenefitsQuery);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error retrieving benefits: {ex.Message}");
                }
            }

            // Fetches a member's details by their ID
            public DataTable GetMemberDetailsById(int memberId)
            {
                try
                {
                    string query = Constants.GetMemberDetailsQuery; // Query to fetch member details
                    SqlParameter[] parameters = { new SqlParameter("@MemberId", memberId) }; // Add parameter for the query
                    return ExecuteQuery(query, parameters); // Execute the query and return results
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fetching member details: {ex.Message}");
                }
            }

            // A method use to Updates a member's profile picture
            public void UpdateMemberProfilePicture(int memberId, byte[] pictureData)
            {
                try
                {
                    string query = Constants.UpdateMemberPictureQuery; // Query to update the picture
                    SqlParameter[] parameters =
                    {
                      new SqlParameter("@MemberId", memberId), // Member ID parameter
                      new SqlParameter("@ProfilePicture", pictureData) // Profile picture parameter
                };
                     ExecuteNonQuery(query, parameters); // Execute the query
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating profile picture: {ex.Message}");
                }
            }

            // Checks if an email is unique in the database
            public bool IsEmailUnique(string email)
            {
                try
                {
                    string query = Constants.CheckEmailUniqueQuery; // Query to check email uniqueness
                    SqlParameter[] parameters = { new SqlParameter("@Email", email) }; // Add email as a parameter
                    int count = (int)ExecuteScalar(query, parameters); // Execute query and get the count
                    return count == 0; // Return true if no records found, false otherwise
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error checking email uniqueness: {ex.Message}");
                }
            }

            // Executes a scalar query and returns the result
            public object ExecuteScalar(string query, SqlParameter[] parameters = null)
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(query, connToDB))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar(); // Execute the scalar query and return the result
                    }
                }
            }

            // Executes SELECT queries and returns a DataTable
            public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
            {
                using (var connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    using (var cmd = new SqlCommand(query, connToDB))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (var da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt); // Fill the DataTable with query results
                            return dt;
                        }
                    }
                }
            }

            // Executes INSERT, UPDATE, DELETE queries and returns the number of affected rows
            public int ExecuteNonQuery(string query, SqlParameter[] parameters)
            {
                try
                {
                    using (var connToDB = new SqlConnection(connStr))
                    {
                        connToDB.Open();
                        using (var cmd = new SqlCommand(query, connToDB))
                        {
                            if (parameters != null)
                            {
                                cmd.Parameters.AddRange(parameters);
                            }

                            return cmd.ExecuteNonQuery(); // Execute and return rows affected
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error executing query: {ex.Message}");
                }
            }
        }

    }

