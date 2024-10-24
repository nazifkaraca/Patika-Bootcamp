# IMDb Movie List CLI Application

This project is a command-line interface (CLI) application written in **C#** that allows users to create and manage a list of movies along with their IMDb ratings. The application collects movie names and IMDb ratings from the user, adds them to a list, and provides options to filter and display the movies based on certain conditions.

## Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Example Output](#example-output)
- [Contribution Guidelines](#contribution-guidelines)
- [License](#license)

## Project Overview

This C# application allows users to:
1. Input multiple movie titles and their respective IMDb ratings.
2. Choose to add more movies or stop at any time.
3. View all the movies in the list.
4. Filter movies with IMDb ratings between 4.0 and 9.0.
5. List movies starting with the letter 'A' and display their IMDb scores.

## Features

- **Unlimited movie entries**: Users can input as many movies as they wish.
- **Dynamic filtering**: The application offers multiple filters such as IMDb rating range and title prefix.
- **User interaction**: After each movie entry, the user is prompted to continue or stop.

## Prerequisites

To run this application, ensure you have the following:
- **.NET SDK**: Installed on your machine. [Download here](https://dotnet.microsoft.com/download).
- A code editor, such as Visual Studio or Visual Studio Code, for running and editing C# applications.

## Installation

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/your-username/imdb-movie-list-cli-csharp.git
   ```

2. Navigate to the project directory:
   ```bash
   cd imdb-movie-list-cli-csharp
   ```

3. Open the project in Visual Studio or your preferred C# IDE.

4. Restore any necessary packages:
   ```bash
   dotnet restore
   ```

## Usage

To use the application, follow these steps:

1. **Run the Application**:  
   In your terminal or IDE, run the project:
   ```bash
   dotnet run
   ```

2. **Input Movie Information**:  
   The program will prompt you to enter a movie name and its IMDb rating. For example:
   ```plaintext
   Enter the name of the movie: The Shawshank Redemption
   Enter the IMDb rating of the movie (e.g., 9.3): 9.3
   ```

3. **Continue or Stop**:  
   After adding a movie, you'll be asked whether you want to add another movie:
   ```plaintext
   Do you want to add another movie? (yes/no): yes
   ```

4. **View Results**:  
   Once you finish adding movies by typing `no`, the program will display:
   - A complete list of all movies entered.
   - Movies with IMDb ratings between 4.0 and 9.0.
   - Movies whose titles start with the letter 'A' along with their IMDb scores.

## Example Output

```plaintext
All Movies:
1. The Shawshank Redemption - 9.3
2. The Godfather - 9.2
3. Forrest Gump - 8.8

Movies with IMDb ratings between 4.0 and 9.0:
1. Forrest Gump - 8.8

Movies starting with 'A' and their IMDb ratings:
(No movies found starting with 'A')
```

## Contribution Guidelines

If you'd like to contribute to this project, follow these steps:

1. **Fork the repository**.
2. **Create a new branch** for your feature or bugfix:
   ```bash
   git checkout -b feature/additional-filters
   ```
3. **Make your changes** and commit them:
   ```bash
   git commit -m "Added feature to list movies starting with 'B'"
   ```
4. **Push your changes** to your forked repository:
   ```bash
   git push origin feature/additional-filters
   ```
5. Submit a pull request, and we will review your changes.
