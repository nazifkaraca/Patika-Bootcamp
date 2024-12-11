# Survivor Competition Web API 🎯

Welcome to the **Survivor Competition Web API**! This project provides an API to manage competitors and categories in a Survivor-style competition. It supports full CRUD (Create, Read, Update, Delete) operations for both competitors and categories. 🚀

---

## 📚 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
  - [Competitor Endpoints](#competitor-endpoints)
  - [Category Endpoints](#category-endpoints)
- [Testing](#testing)
- [Contribution](#contribution)
- [License](#license)

---

## 📝 Overview

The Survivor Competition Web API enables management of:
1. **Competitors** (e.g., individual contestants in the competition) 🎽
2. **Categories** (groups to which competitors belong) 📂

A **one-to-many relationship** exists between Categories and Competitors:
- A Category can have multiple Competitors.
- Each Competitor belongs to one Category.

---

## ✨ Features

- 🏗️ **Entity Design:** Built using a `BaseEntity` class for consistency.
- 🔄 **Full CRUD Operations:** Easily create, read, update, and delete records.
- 📜 **RESTful Endpoints:** Intuitive endpoints for seamless integration.
- ✅ **Validation and Testing:** Tested using Postman and Swagger.

---

## 🛠️ Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/nazifkaraca/Patika-Bootcamp/new/master/Week_12%20-%20Entity%20Framework/Week12_7_Survivor.git
   cd survivor-api
   ```

2. Install dependencies:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

---

## 🚀 Usage

After starting the application, the API will be available at:
```
http://localhost:5000
```

Use tools like **Postman**, **Swagger**, or any HTTP client to interact with the API.

---

## 📖 API Endpoints

### 🏅 Competitor Endpoints

| Method | Endpoint                                  | Description                                    |
|--------|------------------------------------------|------------------------------------------------|
| GET    | `/api/competitors`                       | Retrieve all competitors.                     |
| GET    | `/api/competitors/{id}`                  | Retrieve a specific competitor by ID.         |
| GET    | `/api/competitors/categories/{CategoryId}` | Retrieve competitors by category ID.          |
| POST   | `/api/competitors`                       | Create a new competitor.                      |
| PUT    | `/api/competitors/{id}`                  | Update a specific competitor.                 |
| DELETE | `/api/competitors/{id}`                  | Delete a specific competitor.                 |

---

### 📂 Category Endpoints

| Method | Endpoint              | Description                        |
|--------|------------------------|------------------------------------|
| GET    | `/api/categories`     | Retrieve all categories.           |
| GET    | `/api/categories/{id}` | Retrieve a specific category by ID.|
| POST   | `/api/categories`     | Create a new category.             |
| PUT    | `/api/categories/{id}` | Update a specific category.        |
| DELETE | `/api/categories/{id}` | Delete a specific category.        |

---

## 🧪 Testing

You can test the API using:
1. **Postman**: Import the endpoints and verify the responses.  
2. **Swagger**: Visit `/swagger` after running the app to view and test the API documentation.
