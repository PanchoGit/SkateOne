USE SkateOne
GO

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
				 WHERE TABLE_SCHEMA = 'Skate' 
                 AND  TABLE_NAME = 'Skater'))
BEGIN
	CREATE TABLE [Skate].[Skater] (
	    [Id]     INT         IDENTITY (1, 1) NOT NULL,
	    [Name]   NVARCHAR(255) NULL,
	    [Brand]  NVARCHAR(255) NULL,
	    [Stance] NVARCHAR(100) NULL,
	    CONSTRAINT [PK_Skater] PRIMARY KEY CLUSTERED ([Id] ASC)
	);
END

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
				 WHERE TABLE_SCHEMA = 'Skate' 
                 AND  TABLE_NAME = 'Type'))
BEGIN
	CREATE TABLE [Skate].[Type] (
	    [Id]   INT         IDENTITY (1, 1) NOT NULL,
	    [Name] NVARCHAR(255) NULL,
	    CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED ([Id] ASC)
	);
END

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
				 WHERE TABLE_SCHEMA = 'Skate' 
                 AND  TABLE_NAME = 'Location'))
BEGIN
	CREATE TABLE [Skate].[Location] (
	    [Id]   INT         IDENTITY (1, 1) NOT NULL,
	    [Name] NVARCHAR (255) NULL,
	    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Id] ASC)
	);
END

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'Skate' 
                 AND  TABLE_NAME = 'Event'))
BEGIN
	CREATE TABLE [Skate].[Event] (
	    [Id]         INT         IDENTITY (1, 1) NOT NULL,
	    [Name]       NVARCHAR (255) NULL,
	    [TypeId]     INT         NULL,
	    [LocationId] INT         NULL,
	    [Date]       DATE        NULL,
	    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([Id] ASC),
	    CONSTRAINT [FK_EventLocation] FOREIGN KEY ([LocationId]) REFERENCES [Skate].[Location] ([Id]),
	    CONSTRAINT [FK_EventType] FOREIGN KEY ([TypeId]) REFERENCES [Skate].[Type] ([Id])
	);
END

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'Skate' 
                 AND  TABLE_NAME = 'Score'))
BEGIN
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
END