/* 
film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.
payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
*/

SELECT COUNT(*)
FROM film
WHERE
    length > (
        SELECT AVG(length)
        FROM film
    );
-- get the count of films that have length greater than the average length of all films

SELECT COUNT(*)
FROM film
WHERE
    rental_rate = (
        SELECT MAX(rental_rate)
        FROM film
    );
-- get the count of films that have the highest rental rate

SELECT *
FROM film
WHERE
    rental_rate = (
        SELECT MIN(rental_rate)
        FROM film
    )
    AND replacement_cost = (
        SELECT MIN(replacement_cost)
        FROM film
    );
-- get the films that have the lowest rental rate and replacement cost

SELECT customer_id, COUNT(*)
FROM payment
GROUP BY
    customer_id
ORDER BY COUNT(*) DESC;
-- get the customers who made the most payments