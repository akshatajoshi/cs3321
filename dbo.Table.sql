CREATE TABLE [dbo].[Table]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [username] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL, 
    [firstname] NVARCHAR(50) NOT NULL, 
    [lastname] NVARCHAR(50) NOT NULL, 
    [grade] INT NOT NULL, 
    [DOB] SMALLDATETIME NOT NULL
)
