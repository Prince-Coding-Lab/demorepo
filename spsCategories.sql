CREATE PROCEDURE spsCategories
AS
SELECT * FROM production.categories
GO;
CREATE PROCEDURE probrand
AS
SELECT * FROM production.brands
GO;
EXEC probrand

