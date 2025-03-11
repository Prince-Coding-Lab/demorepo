SELECT * FROM [production].[products]
WHERE model_year BETWEEN 2018 AND 2020;


select * from [sales].[customers] where city='New York'

SELECT first_name,last_name,CASE
    WHEN phone IS NULL OR phone ='' THEN 'Not available'
    ELSE phone
END as Phone
FROM [sales].[customers]


SELECT DISTINCT city FROM [sales].[customers];



SELECT COUNT(customer_id) as TotalCustomer, city
FROM  [sales].[customers] --where city='New York'
GROUP BY city
having COUNT(customer_id) > 15;


SELECT TOP 10 * FROM [sales].[customers];
