/* 
city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
*/

SELECT city.city, country.country
FROM city
    LEFT JOIN country ON city.country_id = country.country_id;
-- get the city and country names from city and country tables where city.country_id = country.country_id

SELECT payment.payment_id, customer.first_name, customer.last_name
FROM customer
    RIGHT JOIN payment ON customer.customer_id = payment.customer_id;
-- get the payment_id, first_name and last_name from payment and customer tables where customer.customer_id = payment.customer_id

SELECT rental.rental_id, customer.first_name, customer.last_name
FROM customer
    FULL JOIN rental ON customer.customer_id = rental.customer_id;
-- get the rental_id, first_name and last_name from rental and customer tables where customer.customer_id = rental.customer_id