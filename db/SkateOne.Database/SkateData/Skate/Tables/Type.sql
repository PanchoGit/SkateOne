CREATE TABLE [Skate].[Type] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED ([Id] ASC)
);

