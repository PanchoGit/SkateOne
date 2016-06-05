CREATE TABLE [Report].[Score] (
    [Id]         INT         IDENTITY (1, 1) NOT NULL,
    [SkaterName] NVARCHAR (255) NULL,
    [EventName]  NVARCHAR (255) NULL,
    [Date]       DATE        NULL,
    [Score]      INT         NULL,
    [Position]   INT         NULL,
    CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED ([Id] ASC)
);

