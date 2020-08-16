CREATE OR ALTER PROCEDURE [dbo].[USP_SearchLocation]
(
	@SearchText VARCHAR(255)
	
)
AS
BEGIN

--DECLARE @SearchText VARCHAR(255) = 'Delhi'
	
SELECT * 
INTO #SearchResult
FROM Location L
LEFT JOIN SearchFrequency S
ON L.ID = S.LocationID
WHERE Address LIKE '%'+@SearchText+'%'
OR City LIKE '%'+@SearchText+'%'
OR State LIKE '%'+@SearchText+'%'


INSERT INTO SearchFrequency
SELECT ID,1
FROM #SearchResult
WHERE LocationID IS NULL


UPDATE S
SET S.Frequency = SR.Frequency +1
FROM SearchFrequency S
INNER JOIN #SearchResult SR
ON S.LocationID = SR.LocationID

SELECT 
Address
,City
,State
,ZipCode
FROM #SearchResult
ORDER BY Frequency DESC

DROP TABLE #SearchResult

END


