# Array Manipulation in C#

## Project Overview
This project demonstrates a simple console application in C# to perform basic array manipulations. The program will take 10 integers from the user, display the entered numbers, allow the user to add an 11th number to the array, and finally display the array sorted from largest to smallest.

## Features
- Accepts 10 integers from the user.
- Displays the numbers using a `foreach` loop.
- Allows the addition of an 11th integer.
- Sorts the entire array in descending order.

## Installation
1. Clone the repository or download the project files.
2. Ensure that you have the .NET SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).
3. Open the project folder in your IDE of choice (e.g., Visual Studio, Visual Studio Code).

## How to Run
1. Navigate to the project directory.
2. Run the following command to execute the program:
   ```bash
   dotnet run
   ```

3. Follow the instructions displayed in the console to input the 10 integers, add the 11th integer, and view the sorted list.

## Code Structure
- The program starts by defining an array to hold 10 integers.
- A `for` loop is used to populate the array with user inputs.
- The array is displayed using a `foreach` loop.
- The user is prompted to add an 11th integer, which is appended to the array.
- The array is then sorted in descending order and displayed again.

## Example Output
```
1. say�y� giriniz: 21
2. say�y� giriniz: 34
3. say�y� giriniz: 2
4. say�y� giriniz: 1
5. say�y� giriniz: -5
6. say�y� giriniz: -8
7. say�y� giriniz: -1
8. say�y� giriniz: 100
9. say�y� giriniz: 245
10. say�y� giriniz: 192

Girmi� oldu�unuz liste: 21 34 2 1 -5 -8 -1 100 245 192
Diziye eklemek istedi�iniz 11. De�eri giriniz: -100

B�y�kten k����e s�ralanm�� liste: 245 192 100 34 21 2 1 -1 -5 -8 -100
```

## Contribution
Feel free to fork this repository, make changes, and submit a pull request. All contributions are welcome!
