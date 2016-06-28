USE SkateOne
GO

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
				 WHERE TABLE_SCHEMA = 'Report' 
                 AND  TABLE_NAME = 'Score'))
BEGIN
	CREATE TABLE [Report].[Score] (
	    [Id]         INT         IDENTITY (1, 1) NOT NULL,
	    [SkaterName] NVARCHAR (255) NULL,
	    [EventName]  NVARCHAR (255) NULL,
	    [Date]       DATE        NULL,
	    [Score]      INT         NULL,
	    [Position]   INT         NULL,
	    CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED ([Id] ASC)
	);
END

IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
				 WHERE TABLE_SCHEMA = 'Report' 
                 AND  TABLE_NAME = 'Skater'))
BEGIN
	CREATE TABLE [Report].[Skater] (
	    [Id]     INT         IDENTITY (1, 1) NOT NULL,
	    [Name]   NVARCHAR(255) NULL,
	    [Brand]  NVARCHAR(255) NULL,
	    [Stance] NVARCHAR(100) NULL,
	    CONSTRAINT [PK_Skater] PRIMARY KEY CLUSTERED ([Id] ASC)
	);
END
