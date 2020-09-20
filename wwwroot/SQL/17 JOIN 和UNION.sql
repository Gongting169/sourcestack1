  
   SELECT * FROM [USER]  ;
  SELECT *  FROM  PROBLEM ;
--联表查出求助的标题和作者用户名
SELECT 
  P.[ID],
  p.Title,
  U.[USERNAME],
  p.[AUTHOR]
  FROM PROBLEM P JOIN [USER] U
  ON  P.ProbelmUserID  = U.ID;
--查找并删除从未发布过求助的用户
BEGIN TRAN 
DELETE [user]  
--SELECT *
FROM [USER], Problem  
--ON  P.ProbelmUserID = U.ID
WHERE [USER].[ID]  NOT  IN  (SELECT ProbelmUserID FROM  PROBLEM ) ; 

rollback;

--用一句SELECT显示出用户和他的邀请人用户名
SELECT [USERNAME],[INVITEDBY] FROM [USER] WHERE ID =2;

ALTER TABLE [USER]
ADD INVITEDBY INT  CONSTRAINT  FK_USER_INVITEDBY  FOREIGN KEY   REFERENCES [USER]([ID]);


--17bang的关键字有“一级”“二级”和其他“普通（三）级”的区别：
--请在表Keyword中添加一个字段，记录这种关系
SELECT * FROM KEYWORD ;

ALTER TABLE KEYWORD
ADD FIRST INT  CONSTRAINT  FK_KEYWORD_FIRST  FOREIGN KEY  REFERENCES KEYWORD([ID]);

ALTER TABLE KEYWORD
ADD Second INT  CONSTRAINT  FK_KEYWORD_Second  FOREIGN KEY  REFERENCES KEYWORD([ID]);

ALTER TABLE KEYWORD
ADD Third INT  CONSTRAINT  FK_KEYWORD_Third  FOREIGN KEY  REFERENCES KEYWORD([ID]);

UPDATE KEYWORD  SET FIRST = 15 WHERE ID = 10;
UPDATE KEYWORD  SET FIRST =15 WHERE ID = 20;
UPDATE KEYWORD  SET FIRST = 30 WHERE ID = 25;
UPDATE KEYWORD  SET FIRST =30 WHERE ID = 35;

UPDATE KEYWORD  SET Second = 20 WHERE ID = 10;
UPDATE KEYWORD  SET Second  =20 WHERE ID = 15;
UPDATE KEYWORD  SET Second  =35 WHERE ID = 30;
UPDATE KEYWORD  SET Second  =35 WHERE ID = 25;

--然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：
SELECT [ID] ,[NAME] ,FIRST ,Second  FROM KEYWORD  WHERE KEYWORD.FIRST = KEYWORD.ID AND KEYWORD.Second = KEYWORD.ID;

--17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
--建议和文章没有悬赏（Reward）
--建议多一个类型：Kind NVARCHAR(20)） 一篇文章可以有多个建议和求助 文章 父表  建议和求助 子表
--文章多一个分类：Category INT）
--请按上述描述建表。然后，用一个SQL语句显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列
SELECT Title ,Content FROM  PROBLEM ,Suggest ,Article  WHERE PROBLEM.ProArtID = Article.ID AND Suggest.SugArtId = Article.ID ORDER BY PublishTime DESC;

SELECT * FROM PROBLEM ;
--SELECT * FROM Suggest  ;
SELECT * FROM Article ;

UPDATE PROBLEM SET ProArtID =1 WHERE ID =1
UPDATE PROBLEM SET ProArtID =7 WHERE ID =3
UPDATE PROBLEM SET ProArtID =1 WHERE ID =4
UPDATE PROBLEM SET ProArtID =7 WHERE ID =6
UPDATE PROBLEM SET ProArtID =8 WHERE ID =7
UPDATE PROBLEM SET ProArtID =8 WHERE ID =8


ALTER TABLE PROBLEM 
ADD [ProArtID] INT CONSTRAINT  FK_PROBLEM_ProArtID   FOREIGN KEY  REFERENCES Article(ID);

CREATE TABLE Suggest
(
 [ID] INT PRIMARY KEY IDENTITY(1,1),
 [Title] NVARCHAR(50),
 [Content] NTEXT,
 [PublishTime] DATETIME,
 [AUTHOR] NVARCHAR(50),
 [Kind] NVARCHAR(20),
 [SugArtId] INT CONSTRAINT FK_Suggest_SugArtId  FOREIGN KEY  REFERENCES  Article(Id)
);

INSERT Suggest   VALUES(N'电话费',N'女数据库','2019/12/1',N'小天',N'语文',2)
INSERT Suggest  VALUES(N'都不会',N'女率地方','2019/11/3',N'小黄',N'生物',2)
INSERT Suggest  VALUES(N'大女开',N'物流费可','2020/4/5',N'小李',N'科学',3)
INSERT Suggest  VALUES(N'大健康',N'凯撒大第','2020/7/7',N'小黄',N'化学',3)
INSERT Suggest  VALUES(N'八点半',N'担负可的','2018/11/10',N'小明',N'物理',4)
INSERT Suggest VALUES(N'副科级',N'都是你看','2018/5/6',N'小黄',N'数学',4)

CREATE TABLE Article
(
 [ID] INT PRIMARY KEY IDENTITY(1,1),
 [Title] NVARCHAR(50),
 [Content] NTEXT,
 [PublishTime] DATETIME,
 [AUTHOR] NVARCHAR(50),
 [Category] INT
);

INSERT Article  VALUES(N'电话费',N'女数据库','2020/8/7',N'小黄',3)
INSERT Article  VALUES(N'都不会',N'女率地方','2018/10/7',N'小黄',4)
INSERT Article  VALUES(N'大女开',N'物流费可','2019/3/7',N'小黄',3)
INSERT Article  VALUES(N'大健康',N'凯撒大第','2019/5/5',N'小黄',5)
INSERT Article  VALUES(N'八点半',N'担负可的','2018/12/13',N'小黄',3)
INSERT Article  VALUES(N'副科级',N'都是你看','2020/1/7',N'小黄',2)






