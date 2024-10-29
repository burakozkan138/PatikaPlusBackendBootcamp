/*     
film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.
film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.
customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.
*/

SELECT *
FROM film
WHERE
    title LIKE '%n'
ORDER BY length DESC
LIMIT 5;
-- order by "length" Descending for the longest 5 films ending with 'n' character

SELECT *
FROM film
WHERE
    title LIKE '%n'
ORDER BY length ASC
LIMIT 5
OFFSET
    5;

-- order by "length" Ascending for the shortest 5 films ending with 'n' character

SELECT *
FROM customer
WHERE
    store_id = 1
ORDER BY last_name DESC
LIMIT 4;

-- order by "last_name" Descending for the first 4 customers with store_id = 1