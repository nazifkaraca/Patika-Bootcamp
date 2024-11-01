-- Q1
SELECT COUNT(*) AS greater_movies FROM film
WHERE length > (SELECT AVG(length) FROM film);

--Q2
SELECT COUNT(*) FROM film
WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);

--Q3
WITH min_values AS (
    SELECT 
        MIN(rental_rate) AS min_rental_rate,
        MIN(replacement_cost) AS min_replacement_cost
    FROM film
)
SELECT *
FROM film
JOIN min_values 
ON film.rental_rate = min_values.min_rental_rate
   AND film.replacement_cost = min_values.min_replacement_cost;

--Q4
SELECT customer_id, COUNT(*) AS total_payments
FROM payment
GROUP BY customer_id
ORDER BY total_payments DESC;



