# 🏥 Hospital Management System

This repository contains a simple database-first project for managing a hospital system using SQL Server and Entity Framework Core. The project involves tables for managing **Patients**, **Doctors**, **Appointments**, and **Treatments**, showcasing relationships and scaffolding the database into a C# project.

---

## 📋 Project Overview

The **Hospital Management System** project uses the following database structure:

- **`Patients`**: Stores information about patients.
- **`Doctors`**: Contains data about doctors and their specializations.
- **`Appointments`**: Tracks patient-doctor appointments.
- **`Treatments`**: Logs treatments associated with specific appointments.

The project demonstrates a **database-first** approach, where the database schema is created in SQL Server and scaffolded into C# models using Entity Framework Core.

---

## 🛠️ Database Structure

### 📂 Tables

1. **`Patients`**
   - `PatientID` (Primary Key)
   - `FirstName`
   - `LastName`
   - `DateOfBirth`
   - `PhoneNumber`

2. **`Doctors`**
   - `DoctorID` (Primary Key)
   - `FirstName`
   - `LastName`
   - `Specialization`

3. **`Appointments`**
   - `AppointmentID` (Primary Key)
   - `PatientID` (Foreign Key referencing `Patients.PatientID`)
   - `DoctorID` (Foreign Key referencing `Doctors.DoctorID`)
   - `AppointmentDate`
   - `Description`

4. **`Treatments`**
   - `TreatmentID` (Primary Key)
   - `AppointmentID` (Foreign Key referencing `Appointments.AppointmentID`)
   - `TreatmentName`
   - `TreatmentDate`
   - `Notes`

---

## ⚙️ Installation & Setup

### 1️⃣ Prerequisites
- SQL Server
- .NET SDK
- Entity Framework Core

### 2️⃣ Steps
1. **Clone the Repository**
   ```bash
   git clone https://github.com/nazifkaraca/Patika-Bootcamp.git
   cd Week_12 - Entity Framework/Week12_5_HospitalManagement-DatabaseFirst
   ```

2. **Database Creation**
   Run the following SQL script to create the database and tables:
   ```sql
   CREATE DATABASE HospitalManagement;

   USE HospitalManagement;

   CREATE TABLE Patients (
       PatientID INT PRIMARY KEY IDENTITY,
       FirstName NVARCHAR(50),
       LastName NVARCHAR(50),
       DateOfBirth DATE,
       PhoneNumber NVARCHAR(15)
   );

   CREATE TABLE Doctors (
       DoctorID INT PRIMARY KEY IDENTITY,
       FirstName NVARCHAR(50),
       LastName NVARCHAR(50),
       Specialization NVARCHAR(100)
   );

   CREATE TABLE Appointments (
       AppointmentID INT PRIMARY KEY IDENTITY,
       PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
       DoctorID INT FOREIGN KEY REFERENCES Doctors(DoctorID),
       AppointmentDate DATETIME,
       Description NVARCHAR(500)
   );

   CREATE TABLE Treatments (
       TreatmentID INT PRIMARY KEY IDENTITY,
       AppointmentID INT FOREIGN KEY REFERENCES Appointments(AppointmentID),
       TreatmentName NVARCHAR(100),
       TreatmentDate DATE,
       Notes NVARCHAR(1000)
   );
   ```

3. **Scaffold the Database**
   Use the following command to scaffold the database into C# models:
   ```bash
   scaffold-dbcontext "your_connection_string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
   ```

---

## 🧑‍💻 Usage

- The scaffolded models are located in the `Models` folder.
- Use these models to perform CRUD operations and develop further functionalities in the project.
