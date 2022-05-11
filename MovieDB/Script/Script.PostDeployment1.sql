USE MovieDB
go
INSERT INTO Person VALUES ('Hammil', 'Mark')
INSERT INTO Person VALUES ('Ford', 'Harisson')
INSERT INTO Person VALUES ('Fisher', 'Carrie')
INSERT INTO Person VALUES ('Lucas', 'George')
INSERT INTO Person VALUES ('Spielberg', 'Steven')
INSERT INTO Person VALUES ('Kershner', 'Irvin')
INSERT INTO Person VALUES ('Kasdan', 'Lawrence')
go

INSERT INTO Movie VALUES ('Star Wars - A New Hope', 'Space Opera', 1977, 4, 4)
INSERT INTO Movie VALUES ('Star Wars - Empire Strikes Back', 'Space Opera', 1979, 4, 6)
INSERT INTO Movie VALUES ('Indiana Jones - Cursed temple', 'Aventure', 1981, 5, 7)
go

INSERT INTO Actor VALUES (1, 1, 'Luke Skywalker')
INSERT INTO Actor VALUES (2, 1, 'Han Solo')
INSERT INTO Actor VALUES (3, 1, 'Leia Organa')
INSERT INTO Actor VALUES (1, 2, 'Luke Skywalker')
INSERT INTO Actor VALUES (2, 2, 'Han Solo')
INSERT INTO Actor VALUES (3, 2, 'Leia Organa')
INSERT INTO Actor VALUES (2, 3, 'Indiana Jones')
go

INSERT INTO [User] VALUES ('ruben.ketsman@hotmail.be', 'test1234', 'Ruben', 'Ketsman', '1998-01-31', 1, 1)
INSERT INTO [User] VALUES ('test@test.com', 'test1234', 'Test', 'Truc', '1992-03-12', 1, 0)
go

INSERT INTO Comment VALUES('Super film pour vieux geek', '2020-10-10', 1, 1)
INSERT INTO Comment VALUES('LE meilleur film de sci-fi de tout les temps', '2020-10-10', 1, 2)
INSERT INTO Comment VALUES('Je préfère le 3 :p', '2020-10-10', 2, 3)