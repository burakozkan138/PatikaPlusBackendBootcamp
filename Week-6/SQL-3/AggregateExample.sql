/* 
film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?
film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?
film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?
film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?
*/

SELECT AVG(rental_rate) FROM film;
-- average of rental_rate column in film table

SELECT COUNT(*) FROM film WHERE title LIKE 'C%';
-- number of films starting with 'C' character
  
SELECT MAX(length) FROM film WHERE rental_rate = 0.99;
-- length of the longest film with rental_rate = 0.99

SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE length > 150;
-- number of different replacement_cost values of films with length > 150