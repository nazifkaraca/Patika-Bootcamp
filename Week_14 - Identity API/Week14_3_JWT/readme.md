# Pratik - JWT 🔐

A step-by-step guide to building a JWT (JSON Web Token) authentication system. Follow the instructions below to implement a secure authentication mechanism in your application.

---

## 🚀 Project Overview

This project demonstrates how to create a JWT-based authentication system using **C#** and **Entity Framework**. It includes features like user model creation, database configuration, JWT generation, and JWT validation.

---

## 📋 Table of Contents

- [Features](#-features)
- [Installation](#-installation)
- [Usage](#-usage)
- [How It Works](#-how-it-works)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🌟 Features

- **User Model Creation:** A simple `User` class with essential properties.
- **Database Integration:** Set up with Entity Framework and DbContext.
- **JWT Generation:** Create tokens for authenticated users.
- **JWT Validation:** Secure APIs with token-based authorization.

---

## 🧑‍💻 Usage

### User Model Creation

Define a `User` class with the following properties:

```csharp
public class User {
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
```

### Database Setup

Create a `DbContext` and register the `User` model:

```csharp
public class AppDbContext : DbContext {
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
```

### JWT Generation

In the `AuthController`, add a `Login` method:

```csharp
[HttpPost("login")]
public IActionResult Login([FromBody] LoginRequest request) {
    // Validate user credentials
    // Generate and return JWT
}
```

### JWT Validation

Configure JWT validation in `Startup.cs`:

```csharp
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSecretKey"))
        };
    });
```

---

## 🛡️ How It Works

1. **Login:** The user sends their email and password to the `Login` endpoint.
2. **JWT Generation:** A valid user receives a JWT containing claims like their user ID.
3. **Secure Endpoints:** Apply the `[Authorize]` attribute to protect routes.
4. **Token Validation:** Every request includes the JWT in the header, which is validated server-side.
