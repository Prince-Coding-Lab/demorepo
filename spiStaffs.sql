CREATE PROCEDURE spiStaffs
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(255),
@Phone varchar(25),
@Active tinyint,
@StoreId int,
@ManagerId int
AS
Insert into sales.staffs(first_name,
last_name,
email,
phone,
active,
store_id,
manager_id)
values(@FirstName,
@LastName,
@Email,
@Phone,
@Active,
@StoreId,
@ManagerId
)

