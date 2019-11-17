CREATE TABLE dbo.EnglishWords ( ID INT IDENTITY(1, 1) PRIMARY KEY, Word VARCHAR(50) NOT NULL );

CREATE TABLE dbo.LithuanianWords ( ID INT IDENTITY(1, 1) PRIMARY KEY, Word VARCHAR(50) NOT NULL );

CREATE TABLE dbo.EnglishLithuanianWords ( EnglishWordID INT NOT NULL, LithuanianWordID INT NOT NULL, );

ALTER TABLE EnglishLithuanianWords
ADD CONSTRAINT FK_EnglishWord FOREIGN KEY ( EnglishWordID ) REFERENCES [EnglishWords] ( ID );

ALTER TABLE EnglishLithuanianWords
ADD CONSTRAINT FK_LithuanianWord FOREIGN KEY ( LithuanianWordID ) REFERENCES [LithuanianWords] ( ID );

SELECT * FROM dbo.EnglishLithuanianWords AS elw;

SELECT * FROM dbo.EnglishWords AS ew;

SELECT * FROM dbo.LithuanianWords AS lw;

SELECT ew.Word AS InEnglish
  , lw.Word AS InLithuanian
FROM dbo.EnglishWords AS ew
JOIN dbo.EnglishLithuanianWords AS elw
	ON elw.EnglishWordID = ew.ID
JOIN dbo.LithuanianWords AS lw
	ON lw.ID = elw.LithuanianWordID;