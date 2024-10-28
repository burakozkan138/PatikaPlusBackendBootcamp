/*
film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter? 
*/

SELECT DISTINCT replacement_cost FROM film;
-- get all different values from replacement_cost column in film table

SELECT COUNT(DISTINCT replacement_cost) FROM film;
-- get the number of different values in replacement_cost column in film table

SELECT COUNT(title) FROM film WHERE title LIKE 'T%' AND rating = 'G';
-- get the number of movies whose title starts with 'T' and rating is 'G'

SELECT COUNT(country) FROM country WHERE country LIKE '_____';
-- get the number of countries whose name is 5 characters long

SELECT COUNT(city) FROM city WHERE city ILIKE '%r';
-- get the number of cities whose name ends with 'r' or 'R'