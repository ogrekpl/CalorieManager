CREATE TABLE [dbo].[Activities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(100) NULL, 
    [Calories] DECIMAL(4, 3) NULL
)
