# TogetherCultureCRM

This project is a Customer Relationship Management (CRM) system for Together Culture, a Community Interest Company. The project is organized into multiple access levels with distinct forms for each user role.

---

## Project Directory Structure

The project is organized into the following directories:

- `AdminAccess_Forms`
  - `AdminMainMenu.cs`
  - Admin_Forms
    - `Chats.cs`
    - `Dashboards.cs`
    - `Digital.cs`
    - `Events.cs`
    - `Members.cs`
    - `Reports.cs`
  
- `GuestAccess_Forms`
  - `GuestMainMenu.cs`
  - Guest_Forms
    - `Dashboards.cs`
    - `Digital.cs`
    - `Events.cs`

- `Load_Form`
  - `FormLoad.cs`

- `Login_Form`
  - `FormLogin.cs`

- `Registration_Form`
  - `FormRegistration.cs`

- `MemberAccess_Forms`
  - `MemberMainMenu.cs`
  - Member_Forms
    - `Chats.cs`
    - `Dashboards.cs`
    - `Digital.cs`
    - `Events.cs`
    - `Profile.cs`

- `SuperAdminAccess_Forms`
  - `SuperAdminMainMenu.cs`
  - SuperAdmin_Forms
    - `Dashboards.cs`
    - `Events.cs`
    - `Admins.cs`
    - `Reports.cs`

- `Database`
  - `dbTogetherCulture.mdf` (SQL Server database file)

- `DBConnections`
  - `Constants.cs`
  - `DBConnections.cs`

- `Navigation_Control`
  - `NavigationManager.cs`

- .gitignore file to exclude unnecessary files like bin/, obj/, and user-specific config files (e.g., .vs/)

---

 Features Implemented

1. Login System:
   - Redirects users to respective main menus based on roles:
     - `MemberMainMenu` for Members.
     - `AdminMainMenu` for Admins.
     - `SuperAdminMainMenu` for Super Admins.
   - Displays an error message if credentials are invalid.

2. Database:
   - Includes tables for `Members`, `Admin`, and `SuperAdmin`, with fields for `Username` and `Password`.
   - Test data added for testing purposes:
     - Admin: Username: `admin`, Password: `admin`
     - Member: Username: `abel`, Password: `abel`
     - Super Admin: Username: `superadmin`, Password: `superadmin`

3. Navigation Control:
   - `NavigationManager.cs` ensures seamless navigation between forms.
   Note:  (The NavigationManager class is responsible for managing the navigation between different forms in the application. 
          It provides a centralized way to handle form transitions, ensuring that the application remains organized and easy to maintain.
          This is to promotes clean code by reducing coupling between forms and standardizing navigation behavior, making the application 
          easier to extend and debug as the project grows.)



4. DBConnections Class:
   - Handles database connectivity using the Singleton pattern.
   - Verifies user credentials against the database using `ValidateLogin`.

---

 How to Clone and Open in Visual Studio

 Steps:

1. Open Visual Studio.
2. Clone the Repository:
   - Go to File > Open > Open from Source Control.
   - Select GitHub and sign in to your account if necessary.
   - Clone the repository by pasting the repository URL.

3. Restore Dependencies:
   - Visual Studio will automatically restore NuGet packages for the project.

4. Attach the Database:
   - Open SQL Server Management Studio (SSMS).
   - Attach the `dbTogetherCulture.mdf` file to your local SQL Server instance.

5. Update the Connection String:
   - Navigate to **`Properties > Settings`** in Visual Studio.
   - Update the `TogetherCultureDBConstr` to match your local database connection string.

6. Run the Project:
   - Use the following test credentials for login:
     - Admin: Username: `admin`, Password: `admin`
     - Member: Username: `abel`, Password: `abel`
     - Super Admin: Username: `superadmin`, Password: `superadmin`

---

 Next Steps for Team Members

 Tasks:
- Child Forms Development:
  - Complete forms for your respective user roles (Admin, Member, Super Admin, Guest).
  - Follow the directory structure for placing forms.

- Enhance Navigation:
  - Use `NavigationManager.cs` to manage access between forms.

 Notes:
- Modify test credentials as needed for your tasks.
- Maintain clean, modular code and adhere to the directory structure.

---

 Git Workflow in Visual Studio

1. Create a New Branch:
   - Go to Git > Manage Branches.
   - Create a new branch for your task.

2. Make Changes and Commit:
   - Save your work and stage changes in **Team Explorer > Changes**.
   - Add a commit message and click **Commit All**.

3. Push Changes:
   - Push your branch to the remote repository via **Team Explorer > Sync > Push**.

4. Submit a Pull Request:
   - On GitHub, open a pull request for your branch to merge changes into the main branch.

---

 Contact Information

If you encounter issues or have questions, please me know.

Happy coding! 🚀

