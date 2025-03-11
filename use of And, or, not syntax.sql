
SELECT * FROM [sales].[customers]


SELECT * FROM [sales].[customers]
WHERE city= 'Richmond Hill'

AND zip_code > 10000;

SELECT * FROM [sales].[customers]
WHERE city = 'Orchard Park' AND first_name LIKE 'L%' OR first_name LIKE 'R%';


SELECT * FROM[sales].[customers]
WHERE city = 'orchard Park' OR city = 'New York';


SELECT * FROM[sales].[customers]
WHERE city = 'orchard Park' OR city = 'Spain';

SELECT * FROM [sales].[customers]
WHERE NOT city = 'New York';


SELECT * FROM [sales].[customers]
WHERE City NOT IN ('Australia', 'London');

SELECT * FROM [sales].[customers]
WHERE customer_id NOT BETWEEN 10 AND 60;




SELECT * FROM [sales].[customers]
WHERE NOT customer_id < 50;


SELECT *from sales.customers

WHERE phone IS NOT NULL;




SELECT * FROM sales.customers
WHERE first_name LIKE 'La%';


SELECT * FROM sales.customers
WHERE customer_id LIKE '10%';









