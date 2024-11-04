# Turkish Music Artists Data Analysis

This project involves analyzing data on popular Turkish music artists. Each artist is represented as an object with attributes such as name, music genre, debut year, and album sales. Using this data, we perform various queries to extract meaningful insights, such as identifying artists with names starting with specific letters, artists with high album sales, or grouping artists by specific criteria.

![WhatsApp Görsel 2024-11-04 saat 18 46 39_77fa8e8b](https://github.com/user-attachments/assets/3089628d-15a8-45ce-8f29-dcbffd997ff9)

## Project Overview

The primary aim of this project is to practice data manipulation and querying on structured data in a C# environment. By representing each artist as an object, we can leverage C# collections and LINQ to perform various operations. This approach is well-suited for learning object-oriented programming and querying techniques in C#.

## Data Structure

The data is represented as a list of objects, with each object containing the following properties for an artist:

- **Name**: Full name of the artist.
- **Music Genre**: The genre(s) of music the artist performs.
- **Debut Year**: The year when the artist released their debut album.
- **Album Sales**: Approximate total album sales for the artist.

The table below provides an overview of the data:

| Artist Name         | Music Genre                | Debut Year | Album Sales         |
|---------------------|----------------------------|------------|----------------------|
| Ajda Pekkan         | Pop                        | 1968       | ~20 million         |
| Sezen Aksu          | Turkish Folk / Pop         | 1971       | ~10 million         |
| Funda Arar          | Pop                        | 1999       | ~3 million          |
| Sertab Erener       | Pop                        | 1994       | ~5 million          |
| Sıla                | Pop                        | 2009       | ~3 million          |
| Serdar Ortaç        | Pop                        | 1994       | ~10 million         |
| Tarkan              | Pop                        | 1992       | ~40 million         |
| Hande Yener         | Pop                        | 2000       | ~7 million          |
| Hadise              | Pop                        | 2005       | ~5 million          |
| Gülben Ergen        | Pop / Turkish Folk         | 1997       | ~10 million         |
| Neşet Ertaş         | Turkish Folk / Classical   | 1960       | ~2 million          |

## Queries

Using this dataset, the following queries are implemented:

1. **Artists with Names Starting with 'S'**: Lists all artists whose names start with the letter 'S'.
   
2. **Artists with Album Sales Over 10 Million**: Identifies all artists who have sold over 10 million albums.
   
3. **Artists Debuting Before 2000 in Pop Music**: Lists artists who debuted before 2000 and perform pop music, grouped by debut year and sorted alphabetically within each group.
   
4. **Top-Selling Artist**: Determines the artist with the highest album sales.
   
5. **Newest and Oldest Artists**: Finds the artist with the latest debut and the artist with the earliest debut.

## Usage

This project can be used as a reference for practicing data organization and LINQ queries in C#. It's ideal for understanding how to:

- Structure data in objects.
- Use LINQ for data querying.
- Apply filtering, sorting, and grouping operations on collections.

