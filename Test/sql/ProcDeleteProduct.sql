IF Exists(SELECT NAME FROM sysobjects WHERE NAME = 'ProcDeleteProduct' and TYPE='P') 
DROP PROCEDURE ProcDeleteProduct 
GO
CREATE PROCEDURE ProcDeleteProduct
(
 @ProductId UNIQUEIDENTIFIER
)
AS
BEGIN
	DELETE FROM Product WHERE ProductId = @ProductId
END
GO
