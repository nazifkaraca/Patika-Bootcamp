# Crazy Musicians API

Welcome to the **Crazy Musicians API**, a fun and quirky project built using **ASP.NET Core Web API**. This API is designed to manage a hilarious dataset of fictional musicians, providing CRUD (Create, Read, Update, Delete) operations and demonstrating routing, validation, and query functionalities.

---

## 🚀 Project Overview

This project is centered around a unique and entertaining dataset of 10 "Crazy Musicians," each with distinctive traits and quirky behaviors. Using this API, you can:

- Retrieve the list of musicians.
- Add new musicians.
- Update existing musician records.
- Delete musicians from the dataset.

---

## ✨ Features

1. **CRUD Operations**  
   Full support for Create, Read, Update, and Delete operations:
   - `GET`: Fetch musician data.
   - `POST`: Add new musicians.
   - `PUT`: Update musician records.
   - `PATCH`: Modify specific attributes of a musician.
   - `DELETE`: Remove a musician from the list.

2. **Routing**  
   Routes are implemented with flexibility and diversity, incorporating examples inspired by advanced routing concepts. The routing structure ensures clarity and usability.

3. **Validation**  
   Proper validation is applied to all input data to ensure the integrity of the dataset. Invalid data submissions are gracefully handled with descriptive error messages.

4. **Query Support**  
   The API includes at least one `[FromQuery]` example, allowing clients to filter or search for musicians dynamically.

5. **English Project Structure**  
   All code and documentation are written in English for better accessibility and understanding.

---

## 🎯 Objectives

This project was designed to:
- Practice API development with **ASP.NET Core Web API**.
- Demonstrate advanced routing techniques, similar to those used in "Galactic Tour."
- Implement input validation to ensure data integrity.
- Showcase the use of `[FromQuery]` for flexible querying.

---

## 📝 Dataset

Here is the entertaining dataset of musicians managed by this API:

| ID  | Name           | Profession           | Quirky Trait                                                          |
|-----|----------------|----------------------|------------------------------------------------------------------------|
| 1   | Ahmet Çalgı    | Famous Classical Player | Always plays wrong notes but is highly entertaining.                  |
| 2   | Zeynep Melodi  | Popular Melody Writer  | Her songs are hard to understand but very popular.                    |
| 3   | Cemil Akor     | Crazy Chordist        | Frequently changes chords, but is surprisingly talented.              |
| 4   | Fatma Nota     | Surprise Note Producer | Constantly prepares musical surprises.                                |
| 5   | Hasan Ritmi    | Rhythm Maverick       | Creates rhythms in his own style, often comically mismatched.         |
| 6   | Elif Armoni    | Harmony Expert        | Sometimes plays wrong harmonies, but is highly creative.              |
| 7   | Ali Perde      | Curtain Manipulator   | Uses curtains in unique ways, always surprising the audience.         |
| 8   | Ayşe Rezonans  | Resonance Specialist  | An expert in resonance, often producing incredible sounds.            |
| 9   | Murat Ton      | Tone Enthusiast       | Finds humor in tonal variations, making it an intriguing experience.  |
| 10  | Selin Akor     | Chord Wizard          | Creates magical atmospheres when changing chords.                     |

---

## 🛠️ Requirements

- **ASP.NET Core**: The project must use ASP.NET Core Web API.
- **Routing Techniques**: Incorporate dynamic routing as practiced in the "Galactic Tour" example.
- **Validation**: Ensure all API endpoints include proper validation for incoming data.
- **Query Parameters**: Use `[FromQuery]` for at least one API endpoint to demonstrate dynamic searching.

---

## 📂 Folder Structure

- **Controllers**: Handles the API logic and routing.
- **Models**: Defines the data structure for musicians.

---

## 🚦 Usage Instructions

1. **Clone the Repository**  
   Clone the project to your local machine.

2. **Build the Project**  
   Run the application using the .NET CLI or Visual Studio.

3. **API Endpoints**  
   Use tools like Postman or Swagger to interact with the API.

4. **Explore Features**  
   Experiment with the CRUD operations, routing techniques, and query functionalities.
