/* 
city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
*/

SELECT city, country
FROM city
    INNER JOIN country ON city.country_id = country.country_id;
-- get the city and country names from city and country tables

SELECT
    payment_id,
    first_name,
    last_name
FROM customer
    INNER JOIN payment ON customer.customer_id = payment.customer_id;