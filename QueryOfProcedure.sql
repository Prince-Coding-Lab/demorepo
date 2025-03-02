EXEC spsStaffs;

SELECT * FROM sales.staffs

EXEC spiStaffs @FirstName='Cherry' ,
@LastName='Singla' ,
@Email='Cherry.Sigla@gmail.com' ,
@Phone='343433434' ,
@Active=1 ,
@StoreId=1 ,
@ManagerId =1

EXEC spiStaffs 'Tom' ,
'Cruse' ,
'Tom.cruse@gmail.com' ,
'9834343' ,
1 ,
1 ,
1