-- Q1
SELECT country.country, city.city FROM city
LEFT JOIN country ON country.country_id = city.country_id
ORDER BY country ASC;

-- Q2
SELECT payment.payment_id, customer.first_name, customer.last_name FROM customer
RIGHT JOIN payment ON customer.customer_id = payment.customer_id;

-- Q3
SELECT rental.rental_id, customer.first_name, customer.last_name FROM customer
FULL JOIN rental ON rental.customer_id = customer.customer_id;