CREATE OR ALTER PROCEDURE [dbo].[USP_AddLocation]
(
	@Address VARCHAR(255)
	,@City VARCHAR(255)
	,@State VARCHAR(255)
	,@ZipCode VARCHAR(255)
)
AS
BEGIN

INSERT INTO LOCATION (Address,State,City,ZipCode)
VALUES(@Address,@City,@State,@ZipCode)

SELECT 1

END

