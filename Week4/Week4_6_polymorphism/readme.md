# Polymorphism in Geometric Shapes

This project demonstrates the use of **polymorphism** in Python through geometric shapes (`Square`, `Rectangle`, `RightTriangle`). We calculate the area of these shapes, utilizing inheritance and method overriding to handle different area calculations.

## Table of Contents
- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Classes](#classes)
- [Contributing](#contributing)
- [License](#license)

## Overview

In this project, we create a basic structure for geometric shapes using OOP principles, specifically focusing on **polymorphism**. The shapes include:

- **Square**: Area is calculated as `Width * Height` (where width and height are the same).
- **Rectangle**: Area is calculated as `Width * Height`.
- **Right Triangle**: Area is calculated as `(Width * Height) / 2`.

A base class `BaseGeometricShape` provides common properties and methods. Each shape class overrides the `calculate_area()` method to compute the area based on the specific shape's formula.

### Key Concepts
- **Polymorphism**: The ability to treat different types of objects through a common interface (in this case, the `calculate_area()` method).
- **Inheritance**: All shapes inherit common properties from a base class (`BaseGeometricShape`).
  
## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/geometric-polymorphism.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd geometric-polymorphism
   ```

3. **Run the application**:
   This project is written in Python, so make sure you have Python installed on your machine. Then, simply run:
   ```bash
   python main.py
   ```

## Usage

The program creates instances of the `Square`, `Rectangle`, and `RightTriangle` classes and calculates their areas.

### Example

```python
square = Square(width=5)
rectangle = Rectangle(width=4, height=6)
triangle = RightTriangle(width=3, height=4)

print(f"Square Area: {square.calculate_area()}")
print(f"Rectangle Area: {rectangle.calculate_area()}")
print(f"Triangle Area: {triangle.calculate_area()}")
```

### Expected Output

```
Square Area: 25
Rectangle Area: 24
Triangle Area: 6.0
```

## Classes

### BaseGeometricShape

The base class for all geometric shapes. It contains two properties: `width` and `height`, and a method `calculate_area()` that is overridden by child classes.

### Square

Inherits from `BaseGeometricShape`. Since a square has equal width and height, the area is calculated as `width * width`.

### Rectangle

Inherits from `BaseGeometricShape`. The area is calculated as `width * height`.

### RightTriangle

Inherits from `BaseGeometricShape`. The area is calculated as `(width * height) / 2`.

## Contributing

We welcome contributions to improve the project! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature-branch`).
3. Make your changes and commit (`git commit -m 'Add feature'`).
4. Push your changes to GitHub (`git push origin feature-branch`).
5. Create a pull request and describe your changes.