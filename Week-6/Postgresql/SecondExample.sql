SELECT * FROM film WHERE replacement_cost BETWEEN 12.99 AND 16.99;
-- get all movies from film table where replacement_cost is between 12.99 and 16.99
SELECT first_name, last_name
FROM actor
WHERE
    first_name IN ('Penelope', 'Nick', 'Ed');
-- get first name and last name of actors whose first name is Penelope, Nick or Ed

SELECT *
FROM film
WHERE
    rental_rate IN (0.99, 2.99, 4.99)
    AND replacement_cost IN (12.99, 15.99, 28.99);
-- get all movies from film table where rental_rate is 0.99, 2.99 or 4.99 and replacement_cost is 12.99, 15.99 or 28.99