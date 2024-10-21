# Week 4 - Inheritance, Encapsulation, Polymorphism, and Abstraction Project

## Project Overview

This project simulates the registration and creation of two types of products for a technology store: **Phones** and **Computers**. The application demonstrates the use of Object-Oriented Programming (OOP) concepts such as **inheritance**, **encapsulation**, **polymorphism**, and **abstraction**.

### Key Features:
1. **Phone** and **Computer** inherit from a shared base class called `BaseMakine`.
2. Each product is created by prompting the user for details through a console interface.
3. The program incorporates validation, such as enforcing specific values for the number of USB ports on a computer.
4. The application utilizes both shared and unique attributes of each class, with abstract methods overridden in each derived class for specific product output.

## OOP Principles in Action

1. **Inheritance**:
   - The `BaseMakine` class serves as a parent class, from which both the `Telefon` and `Bilgisayar` classes inherit. It contains common properties such as the serial number, product name, description, operating system, and production date.
   - Derived classes `Telefon` and `Bilgisayar` inherit these common properties and add their unique features.

2. **Encapsulation**:
   - For `Bilgisayar`, the number of USB ports is restricted to values of either 2 or 4. If the user enters an invalid number, a warning is displayed, and the value is set to `-1`. This ensures data integrity and prevents incorrect input.

3. **Polymorphism**:
   - The `BilgileriYazdir()` method, defined in the `BaseMakine` class, is overridden in the `Telefon` and `Bilgisayar` classes. Each derived class calls the base implementation and adds its specific properties (e.g., `TRLisansDurumu` for phones, and `UsbGirisSayisi` for computers).
   
4. **Abstraction**:
   - An abstract method `UrunAdiGetir()` is declared in the base class. This method is implemented in both the `Telefon` and `Bilgisayar` classes to display messages such as:
     - **"Telefonunuzun adı ---> [Product Name]"**
     - **"Bilgisayarınızın adı ---> [Product Name]"**

## Project Flow

1. The user is asked to choose between creating a **Phone** or a **Computer** by selecting `1` for Phone or `2` for Computer.
   
2. Based on the user's selection:
   - For a **Phone**, the following information is requested: serial number, name, description, operating system, and whether it is licensed in Turkey.
   - For a **Computer**, the user is prompted for the serial number, name, description, operating system, USB port count (which must be 2 or 4), and Bluetooth capability.

3. After all the details are entered, the product information is displayed on the screen using the `BilgileriYazdir()` method.

4. The user is then asked if they would like to create another product. If they respond with 'y', the process starts over; if 'n', the application ends with a goodbye message.

## Example Output

### Case 1: Creating a Phone
```
(1) Telefon Üret
(2) Bilgisayar Üret
Seçim yapınız: 1

Seri Numarası: 12345678
Ürünün İsmi: iPhone
Açıklama: 16
İşletim Sistemi: iOS
Bluetooth (true/false): true
TRLisans Durumu: true

Ürününüz başarıyla üretildi!
Ürün oluşturulmaya devam etmek ister misiniz? (y/n):
```

### Case 2: Creating a Computer with Invalid USB Ports
```
(1) Telefon Üret
(2) Bilgisayar Üret
Seçim yapınız: 2

Seri Numarası: 12345678
Ürünün İsmi: Monster
Açıklama: ABRA
İşletim Sistemi: Linux
USB Giriş Sayısı: 3
Bluetooth (true/false): true

USB giriş sayısı 2 veya 4 değerlerini alabilir!
USB Giriş Sayısı: -1

Ürününüz başarıyla üretildi!
Ürün oluşturulmaya devam etmek ister misiniz? (y/n):
```

## Installation

1. Clone or download the project to your local machine.
2. Open the project in your preferred IDE (e.g., Visual Studio).
3. Build and run the solution.
4. Follow the console prompts to create products.

## Usage

- Run the application.
- Follow the console instructions to input product details.
- View the product information on the console after each entry.
- Optionally, create multiple products during a single session.

## Contribution Guidelines

If you'd like to contribute to this project:
1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature/new-feature`).
3. Commit your changes (`git commit -m 'Add some new feature'`).
4. Push to the branch (`git push origin feature/new-feature`).
5. Create a new pull request.