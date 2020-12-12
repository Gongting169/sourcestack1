
Select [PASSWORD],[USERNAME],[InvitedBy],[ID] from [USER] Where [USERNAME] =N'管理员';
SELECT * FROM Article;
SELECT * FROM KEYWORD;
SELECT * FROM ArticleKeword;

Select [PASSWORD] from [USER] Where [USERNAME] = N'管理员';
 
 select * from ArticleKeword  AK  
JOIN Article  ON Article.ID = AK.ArticleID  
JOIN KEYWORD ON KEYWORD.ID =AK.KeywordID


 
 select COUNT(Article.ID) from  ArticleKeword  AK  
JOIN Article  ON Article.ID = AK.ArticleID  
JOIN KEYWORD ON KEYWORD.ID =AK.KeywordID


 select COUNT(KEYWORD.ID) from  ArticleKeword  AK  
JOIN Article  ON Article.ID = AK.ArticleID  
JOIN KEYWORD ON KEYWORD.ID =AK.KeywordID

 select COUNT(ArticleKeword.ArticleID) from  ArticleKeword  AK  
JOIN Article  ON Article.ID = AK.ArticleID  
JOIN KEYWORD ON KEYWORD.ID =AK.KeywordID




CREATE TABLE [dbo].ArticleKeword
(
 [KeywordID] INT  NOT NULL CONSTRAINT FK_KeywordID  FOREIGN KEY  REFERENCES Keyword(ID),
 [ArticleID] INT  NOT NULL CONSTRAINT FK_ArticleID  FOREIGN KEY  REFERENCES Article(ID),
);

SELECT Article.ID,Article.Title,Article.PublishTime,Article.Content,Article.AUTHOR FROM ArticleKeword  AK  
JOIN Article  ON Article.ID = AK.ArticleID  
JOIN KEYWORD ON KEYWORD.ID =AK.KeywordID


--BEGIN TRAN 
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(1,10);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(1,15);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(2,10);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(2,30);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(3,25);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(3,10);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(4,35);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(4,15);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(5,10);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(5,15);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(5,20);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(6,20);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(6,25);
--INSERT ArticleKeword(ArticleID,KeywordID) VALUES(6,35);
--ROLLBACK;