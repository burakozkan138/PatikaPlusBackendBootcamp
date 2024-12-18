/*     country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.
country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.
film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.
film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.
*/

SELECT country FROM country WHERE country LIKE 'A%a';
-- get all countries from country table where country name starts with 'A' and ends with 'a'
SELECT country FROM country WHERE country LIKE '_____%n';
-- get all countries from country table where country name is at least 6 characters long and ends with 'n'
SELECT title FROM film WHERE title ILIKE '%t%t%t%t%';
-- get all movies from film table where title contains at least 4 't' characters
SELECT *
FROM film
WHERE
    title LIKE 'C%'
    AND length > 90
    AND rental_rate = 2.99;