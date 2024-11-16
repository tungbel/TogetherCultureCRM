using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCultureCRM.DBConnections
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

        // Database Table Names
        public const string MembersTable = "Member";
        public const string AdminTable = "Admin";
        public const string SuperAdminTable = "Super_Admin";

        // Error Messages
        public const string InvalidLoginMessage = "Invalid username or password. Please try again.";

    }
}
