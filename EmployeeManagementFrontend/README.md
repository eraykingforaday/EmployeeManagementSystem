# Employee Management System

            This project is a web application for managing employee information, built with Angular for the frontend and ASP.NET Core for the backend.

            ## Technologies Used

            - Angular
            - ASP.NET Core Web API
            - SQL Server
            - Entity Framework Core

            ## Features

            - Add, update, delete, and list employees
            - RESTful Web API
            - User-friendly interface

            ## Setup

            ### Backend

            1. Navigate to the backend project directory.
            2. Run `dotnet restore` to install dependencies.
            3. Update the database connection string in `appsettings.json`.
            4. Run `dotnet ef database update` to create the database.
            5. Run `dotnet run` to start the backend server.

            ### Frontend

            1. Navigate to the frontend project directory.
            2. Run `npm install` to install dependencies.
            3. Run `ng serve` to start the frontend server.

            ## API Endpoints

            - `GET /api/employees`: Get all employees
            - `GET /api/employees/{id}`: Get employee by ID
            - `POST /api/employees`: Add a new employee
            - `PUT /api/employees/{id}`: Update an employee
            - `DELETE /api/employees/{id}`: Delete an employee