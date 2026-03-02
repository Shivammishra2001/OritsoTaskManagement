Oritso Task Management Application

1. Overview

This is a Task Management Application built using ASP.NET Core MVC.
The application allows users to perform full CRUD operations along with Search functionality.

The system follows MVC architecture and uses MS SQL Server as the database.

---

2. Technologies Used

- Backend: ASP.NET Core MVC (.NET 8)
- Database: MS SQL Server
- ORM: Entity Framework Core
- Frontend: Razor Views (Server Side Rendering)
- Version Control: Git & GitHub

---

3. Features Implemented

- Create Task
- Read Task
- Update Task
- Delete Task
- Search Task
- Audit Tracking (Created By / Updated By)

---

4. Database Design

4.1 Approach Used
Code First Approach is used.

Reason:
- Faster development
- Automatic migration support
- Clean structure

4.2 ER Diagram

Task Table contains:

- Id (Primary Key)
- Title
- Description
- DueDate
- Status
- Remarks
- CreatedOn
- UpdatedOn
- CreatedByName
- CreatedById
- UpdatedByName
- UpdatedById

4.3 Data Dictionary

| Column Name | Data Type | Description |
|------------|----------|-------------|
| Id | int | Primary Key |
| Title | string | Task Title |
| Description | string | Task Description |
| DueDate | DateTime | Task Due Date |
| Status | string | Task Status |
| Remarks | string | Additional Notes |
| CreatedOn | DateTime | Record creation time |
| UpdatedOn | DateTime | Last update time |
| CreatedByName | string | Creator Name |
| CreatedById | int | Creator Id |
| UpdatedByName | string | Last Updated By Name |
| UpdatedById | int | Last Updated By Id |

4.4 Index Used

Primary Key index on Id column.

---

5. Application Structure

This project uses:

- MVC Pattern
- Server Side Rendering (MPA)
- Entity Framework Core for DB communication

---

6. Frontend Structure

- Razor Views
- Bootstrap for UI
- Server rendered pages

Reason:
Simple, clean and suitable for CRUD-based applications.

---

7. Build & Installation Guide

7.1 Environment Requirements

- .NET 8 SDK
- MS SQL Server
- Visual Studio 2022

7.2 Steps to Run

1. Clone the repository
2. Open solution in Visual Studio
3. Update Connection String in appsettings.json
4. Run Migration:
