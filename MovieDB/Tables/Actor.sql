﻿CREATE TABLE [dbo].[Actor]
(
	[PersonID] INT NOT NULL, 
    [MovieID] INT NOT NULL, 
    [Role] VARCHAR(50) NOT NULL 
    CONSTRAINT FK_Person_Actor FOREIGN KEY (PersonID) REFERENCES Person(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Person_Movie FOREIGN KEY (MovieID) REFERENCES Movie(Id) ON DELETE CASCADE ON UPDATE CASCADE
)