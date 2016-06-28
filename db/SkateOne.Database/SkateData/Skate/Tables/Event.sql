CREATE TABLE [Skate].[Event] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (255) NULL,
    [TypeId]     INT            NULL,
    [LocationId] INT            NULL,
    [Date]       DATE           NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventLocation] FOREIGN KEY ([LocationId]) REFERENCES [Skate].[Location] ([Id]),
    CONSTRAINT [FK_EventType] FOREIGN KEY ([TypeId]) REFERENCES [Skate].[Type] ([Id])
);

