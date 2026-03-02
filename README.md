Oritso Task Management Application

1. Overview

This is a **Task Management Application** built using **ASP.NET Core MVC**.  
The application allows users to perform full **CRUD operations** along with **Search functionality**.

The system follows **MVC architecture** and uses **MS SQL Server** as the database.

---

2. Technologies Used

- **Backend:** ASP.NET Core MVC (.NET 8)  
- **Database:** MS SQL Server  
- **ORM:** Entity Framework Core  
- **Frontend:** Razor Views (Server Side Rendering)  
- **UI Framework:** Bootstrap 5  
- **Version Control:** Git & GitHub  
- **Other Tools:** Visual Studio 2022, Postman (for testing APIs, optional)

---

3. Features Implemented

- Create Task  
- Read Task  
- Update Task  
- Delete Task  
- Search Task (by Title or Status)  
- Audit Tracking (Created By / Updated By)  
- Form Validation (Server-side using Data Annotations)  

---

4. Database Design

4.1 Approach Used
Manual Database Creation** using SQL script.  

> Note: EF Core migrations were not used. Database tables were created manually.

Reason:
- Faster setup for demonstration
- No migration dependency
- Full control over table structure

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

| Column Name    | Data Type | Description                   |
|----------------|----------|-------------------------------|
| Id             | int      | Primary Key                   |
| Title          | nvarchar(200) | Task Title               |
| Description    | nvarchar(max) | Task Description         |
| DueDate        | date     | Task Due Date                 |
| Status         | nvarchar(50) | Task Status               |
| Remarks        | nvarchar(max) | Additional Notes          |
| CreatedOn      | datetime | Record creation time          |
| UpdatedOn      | datetime | Last update time              |
| CreatedByName  | nvarchar(100) | Creator Name             |
| CreatedById    | int      | Creator Id                    |
| UpdatedByName  | nvarchar(100) | Last Updated By Name     |
| UpdatedById    | int      | Last Updated By Id            |

4.4 Index Used
- Primary Key index on Id column.

4.5 SQL Table Creation Script

SQL Create Query
CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    DueDate DATE NOT NULL,
    Status NVARCHAR(50) NULL,
    Remarks NVARCHAR(MAX) NULL,
    CreatedOn DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedOn DATETIME NULL,
    CreatedByName NVARCHAR(100) NULL,
    CreatedById INT NULL,
    UpdatedByName NVARCHAR(100) NULL,
    UpdatedById INT NULL
);
5. Application Structure

- **MVC Pattern**  
- **Server Side Rendering (MPA)**  
- **Entity Framework Core** for DB communication  
- Controllers handle **CRUD & Search logic**  
- Models represent **Task entity**  
- Views use **Razor pages + Bootstrap** for layout and styling  

---

6. Frontend Structure

- Razor Views for pages:  
  - Task List  
  - Create Task  
  - Edit Task  
  - Task Details  
- Bootstrap 5 for responsive UI  
- Server-rendered pages  
- Validation using **Data Annotations** (Title required, max length, date validation)  

Reason: Simple, clean, and suitable for CRUD-based applications.

---

7. Build & Installation Guide

7.1 Environment Requirements

- .NET 8 SDK  
- MS SQL Server  
- Visual Studio 2022  
- Git (for version control)  

7.2 Steps to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Shivammishra2001/OritsoTaskManagement.git
