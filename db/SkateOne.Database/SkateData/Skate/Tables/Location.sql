CREATE TABLE [Skate].[Location] (
    [Id]   INT         IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Id] ASC)
);

