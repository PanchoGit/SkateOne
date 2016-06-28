CREATE TABLE [Report].[Skater] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (255) NULL,
    [Brand]  NVARCHAR (255) NULL,
    [Stance] NVARCHAR (100) NULL,
    CONSTRAINT [PK_Skater] PRIMARY KEY CLUSTERED ([Id] ASC)
);

