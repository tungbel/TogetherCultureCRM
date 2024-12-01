using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogetherCultureCRM.Properties;

namespace TogetherCultureCRM.DBConnect
{
    internal class Constants
    {
        // SQL Queries
        public const string ValidateMemberLoginQuery = "SELECT 'Member' AS Role FROM Member WHERE Username = @Username AND Password = @Password";
        public const string ValidateAdminLoginQuery = "SELECT 'Admin' AS Role FROM Admin WHERE Username = @Username AND Password = @Password";
        public const string ValidateSuperAdminLoginQuery = "SELECT 'Super_Admin' AS Role FROM Super_Admin WHERE Username = @Username AND Password = @Password";

        // Unified Query for Role Validation
        public const string ValidateLoginUnifiedQuery = @"
            SELECT 'Member' AS Role FROM Member WHERE Username = @Username AND Password = @Password
            UNION
            SELECT 'Admin' AS Role FROM Admin WHERE Username = @Username AND Password = @Password
            UNION
            SELECT 'Super_Admin' AS Role FROM Super_Admin WHERE Username = @Username AND Password = @Password";

        // Queries for Member Dashboard Features
        public const string QueryTotalEventsJoined =
            "SELECT COUNT(*) FROM Booking WHERE Member_Id = @Member_Id";

        public const string QueryBenefitsSummary = @"
            SELECT 
        (SELECT SUM(Total_Benefit) FROM Benefit WHERE Is_Active = 1) AS Benefit_Available,
        (SELECT COUNT(*) FROM Member_Benefit_Usage WHERE Member_Id = @Member_Id) AS Benefit_Used";

        public const string QueryBenefitsUsed = @"
            SELECT 
                Benefit.Benefit_Name AS [Benefit Name],
                Benefit.Benefit_Description AS [Description],
                Member_Benefit_Usage.Usage_Date AS [Usage Date]
            FROM Member_Benefit_Usage
            INNER JOIN Benefit ON Member_Benefit_Usage.Benefit_Id = Benefit.Benefit_Id
            WHERE Member_Benefit_Usage.Member_Id = @Member_Id";

        public const string QueryBenefitsAvailable = @"
            SELECT 
                Benefit.Benefit_Name AS [Benefit Name],
                Benefit.Benefit_Description AS [Description],
                Benefit.Total_Benefit AS [Total Available]
            FROM Benefit
            WHERE Benefit.Is_Active = 1";

        public const string QueryUpcomingEvents =
            "SELECT Title, Description, Organiser, Date, Location, Capacity FROM Event WHERE Date > GETDATE()";
        
        public const string QueryAllEventsForForm =
            "SELECT Title, Description, Organiser, Date, Location, Capacity FROM Event";

        public const string QueryLatestDigitalContent =
            "SELECT Title FROM Digital_Content ORDER BY Upload_Date DESC";

        // Query for Getting Connections by Type(either 'Need' or 'Offer')
        public const string GetConnectionsByTypeQuery = @"
            SELECT Title, Description, Category, Contact_Details, Created_Date 
            FROM Connections
            WHERE Is_Active = 1 AND Type = @ConnectionType"; // Added filtering by type

        public const string InsertNewConnection = @"
            INSERT INTO Connections (Type, Title, Description, Category, Contact_Details, Created_Date, Is_Active) 
            VALUES (@Type, @Title, @Description, @Category, @Contact_Details, GETDATE(), @Is_Active)";

        // Database Table Names
        public const string MembersTable = "Member";
        public const string AdminTable = "Admin";
        public const string SuperAdminTable = "Super_Admin";
        public const string BookingTable = "Booking";
        public const string EventsTable = "Event";
        public const string DigitalContentTable = "Digital_Content";

        // Error Messages
        public const string InvalidLoginMessage = "Invalid username or password. Please try again.";

        // Success Messages
        public const string DashboardLoadSuccess = "Dashboard data loaded successfully.";
        public const string DashboardLoadFailure = "Failed to load dashboard data. Please check your connection.";
    }
}
