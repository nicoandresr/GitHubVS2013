CREATE TABLE [dbo].[Readings]
(
	[Tag] NVARCHAR(50) NOT NULL , 
    [Reader] NVARCHAR(50) NOT NULL, 
    [ReadingDateTIme] DATETIME NOT NULL, 
    PRIMARY KEY ([ReadingDateTIme], [Tag], [Reader])
)
