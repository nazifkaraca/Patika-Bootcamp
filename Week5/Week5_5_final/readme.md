# Car Factory Application

This project simulates a car production process in a factory using a console application. The user can create cars by inputting specific car attributes, and the application will list all produced cars with their serial numbers and brands.

## Features

- The user is prompted whether they want to produce a car by entering "y" (yes) or "n" (no). 
- Each car's production date is automatically assigned when it is created.
- The user can input details such as the serial number, brand, model, color, and number of doors.
- If the number of doors is not a valid integer, the program will prompt the user to re-enter it without throwing an exception.
- All produced cars are stored in a list.
- The user can decide to produce additional cars, and when they choose not to, the serial numbers and brands of all cars are displayed.

## Installation

To run this project on your local machine, follow these steps:

### Prerequisites

- .NET SDK (minimum .NET Core 3.1 or later)
- Basic knowledge of C#

### Steps

1. Clone the repository or download the code files.
2. Navigate to the project directory:
   ```bash
   cd car-factory
   ```
3. Compile and run the project:
   ```bash
   dotnet run
   ```

## Usage

1. After starting the application, you will be asked if you want to produce a car.
2. Enter "Y" or "y" to start creating a car.
3. Provide the required car attributes, and the car will be added to the list.
4. The program will ask if you want to produce another car.
5. Enter "N" or "n" to stop the process and list the serial numbers and brands of all the cars produced.