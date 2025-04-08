USE [BikeStores]
GO
IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[spi_brands]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[spi_brands]
END
/****** Object:  StoredProcedure [dbo].[spi_brands]    Script Date: 08/04/2025 12:26:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--exec [spi_brands] 3,3,'Hno 232','123','12312 road'
-- =============================================
-- Author:		Prince Kumar
-- Create date: 08/04/2025
-- Description:	Insert data into brands table
-- =============================================
CREATE PROCEDURE [dbo].[spi_brands] (
	@BrandName  NVARCHAR(300)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @return INT

		IF NOT EXISTS (
				SELECT TOP 1 1
				FROM [production].[brands]
				WHERE brand_name =  @BrandName
				)
		BEGIN
			INSERT INTO [production].[brands](
				 brand_name
				)
			VALUES (
	             @BrandName		  
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