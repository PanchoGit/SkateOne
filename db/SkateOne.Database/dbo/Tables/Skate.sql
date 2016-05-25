CREATE TABLE [dbo].[Skate]
(
	[Id] INT IDENTITY NOT NULL, 
    [Name] NCHAR(255) NULL, 
    [Brand] NCHAR(255) NULL, 
    [Stance] NCHAR(100) NULL, 
    CONSTRAINT [PK_Skate] PRIMARY KEY ([Id])
)
