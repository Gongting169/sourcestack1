﻿

CREATE TABLE [dbo].[PROBLEM]
(
[Id] INT NOT NULL PRIMARY KEY,
[NAME] Nvarchar(10) NULL
);

ALTER TABLE PROBLEM
ALTER COLUMN [NeedRemoteHelp] ISFEMALE;

SELECT * FROM [PROBLEM];












