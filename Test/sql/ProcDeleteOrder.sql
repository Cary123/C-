IF Exists(SELECT NAME FROM sysobjects WHERE NAME = 'ProcDeleteOrder' and TYPE='P') 
DROP PROCEDURE ProcDeleteOrder 
GO
CREATE PROCEDURE ProcDeleteOrder
(
 @OrderId NVARCHAR(50),
 @LastUpdateTime DATETIME
)
AS
DECLARE @UserId NVARCHAR(50)
BEGIN
	SELECT @UserId = UserId FROM Orders WHERE OrderId = cast(@OrderId AS UNIQUEIDENTIFIER)
	IF @UserId IS NOT NULL AND @UserId <> ''
	BEGIN
		DELETE FROM Orders WHERE OrderId = cast(@OrderId AS UNIQUEIDENTIFIER)
		WAITFOR DELAY '00:00:10'
		UPDATE Users SET LastUpdateTime = @LastUpdateTime WHERE UserId = cast(@UserId AS UNIQUEIDENTIFIER)
	end
END
GO

exec ProcDeleteOrder @OrderId=N'd971e697-6088-428d-a494-d404c2b3110e',@LastUpdateTime='2017-08-06 22:03:35.080'