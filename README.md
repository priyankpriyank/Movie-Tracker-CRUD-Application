# 🎬 Movie Tracker CRUD Application

A full-stack Movie Tracker web app built with ASP.NET Core MVC, Entity Framework Core, and SQL Server. This project allows users to create, update, view, and delete movie entries while tracking status and filtering based on rating.

## 🔧 Tech Stack
- **Backend**: ASP.NET Core MVC, C#
- **ORM**: Entity Framework Core (Code-First)
- **Database**: SQL Server / SQLite
- **Frontend**: Razor Views (Bootstrap for layout)
- **Tools**: Visual Studio, SSMS

## ✨ Features
- 🔄 Full CRUD for Movies (Create, Read, Update, Delete)
- 🔍 Advanced Search & Sort by title, genre, rating, or status
- 🎯 Status Tracking (Watched, Planning, Dropped, etc.)
- 🚀 Optimized SQL queries with indexing
- 🧪 Seed data for demo/testing
- 📱 Responsive UI with basic Bootstrap styling

## 📷 Screenshots
*(Insert 2–3 screenshots of UI if available)*

## 🧱 Database Schema (Simplified)
- `Movie`
  - `Id`: int
  - `Title`: string
  - `Genre`: string
  - `Rating`: int
  - `ReleaseDate`: DateTime
  - `CreatedAt`: DateTime

## 🚀 Getting Started
1. Clone this repository
2. Open in Visual Studio
3. Run migrations:  
   ```bash
   Update-Database
