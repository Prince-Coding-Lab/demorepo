USE [BikeStores]
GO
/****** Object:  StoredProcedure [dbo].[spsStaffs]    Script Date: 3/04/2025 05:44:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spsStaffs]
AS
BEGIN 

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; 

	IF EXISTS(SELECT TOP 1 1 from sales.staffs)         
		 BEGIN  
		 SELECT * FROM sales.staffs

		 RETURN 105 -- record exists  
		 END
	ELSE
		BEGIN        
			RETURN 102 -- reconrd does not exists        
		END


END
