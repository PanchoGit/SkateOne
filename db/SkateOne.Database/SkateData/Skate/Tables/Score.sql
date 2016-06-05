CREATE TABLE [Skate].[Score] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [SkaterId] INT  NOT NULL,
    [EventId]  INT  NOT NULL,
    [Date]     DATE NULL,
    [Value]    INT  NULL,
    [Position] INT  NULL,
    CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ScoreEvent] FOREIGN KEY ([EventId]) REFERENCES [Skate].[Event] ([Id]),
    CONSTRAINT [FK_ScoreSkater] FOREIGN KEY ([SkaterId]) REFERENCES [Skate].[Skater] ([Id])
);

