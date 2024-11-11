# Pratik - Basic MVC

## Project Overview

This project is a basic ASP.NET MVC application designed to display customer and order information. Following the MVC pattern, we develop a straightforward application that shows how to create models, view models, controllers, and views for displaying customer details and their associated orders.

![image](https://github.com/user-attachments/assets/8736a130-fd8f-49ea-981c-07bdcc952e8d)

### Objective

The objective is to create a web application where customer and order information can be viewed on a single page. This project provides hands-on experience with ASP.NET MVC, building from model creation to the final view, where data is displayed.

---

## Project Steps

### Step 1: Model Creation

#### Customer Model

The `Customer` model represents customer details and includes the following fields:
- **Id**: A unique identifier for the customer (type: `int`).
- **FirstName**: The customer's first name (type: `string`).
- **LastName**: The customer's last name (type: `string`).
- **Email**: The customer's email address (type: `string`).

#### Order Model

The `Order` model represents an individual order made by the customer, with the following fields:
- **Id**: A unique identifier for the order (type: `int`).
- **ProductName**: The name of the product ordered (type: `string`).
- **Price**: The price of the product (type: `decimal`).
- **Quantity**: The quantity of the product ordered (type: `int`).

### Step 2: ViewModel Creation

A `CustomerOrderViewModel` class is created to aggregate customer and order data, providing a structure that can be easily rendered in the view. This class includes:
- **Customer**: A `Customer` object containing customer details.
- **Orders**: A list of `Order` objects representing orders made by the customer.

The ViewModel allows both customer and order information to be managed and displayed together within the same view.

### Step 3: Controller Creation

A `CustomerOrdersController` class is created to handle customer and order data retrieval and pass this data to the view.

- **Index Action**: Within this controller, an `Index` action method is defined to:
  - Create a sample `Customer` object.
  - Create a few sample `Order` objects associated with that customer.
  - Instantiate a `CustomerOrderViewModel` object using the created `Customer` and `Order` objects.
  - Pass the `CustomerOrderViewModel` object to the view, where the data will be rendered.

### Step 4: View Creation

An `Index` view is created under the `Views/CustomerOrders` directory. This view uses the `CustomerOrderViewModel` to display customer information and their orders.

In the `Index` view:
- **Customer Information**: Displays details such as customer ID, first name, last name, and email.
- **Orders Table**: A table is created to list each order, displaying the order ID, product name, price, and quantity.

This layout allows users to view a customer's basic information and all their related orders on a single page.

---

## Usage

After completing the steps, launch the application, and navigate to the `CustomerOrders` section to view customer and order information. The data displayed will be based on the sample data provided in the `Index` action of the `CustomerOrdersController`.
