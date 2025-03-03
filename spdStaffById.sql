CREATE PROCEDURE spdStaffById
@id int 
AS
Delete from sales.staffs WHERE staff_id=@id
