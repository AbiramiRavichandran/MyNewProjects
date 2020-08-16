

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Location]') AND type in (N'U'))

BEGIN

CREATE TABLE Location (
    [ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Address] varchar(255),
    [City] varchar(255),
    [State] varchar(255),
	[ZipCode] varchar(255)
);

END
