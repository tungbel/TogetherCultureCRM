using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogetherCultureCRM.DBConnect
{
    internal class Constants
    {
        // Queries for validating user roles during login

        // Validates login for a member
        public const string ValidateMemberLoginQuery = "SELECT 'MemberTbl' AS Role FROM Member WHERE Username = @Email AND Password = @Password";

        // Validates login for an admin
        public const string ValidateAdminLoginQuery = "SELECT 'Admin' AS Role FROM Admin WHERE Username = @Username AND Password = @Password";

        // Validates login for a super admin
        public const string ValidateSuperAdminLoginQuery = "SELECT 'Super_Admin' AS Role FROM Super_Admin WHERE Username = @Username AND Password = @Password";

        // Unified query to validate login for all roles (Member, Admin, and Super_Admin)
        public const string ValidateLoginUnifiedQuery = @"
          SELECT 'Member' AS Role FROM MemberTbl WHERE Email = @Username AND Password = @Password
          UNION
          SELECT 'Admin' AS Role FROM Admin WHERE Username = @Username AND Password = @Password
          UNION
          SELECT 'Super_Admin' AS Role FROM Super_Admin WHERE Username = @Username AND Password = @Password";

        // Database table names (for consistency and reuse)
        public const string MembersTable = "MemberTbl"; // Table name for storing members
        public const string AdminTable = "Admin"; // Table name for storing admins
        public const string SuperAdminTable = "Super_Admin"; // Table name for storing super admins

        // Common error message for invalid login attempts
        public const string InvalidLoginMessage = "Invalid username or password. Please try again.";

        // Query for inserting a new event
        public const string InsertEventQuery = @"
            INSERT INTO Event (Title, Date, Location, Organiser, Description, Capacity, Current_Capacity, CreatedDate)
            VALUES (@Title, @Date, @Location, @Organiser, @Description, @Capacity, @Current_Capacity, @CreatedDate)";

        // Query to fetch all events from the database
        public const string SelectAllEventsQuery = "SELECT * FROM Event";

        // Query for updating an existing event
        public const string UpdateEventQuery = @"
            UPDATE Event 
            SET Title = @Title, Date = @Date, Location = @Location, Organiser = @Organiser, 
                Description = @Description, Capacity = @Capacity, Current_Capacity = @Current_Capacity, CreatedDate = @CreatedDate
            WHERE Event_Id = @EventId";

        // Query to delete an event from the database
        public const string DeleteEventQuery = "DELETE FROM Event WHERE Event_Id = @EventId";

        // Query to retrieve all members from the database
        public const string SelectAllMembersQuery = "SELECT * FROM MemberTbl";

        // Query for inserting a new member
        public const string InsertMemberQuery = @"
            INSERT INTO MemberTbl 
            (FirstName, LastName, Email, Phone, Interests, MembershipType, JoinedDate, Gender, DateOfBirth, Password, Benefits) 
            VALUES 
            (@FirstName, @LastName, @Email, @Phone, @Interests, @MembershipType, @JoinedDate, @Gender, @DateOfBirth, @Password, @Benefits)";

        // Query to check if an email address is unique in the members table
        public const string CheckEmailUniqueQuery = "SELECT COUNT(*) FROM MemberTbl WHERE Email = @Email";

        // Query for updating an existing member's information
        public const string UpdateMemberQuery = @"
            UPDATE MemberTbl 
            SET FirstName = @FirstName, 
                LastName = @LastName, 
                Email = @Email, 
                Phone = @Phone, 
                Interests = @Interests, 
                MembershipType = @MembershipType, 
                JoinedDate = @JoinedDate, 
                Gender = @Gender, 
                DateOfBirth = @DateOfBirth, 
                Password = @Password,
                Benefits = @Benefits
            WHERE Member_ID = @Member_ID";

        // Query to delete a member from the database
        public const string DeleteMemberQuery = "DELETE FROM MemberTbl WHERE Member_ID = @Member_ID";

        // Query to retrieve all non-members from the database
        public const string SelectAllNonMembersQuery = "SELECT * FROM Non_Member";

        // Query for inserting a new non-member
        public const string InsertNonMemberQuery = @"
           INSERT INTO Non_Member (FirstName, LastName, Email, Phone, Interests, MembershipType)
           VALUES (@FirstName, @LastName, @Email, @Phone, @Interests, @MembershipType)";

        // Query for updating an existing non-member
        public const string UpdateNonMemberQuery = @"
           UPDATE Non_Member 
           SET FirstName = @FirstName, 
           LastName = @LastName, 
           Email = @Email, 
           Phone = @Phone, 
           Interests = @Interests, 
           MembershipType = @MembershipType
         WHERE Non_MemberId = @Non_MemberId";

        // Query to delete a non-member from the database
        public const string DeleteNonMemberQuery = "DELETE FROM Non_Member WHERE Non_MemberId = @Non_MemberId";

        // Dashboard-related queries

        // Query to count total members in the database
        public const string GetTotalMembersQuery = "SELECT COUNT(*) FROM MemberTbl";

        // Query to count total events in the database
        public const string GetTotalEventsQuery = "SELECT COUNT(*) FROM Event";

        // Query to count recent bookings (last 10 bookings)
        public const string GetRecentBookingsCountQuery = @"
            SELECT COUNT(*) FROM (
                SELECT TOP 10 Booking_Date FROM Booking ORDER BY Booking_Date DESC
            ) AS RecentBookings";

        // Query to fetch the most recent event title
        public const string GetLatestEventTitleQuery = "SELECT TOP 1 Title FROM Event ORDER BY CreatedDate DESC";

        // Query to retrieve all digital content from the database
        public const string GetDigitalContentQuery = @"
            SELECT Digital_Content_Id, Title, Description, Upload_Date, Content_Type, Content_Location, Duration, Access_Type, Price, Status 
            FROM Digital_Content_Modules";

        // Query for inserting a new digital content record
        public const string InsertDigitalContentQuery = @"
            INSERT INTO Digital_Content_Modules 
            (Title, Description, Upload_Date, Content_Type, Content_Location, Duration, Access_Type, Price, Status) 
            VALUES 
            (@Title, @Description, @UploadDate, @ContentType, @ContentLocation, @Duration, @AccessType, @Price, @Status)";

        // Query for updating an existing digital content record
        public const string UpdateDigitalContentQuery = @"
            UPDATE Digital_Content_Modules 
            SET Title = @Title, 
                Description = @Description, 
                Content_Type =  @ContentType,
                Content_Location = @ContentLocation, 
                Duration = @Duration, 
                Access_Type = @AccessType, 
                Price = @Price, 
                Status = @Status
            WHERE Digital_Content_Id = @ContentId";

        // Query to delete a digital content record
        public const string DeleteDigitalContentQuery = "DELETE FROM Digital_Content_Modules WHERE Digital_Content_Id = @ContentId";

        // Query to retrieve all benefits from the benefits table
        public const string SelectAllBenefitsQuery = "SELECT Benefit_Id, Benefit_Name, Benefit_Description, Total_Benefit, Is_Active FROM Benefit";

        // Query to fetch member details by member ID
        public const string GetMemberDetailsQuery = @"
            SELECT FirstName, LastName, Email, Phone, Interests, MembershipType, JoinedDate, Gender, DateOfBirth, Password,  Benefits, ProfilePicture
            FROM MemberTbl
            WHERE Member_ID = @MemberId";

        // Query to update a member's profile picture
        public const string UpdateMemberPictureQuery = @"
            UPDATE MemberTbl
            SET ProfilePicture = @ProfilePicture
            WHERE Member_ID = @MemberId";

        // Query to search for members by First Name, Last Name, or Email
        public const string SearchMemberQuery = @"
            SELECT * 
            FROM MemberTbl 
            WHERE FirstName LIKE '%' + @SearchTerm + '%' 
            OR LastName LIKE '%' + @SearchTerm + '%' 
            OR Email LIKE '%' + @SearchTerm + '%'";

        // Query to search for non-members by First Name, Last Name, or Email
        public const string SearchNonMemberQuery = @"
            SELECT * 
            FROM Non_Member 
            WHERE FirstName LIKE '%' + @SearchTerm + '%' 
            OR LastName LIKE '%' + @SearchTerm + '%' 
            OR Email LIKE '%' + @SearchTerm + '%'";


    }
}