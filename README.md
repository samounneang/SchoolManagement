# School Management System

## Overview

The **School Management System** is a Windows Forms application developed using C# .NET Framework 8.0. This application manages various aspects of a school's operations, including student enrollment, teacher management, class scheduling, attendance tracking, and report generation.

## Features

- **Student Management**: Add, edit, delete, and view student details.
- **Teacher Management**: Manage teacher information and assignments.
- **Class Scheduling**: Create and manage class schedules for different grades and subjects.
- **Attendance Tracking**: Record and monitor student and teacher attendance.
- **Report Generation**: Generate various reports, such as student performance, attendance records, and more.
- **User Authentication**: Secure login for administrators and staff members with encrypted password storage.

## Technologies Used

- **C#**: Core programming language for the application.
- **Windows Forms**: Used for building the graphical user interface.
- **SQL Server**: A database management system for storing application data.
- **.NET Framework 8.0**: The framework version used to develop the application.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/samounneang/SchoolManagement
2. **Open the Solution**:
   Open the solution file (SchoolManagement.sln) in Visual Studio.
- **Set Up the Database**:
   Create a new database in SQL Server.
   Run the provided SQL scripts in the Database folder to set up the necessary tables and stored procedures.
   Update the connection string in the App.config file to point to your SQL Server instance.
3. **Build and Run**:
   Build the solution in Visual Studio by clicking on Build > Build Solution.
   Run the application by pressing F5 or selecting Debug > Start Debugging.
