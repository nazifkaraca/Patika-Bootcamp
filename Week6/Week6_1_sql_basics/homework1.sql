--SELECT title, description FROM film;

--SELECT * from film
--WHERE length > 60 AND length < 75;

--SELECT * FROM film
--WHERE rental_rate = 0.99 AND replacement_cost = 12.99 OR rental_rate = 0.99 AND replacement_cost = 28.99;

SELECT * from film
WHERE NOT (length > 50 OR rental_rate = 2.99 OR rental_rate = 4.99);

