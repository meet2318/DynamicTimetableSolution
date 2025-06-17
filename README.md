# Dynamic Time Table Generator

A .NET Core full-stack project to dynamically generate a class timetable based on user input.

##  Technologies Used

- ASP.NET Core Web API (.NET 8)
- ASP.NET Core MVC (HTML Helpers)
- Entity Framework Core
- SQL Server
- MediatR (CQRS Pattern)
- AutoMapper

## Project Structure

- `DynamicTimetableSolution/` – Web API project
- `DynamicTimetable.Web/` – MVC Frontend project
- `Database/DynamicTimetableDB_Script.sql` – SQL script with schema and sample data
- `DynamicTimetableSolution.sln` – Solution file

## Folder Layout

DynamicTimetableSolution/
|
├── DynamicTimetableSolution/ # Backend (Web API)
│ ├── Controllers/
│ ├── Application_Layer/
│ ├── Services_Layer/
│ ├── Repositories_Layer/
│ ├── Infrastructure_Layer/
│ └── Program.cs
│
├── DynamicTimetable.Web/ # Frontend (MVC)
│ ├── Controllers/
│ ├── Views/
│ ├── Models/
│ └── Program.cs
│
├── Database/
│ └── DynamicTimetableDB_Script.sql
│
└── DynamicTimetableSolution.sln # Solution file
