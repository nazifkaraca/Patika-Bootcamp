--Q1
(SELECT first_name FROM customer)
UNION
(SELECT first_name FROM actor)
ORDER BY first_name ASC;

--Q2
(SELECT first_name FROM customer)
INTERSECT
(SELECT first_name FROM actor)
ORDER BY first_name ASC;

--Q3
(SELECT first_name FROM actor)
EXCEPT
(SELECT first_name FROM customer)
ORDER BY first_name ASC;

--Q4
(SELECT first_name FROM customer)
INTERSECT
(SELECT first_name FROM actor)
ORDER BY first_name ASC;