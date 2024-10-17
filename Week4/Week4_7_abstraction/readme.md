# Employee Management System

This project demonstrates **Abstraction** in C# by simulating a company's employee management system. The system models different employees with shared attributes but distinct tasks based on their job roles. It uses an abstract class to define shared behavior and properties, while specific roles such as `ProjectManager`, and `SoftwareDeveloper` provide their own implementations of the task method.

## Project Overview

- **Abstract Class**: `Employee` defines common properties like `Name`, `Surname`, and `Department`, and declares an abstract method `Gorev()`.
- **Subclasses**: Each job role (`ProjectManager`, `SoftwareDeveloper`, `SalesRepresentative`) implements the `Gorev()` method to describe their specific job responsibilities.
  
### Example Output

For a `ProjectManager` named Hasan Çýldýrmýþ, calling `Gorev()` outputs:

```
Hasan Çýldýrmýþ þirketin Proje yöneticisi.
Proje yöneticisi olarak çalýþýyorum.
```

## Code Structure

```
src/
??? Abstraction.cs          # Abstract base class
??? Program.cs              # Main entry point for the simulation
```

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/employee-management-system.git
   ```
2. Navigate to the project directory:
   ```bash
   cd employee-management-system
   ```

## Usage

1. Compile the project (using Visual Studio or the .NET CLI):
   ```bash
   dotnet build
   ```
2. Run the program:
   ```bash
   dotnet run
   ```

## Contributing

Contributions are welcome! Fork this repository and submit a pull request.
