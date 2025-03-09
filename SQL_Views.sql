select * from sales.customers where state='NY'

select * from vNewYorkCustomers

CREATE VIEW vNewYorkCustomers AS
select first_name+' ' + last_name as CustomerName,
phone,
email
,street +', '+city +', '+ [state] +', ' +zip_code as address
from sales.customers where state='NY' and (phone<>NULL OR phone<>'')


CREATE VIEW vAllCustomers AS
select first_name+' ' + last_name as CustomerName,
phone,
email
,street +', '+city +', '+ [state] +', ' +zip_code as address
from sales.customers 