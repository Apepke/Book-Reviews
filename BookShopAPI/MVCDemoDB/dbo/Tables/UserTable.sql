﻿CREATE TABLE [dbo].[UserTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(50) NOT NULL, 
    [title] NVARCHAR(50) NOT NULL, 
    [author] NVARCHAR(50) NOT NULL, 
    [review] NVARCHAR(200) NOT NULL
)
