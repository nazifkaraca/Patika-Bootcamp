-- Q1
SELECT city, country FROM country
INNER JOIN city ON country.country_id = city.country_id;

-- Q2
SELECT payment_id, first_name, last_name FROM customer
INNER JOIN payment ON customer.customer_id = payment.customer_id;

-- Q3
SELECT rental_id, first_name, last_name FROM rental
INNER JOIN customer ON rental.customer_id = customer.customer_id;