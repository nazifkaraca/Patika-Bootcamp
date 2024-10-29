-- Q1
--SELECT DISTINCT replacement_cost FROM film;

-- Q2
--SELECT COUNT (DISTINCT replacement_cost) FROM film; --> 21

-- Q3
--SELECT COUNT(*) FROM film
--WHERE title LIKE 'T%' AND rating = 'G'; --> 9

-- Q4
--SELECT COUNT(*) FROM country
--WHERE char_length(country) = 5; --> 13

-- Q5
--SELECT COUNT(*) FROM city
--WHERE city ILIKE '%R'; --> 33