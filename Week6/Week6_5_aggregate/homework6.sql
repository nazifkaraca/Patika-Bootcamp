-- COUNT, MIN, MAX, AVG, SUM
-- Q1
SELECT ROUND(AVG(rental_rate), 3) FROM film;

-- Q2
SELECT COUNT(*) FROM film
WHERE title LIKE 'C%';

-- Q3
SELECT MAX(length) FROM film
WHERE rental_rate = 0.99;

-- Q4
SELECT COUNT(DISTINCT replacement_cost) FROM film
WHERE length > 150;