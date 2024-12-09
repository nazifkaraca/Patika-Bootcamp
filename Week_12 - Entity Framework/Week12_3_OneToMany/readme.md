# 📚 Patika - Code First Relation Project

Welcome to the **Patika Code First Relation Project**! 🚀 This project demonstrates how to create a relational database using the **Code First** approach in **Entity Framework Core**. The database includes two related tables: `Users` and `Posts`. Let’s explore the details! 🌟

---

## 🗂️ Project Overview

This project showcases the **Code First** approach to define and manage database structures through C# classes. The classes are mapped to relational database tables with Entity Framework Core, enabling developers to focus on application logic without manually writing SQL scripts.

The database created here is named **PatikaCodeFirstDb2** and contains the following tables:

1. **Users Table** 🙍‍♂️
2. **Posts Table** 📝

These tables are designed with a **one-to-many relationship**: 
- A single user can have multiple posts.
- Each post is associated with only one user.

---

## 🛠️ Database Tables

### 🙍‍♂️ Users Table
This table stores user details and includes the following columns:

| **Column**  | **Type** | **Description**                        |
|-------------|----------|----------------------------------------|
| `Id`        | `int`    | Primary Key, Auto-Incremented.         |
| `Username`  | `string` | User's unique username.               |
| `Email`     | `string` | User's email address.                 |

### 📝 Posts Table
This table stores posts created by users and includes the following columns:

| **Column**  | **Type** | **Description**                        |
|-------------|----------|----------------------------------------|
| `Id`        | `int`    | Primary Key, Auto-Incremented.         |
| `Title`     | `string` | Title of the post.                    |
| `Content`   | `string` | Content of the post.                  |
| `UserId`    | `int`    | Foreign Key linked to the `Users` table. |

---

## 📂 Context Class

The **DbContext** class, named `PatikaSecondDbContext`, manages all interactions with the database. It includes `DbSet` properties for the tables:

- `DbSet<User> Users`
- `DbSet<Post> Posts`

Additionally, the relationship between `Users` and `Posts` is defined using Fluent API or Data Annotations to establish a one-to-many relationship.

---

## 🔗 Getting Started

To set up and run this project, follow these steps:

### 1. Install Required Packages
Install the required Entity Framework Core packages for your project:
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### 2. Add Migrations
Define the database schema by adding a migration:
```bash
dotnet ef migrations add InitialCreate
```

### 3. Update the Database
Create the database and apply the migration:
```bash
dotnet ef database update
```

🎉 Your database `PatikaCodeFirstDb2` with tables `Users` and `Posts` is now ready to use!

---

## 📝 Notes

- Set the database connection string in your `appsettings.json` or other configuration files to point to the correct server.
- To reflect any changes in the data model, create new migrations and update the database accordingly:
  ```bash
  dotnet ef migrations add <MigrationName>
  dotnet ef database update
  ```

---

## 💡 Why Code First?

The **Code First** approach offers the following advantages:
- Develop your application in a structured, object-oriented way.
- Automatically synchronize application and database structures with migrations.
- Focus on business logic rather than SQL-based database setup.
