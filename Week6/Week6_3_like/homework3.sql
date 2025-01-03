-- Q1
SELECT * FROM country
WHERE country LIKE 'A%a'

-- Q2
SELECT * FROM country
WHERE length(country) >= 6 AND country LIKE '%n';

-- Q3
SELECT * FROM film
WHERE title ILIKE '%t%t%t%t%' -- title ~'(.*t.*){4}';

-- Q4
SELECT * FROM film
WHERE title LIKE 'C%' AND char_length(length) > 90 AND rental_rate = 2.99;

