/*     film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.
film tablosunda bulunan tüm sütunlardaki verileri film uzunluğu (length) 60 dan büyük VE 75 ten küçük olma koşullarıyla sıralayınız.
film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayınız.
customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?
film tablosundaki uzunluğu(length) 50 ten büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız. */

SELECT title, description FROM film;
--get all movies title and description from film table

SELECT * FROM film WHERE length > 60 AND length < 75;
--get all movies from film table where length is greater than 60 and less than 75

SELECT *
FROM film
WHERE
    rental_rate = 0.99
    AND (
        replacement_cost = 12.99
        OR replacement_cost = 28.99
    );

--get all movies from film table where rental_rate is 0.99 and replacement_cost is 12.99 or 28.99

SELECT last_name FROM customer WHERE first_name = 'Mary';
--get last name of customer whose first name is Mary

SELECT *
FROM film
WHERE
    length < 50
    AND NOT (
        rental_rate = 2.99
        OR rental_rate = 4.99
    );
-- get all movies from film table where length is less than 50 and rental_rate is not 2.99 or 4.99