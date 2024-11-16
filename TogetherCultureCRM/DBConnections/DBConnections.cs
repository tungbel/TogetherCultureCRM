using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCultureCRM.DBConnections;

namespace TogetherCultureCRM.DBConnections
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

    }
}
