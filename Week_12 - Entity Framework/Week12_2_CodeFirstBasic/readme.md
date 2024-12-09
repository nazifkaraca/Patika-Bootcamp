# 📚 Patika Code First Database Project

Welcome to the **Patika Code First Database Project**! 🚀 This project demonstrates how to create a database using the **Code First** approach in **Entity Framework Core**. The database consists of two independent tables: **Movies** and **Games**. Let's dive into the details! 🌟

![WhatsApp Görsel 2024-12-09 saat 14 45 45_c9af620f](https://github.com/user-attachments/assets/080b5f09-4c29-47ef-a5e3-576c23f21b3d)

---

## 🗂️ Project Overview

In this project, we use the **Code First** approach to define our data structure using C# classes. These classes are mapped to database tables, allowing us to focus on application design without needing to write SQL scripts. 

The database created here is named **PatikaCodeFirstDb1** and includes the following tables:

1. **Movies Table 🎥**
2. **Games Table 🎮**

---

## 🛠️ Database Tables

### 🎥 **Movies Table**
This table stores information about movies, with the following columns:
- `Id` (Primary Key, Auto-Incremented): Unique identifier for each movie.
- `Title`: The name of the movie.
- `Genre`: The movie genre (e.g., Action, Comedy, Drama).
- `ReleaseYear`: The year the movie was released.

---

### 🎮 **Games Table**
This table stores details about games, with the following columns:
- `Id` (Primary Key, Auto-Incremented): Unique identifier for each game.
- `Name`: The name of the game.
- `Platform`: The platform the game is available on (e.g., PC, PlayStation, Xbox).
- `Rating`: The rating of the game (0 to 10).

---

## 📂 Context Class
The **DbContext** class, named `PatikaFirstDbContext`, manages the interaction with the database. It defines `DbSet` properties for both tables:

- `DbSet<Movie> Movies`
- `DbSet<Game> Games`

This ensures that Entity Framework Core knows how to work with these entities in the database.

---

## 🔗 Getting Started

To set up and run this project:

1. Install **Entity Framework Core** in your project.  
   Example:  
   ```
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```

2. Add a migration to define the database schema.  
   Example:  
   ```
   dotnet ef migrations add InitialCreate
   ```

3. Update the database to create tables based on the defined schema.  
   Example:  
   ```
   dotnet ef database update
   ```

4. 🎉 Your database **PatikaCodeFirstDb1** with tables **Movies** and **Games** is ready to use!

---

## 📝 Notes

- The database connection string should be set in your `appsettings.json` or configuration file to ensure the context can connect to the correct server.
- Use appropriate migrations for schema changes to ensure a seamless development workflow.

---

## 💡 Why Code First?

The Code First approach allows developers to:
- Write code in a structured, object-oriented way without worrying about SQL queries initially.
- Keep application and database structures in sync using migrations.
- Focus on business logic rather than database setup.
