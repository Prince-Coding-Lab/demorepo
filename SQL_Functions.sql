select * from vNewYorkCustomers
select * from vAllCustomers


UPPER


select dbo.CustomerName(first_name,last_name) as CustomerName,
phone,
email
,UPPER(street +', '+city +', '+ [state] +', ' +zip_code) as address
from sales.customers 



CREATE FUNCTION dbo.CustomerName(@firstName nvarchar(100),
@lastName nvarchar(100)
)
RETURNS NVARCHAR(150)
AS

BEGIN
  DECLARE @ret NVARCHAR(150);
  SET @ret = @firstName + ' ' + @lastName
  RETURN @ret;
END