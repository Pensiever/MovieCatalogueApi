CREATE TABLE [dbo].[Movie]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [ReleaseYear] INT NOT NULL, 
    [RealisatorID] INT NULL, 
    [ScenaristID] INT NULL
    ,
    CONSTRAINT FK_Scenarist FOREIGN KEY (ScenaristID) REFERENCES Person(Id), 
    CONSTRAINT [FK_Realisator] FOREIGN KEY ([RealisatorID]) REFERENCES [Person]([Id])
)