/* 
test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
*/

CREATE TABLE employee (
    id INTEGER PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);
-- create employee table with id, name, birthday, email columns

UPDATE employee SET name = 'Burak Özkan' WHERE id = 1;
-- update name of the employee with id 1
UPDATE employee SET birthday = '2001-06-11' WHERE id = 1;
-- update birthday of the employee with id 1
UPDATE employee SET email = 'burakozkan138@gmail.com' WHERE id = 1;
-- update email of the employee with id 1
UPDATE employee SET name = 'Burak' WHERE id = 51;
-- update name of the employee with id 51

-- Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM employee WHERE id = 2;
-- delete employee with id 2
DELETE FROM employee WHERE name = 'John';
-- delete employee with name John
DELETE FROM employee WHERE birthday = '1990-01-01';
-- delete employee with birthday 1990-01-01
DELETE FROM employee WHERE email = 'test@gmail.com';
-- delete employee with email