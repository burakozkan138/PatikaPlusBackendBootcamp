/* 
actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
İlk 3 sorguyu tekrar eden veriler için de yapalım.
*/

SELECT first_name FROM actor UNION SELECT first_name FROM customer;
-- UNION operator is used to combine the result-set of two or more SELECT statements.
SELECT first_name
FROM actor
INTERSECT
SELECT first_name
FROM customer;
-- INTERSECT operator is used to combine the result-set of two or more SELECT statements.
SELECT first_name FROM actor EXCEPT SELECT first_name FROM customer;
-- EXCEPT operator is used to combine the result-set of two or more SELECT statements.
SELECT first_name
FROM actor
UNION ALL
SELECT first_name
FROM customer;
-- UNION ALL operator is used to combine the result-set of two or more SELECT statements.