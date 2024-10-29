/* 
film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.
3. customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir? 
4. city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.
*/

SELECT rating, COUNT(*) FROM film GROUP BY rating;
-- number of films grouped by rating

SELECT replacement_cost, COUNT(*)
FROM film
GROUP BY
    replacement_cost
HAVING
    COUNT(*) > 50;
-- replacement_cost values with more than 50 films and their counts

SELECT store_id, COUNT(*) FROM customer GROUP BY store_id;
-- number of customers grouped by store_id

SELECT country_id, COUNT(*)
FROM city
GROUP BY
    country_id
ORDER BY COUNT(*) DESC
LIMIT 1;