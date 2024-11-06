# Library Management System

This project is a simple **Library Management System** developed in C#. It demonstrates the use of **LINQ join** operations to manage and query data between two related tables: **Authors** and **Books**. The main objective of the project is to showcase how LINQ can be used to join two tables and extract meaningful information by querying relational data.

![image](https://github.com/user-attachments/assets/41b8a10b-2f10-4a32-84fc-ae9729d339e4)

## Project Overview

The Library Management System contains two primary tables:
- **Authors**: Holds details about each author.
- **Books**: Contains details of books, each linked to an author by a unique identifier.

The application initializes with sample data, including multiple authors and books, and performs a LINQ query to join the tables, displaying the title of each book alongside its author's name.

### Table Structure

The structure of each table is as follows:

1. **Authors Table**:
   - `AuthorId` (int): Unique identifier for each author.
   - `Name` (string): Name of the author.

2. **Books Table**:
   - `BookId` (int): Unique identifier for each book.
   - `Title` (string): Title of the book.
   - `AuthorId` (int): Foreign key that links to the `AuthorId` in the **Authors** table.

### Features

- **Class Definitions**: The project includes `Author` and `Book` classes, where each class represents a table structure.
- **Data Initialization**: Sample data is added to both the **Authors** and **Books** tables, with at least three authors and four books.
- **LINQ Query with Join**: A LINQ join operation is used to combine the **Authors** and **Books** tables based on the `AuthorId`.
- **Output Display**: The result of the LINQ query is displayed on the console, showing each book's title along with its author's name.

### Usage

The Library Management System can be used as a basic template to understand how to:

- Define classes to represent database tables.
- Populate data for demonstration purposes.
- Use LINQ queries to join related tables and retrieve specific information.
- Display query results in a structured format.

### Example Output

The console output of this project displays a list where each line represents a book title and its corresponding author, formatted as follows:

```
Title: [Book Title], Author: [Author Name]
```

This simple format makes it easy to identify which author has written which book in the library system.


