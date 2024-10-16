# Inheritance Example - BasePerson

This project demonstrates the concept of inheritance by creating a `BasePerson` class, from which `Teacher` and `Student` classes inherit. Each derived class extends the base class with its own specific properties and overrides the inherited methods.

## Class Overview

### 1. `BasePerson` (Abstract Base Class)
- **Properties**:
  - `Name` (string): The first name of the person.
  - `Surname` (string): The last name of the person.
  
- **Method**:
  - `Introduce()`: A virtual method that prints the `Name` and `Surname` to the console. This method is intended to be overridden by derived classes.

### 2. `Teacher` (Sealed Class)
- **Inherited Properties**: Inherits `Name` and `Surname` from `BasePerson`.
  
- **Additional Property**:
  - `Salary` (int): The salary of the teacher.

- **Method**:
  - `Introduce()`: Overrides the `BasePerson` method. It first calls `base.Introduce()` to print the `Name` and `Surname`, and then prints the `Salary`.

### 3. `Student` (Sealed Class)
- **Inherited Properties**: Inherits `Name` and `Surname` from `BasePerson`.
  
- **Additional Property**:
  - `StudentNumber` (int): The student number.

- **Method**:
  - `Introduce()`: Overrides the `BasePerson` method. It first calls `base.Introduce()` to print the `Name` and `Surname`, and then prints the `StudentNumber`.

## Example Usage

Here’s an example demonstrating the usage of the `Teacher` and `Student` classes:

```csharp
using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Teacher and assign values
            Teacher teacher = new Teacher
            {
                Name = "Ali",
                Surname = "Yılmaz",
                Salary = 5000
            };
            teacher.Introduce();

            Console.WriteLine();

            // Create an instance of Student and assign values
            Student student = new Student
            {
                Name = "Ayşe",
                Surname = "Kaya",
                StudentNumber = 12345
            };
            student.Introduce();
        }
    }
}
```

### Output:

```
Merhaba Ali Yılmaz!
Your salary is 5000.

Merhaba Ayşe Kaya!
Your student number is 12345.
```

## Project Structure

- **BasePerson**: The abstract base class containing common properties and methods.
- **Teacher**: A sealed class that inherits from `BasePerson` and introduces a `Salary` property.
- **Student**: A sealed class that inherits from `BasePerson` and introduces a `StudentNumber` property.

## Requirements

- .NET SDK (to compile and run the C# code)
