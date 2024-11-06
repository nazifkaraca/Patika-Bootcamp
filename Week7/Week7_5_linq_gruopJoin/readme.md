# School Database System

This project is a simple **School Database System** developed in C#. It demonstrates the use of **LINQ group join** operations to organize and display data between two related tables: **Students** and **Classes**. The main objective is to showcase how LINQ can perform a group join to list students by their respective classes.

![image](https://github.com/user-attachments/assets/ed29a70f-132d-4331-97a9-a236aa4e890b)

## Project Overview

The School Database System contains two primary tables:
- **Students**: Holds details about each student.
- **Classes**: Contains details of each class, with a unique identifier that links to the students in that class.

The application initializes with sample data, including multiple classes and students, and performs a LINQ query to group students under each class, displaying the class name and the names of the students enrolled in that class.

### Table Structure

The structure of each table is as follows:

1. **Students Table**:
   - `StudentId` (int): Unique identifier for each student.
   - `StudentName` (string): Name of the student.
   - `ClassId` (int): Foreign key that links to the `ClassId` in the **Classes** table.

2. **Classes Table**:
   - `ClassId` (int): Unique identifier for each class.
   - `ClassName` (string): Name of the class.

### Features

- **Class Definitions**: The project includes `Student` and `Class` classes, where each class represents a table structure.
- **Data Initialization**: Sample data is added to both the **Students** and **Classes** tables, with at least three classes and multiple students.
- **LINQ Group Join**: A LINQ group join operation is used to combine the **Students** and **Classes** tables based on the `ClassId`, grouping students by class.
- **Output Display**: The result of the LINQ group join is displayed on the console, showing each class name followed by the names of students enrolled in that class.

### Usage

The School Database System can be used as a basic template to understand how to:

- Define classes to represent database tables.
- Populate data for demonstration purposes.
- Use LINQ queries to perform group joins and retrieve specific information.
- Display query results in a structured format that groups related records.

### Example Output

The console output of this project displays each class along with the names of the students enrolled in it, formatted as follows:

```
Introduction to Programming
---------------------------
- Alice Smith
- Carol White

Data Structures
---------------------------
- Bob Johnson
- Eve Miller

Web Development
---------------------------
- Dave Brown
```

This format makes it easy to identify which students belong to which class within the school system.﻿
