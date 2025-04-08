USE [BikeStores]
GO
IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[spi_customers]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[spi_customers]
END
/****** Object:  StoredProcedure [dbo].[spi_customers]    Script Date: 08/04/2025 12:26:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--exec [spi_customers] 3,3,'Hno 232','123','12312 road'
-- =============================================
-- Author:		Prince Kumar
-- Create date: 08/04/2025
-- Description:	Insert data into brands table
-- =============================================
CREATE PROCEDURE [dbo].[spi_customers] (
	 @FirstName NVARCHAR(250)
	,@LastName NVARCHAR(250)
	,@Phone NVARCHAR(25)
	,@Email NVARCHAR(250)
	,@Street NVARCHAR(250)
	,@City NVARCHAR(50)
	,@State NVARCHAR(50)
	,@ZipCode NVARCHAR(5)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @return INT

		IF NOT EXISTS (
				SELECT TOP 1 1
				FROM [sales].[customers]
				WHERE first_name = @FirstName
				AND last_name = @LastName AND
				email = @Email
				)
		BEGIN
			INSERT INTO [sales].[customers](
				 first_name
				,last_name
				,phone
				,email
				,street
				,city
				,state
				,zip_code
				)
			VALUES (
	             @FirstName	
				 ,@LastName
				 ,@Phone
				 ,@Email
				 ,@Street
				 ,@City
				 ,@State
				 ,@ZipCode
				)

			SET @return = 100
		END
		ELSE
		BEGIN
			SET @return = 105
		END
	

	RETURN  @return
END 
GO