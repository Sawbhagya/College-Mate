﻿CREATE TABLE [Submission]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Attachment] VARBINARY(MAX) NOT NULL
)
