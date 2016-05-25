
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Skate)
	BEGIN
		INSERT INTO Skate (Name, Brand, Stance) VALUES 
		('Luan Oliveira', 'Flip', 'Goofy')
		, ('Paul Rodriguez', 'Primitive', 'Regular')
		, ('Shane Oneill', 'Primitive', 'Regular')
		, ('Leticia Buffoni', 'Nike', 'Goofy')
		, ('Kevin Hoefler', 'PlanB', 'Goofy')
		, ('Felipe Gustavo', 'PlanB', 'Regular')
		, ('Arto Saari', 'Santa Cruz', 'Goofy')
		, ('Nyjah Huston', 'Element', 'Regular')
		, ('Tony Hawk', 'Birdhouse', 'Goofy')
		;
	END
END