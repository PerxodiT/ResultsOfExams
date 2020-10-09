CREATE TABLE [dbo].[Student]
(
	[StudentNumber] INT NOT NULL PRIMARY KEY, 
    [FIO] TEXT NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL, 
    [Gender] BINARY(1) NOT NULL, 
    [Group] TEXT NOT NULL, 
    [Specialty] TEXT NOT NULL, 
    [Facult] TEXT NOT NULL
)
