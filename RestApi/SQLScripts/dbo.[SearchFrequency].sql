IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[SearchFrequency]') AND type in (N'U'))

BEGIN

CREATE TABLE SearchFrequency(
	LocationID INT,
	Frequency INT
)


ALTER TABLE SearchFrequency
ADD CONSTRAINT SearchFrequency_FK FOREIGN KEY ( LocationID ) 
REFERENCES Location(ID)


END