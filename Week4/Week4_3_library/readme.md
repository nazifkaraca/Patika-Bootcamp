# Patika Library Book Registration

This is a simple C# application for a book registration system. The application allows you to create and store book objects with properties such as title, author name, author surname, page count, publishing house, and registration date. The application demonstrates the use of **classes**, **properties**, **constructors**, and **object creation** in C#.

## Features

- Book objects can be created with the following details:
  - **Book Title**: Name of the book.
  - **Author Name**: First name of the author.
  - **Author Surname**: Last name of the author.
  - **Page Count**: Number of pages in the book.
  - **Publishing House**: Name of the publishing house.
  - **Registration Date**: Automatically set to the current date when the book is created.

- Two constructor options:
  1. **Default Constructor**: Initializes the object with default or empty values.
  2. **Parameterized Constructor**: Allows setting the book's title, author name, page count, and publishing house during object creation.

- Registration date is automatically set to the current time when the object is created (for both constructors).

## Example Book

This application allows you to create books like the following:

```csharp
// Example Book
Library book = new Library("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
```

This creates an instance of the `Library` class representing the book *Adı Aylin* by *Ayşe Kulin*, published by *Remzi Kitabevi*, with 398 pages.

## Class, Property, New, Constructor Concepts

- **Class**: A blueprint for creating objects. In this project, the `Library` class represents a book with details like `Title`, `AuthorName`, `AuthorSurname`, `PageCount`, `PublishHouse`, and `RegistrationDate`.

```csharp
public class Library
{
    // Fields and properties for the class
}
```

- **Property**: A class member that provides a flexible mechanism to read, write, or compute the values of private fields. Properties often include logic to validate data before changing the underlying fields.

```csharp
public string BookTitle { get; set; }
```

- **New**: A keyword used to create an instance (object) of a class. When we use `new Library()`, a new object of the `Library` class is created.

```csharp
Library newBook = new Library();
```

- **Constructor**: A special method that is called when an object of a class is created. Constructors can be parameterized to allow initializing properties at the time of object creation.

```csharp
public Library(string title, string authorName, string authorSurname, int pageCount, string publishHouse)
{
    // Constructor logic here
}
```

## Usage

To create a book with the default constructor:

```csharp
Library defaultBook = new Library();
```

To create a book with specific details:

```csharp
Library specificBook = new Library("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
```

In both cases, the **Registration Date** is automatically set to the current time.

## Example Output

Here’s an example of what the output may look like:

```
Kitap Adı: Adı Aylin
Yazar Adı: Ayşe
Yazar Soyadı: Kulin
Sayfa Sayısı: 398
Yayınevi: Remzi Kitabevi
Kayıt Tarihi: 2024-10-16
```

## Requirements

- C# 7.0 or higher
- .NET Core SDK

## Running the Program

1. Clone the repository.
2. Open the project in Visual Studio or your preferred C# IDE.
3. Build the solution and run the project.
```

This README provides an adequate overview of the project and includes explanations of the key OOP concepts in C#. You can adjust the example code and output sections based on your actual implementation.
