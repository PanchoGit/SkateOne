CREATE VIEW Report.ScoreVw AS
SELECT 
	SkaterName,
	EventName,
	[Date],
	Score,
	Position
FROM Report.Score
WHERE 
Score IS NOT NULL
OR Position IS NOT NULL