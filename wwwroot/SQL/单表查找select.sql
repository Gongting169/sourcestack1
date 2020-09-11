﻿
--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作： 
--查找出Author为“飞哥”的、Reward最多的3条求助 
--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序 
--查找并统计出每个作者的：求助数量、悬赏总金额和平均值 
--找出平均悬赏值少于10的作者并按平均值从小到大排序
--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉） 
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中 


SELECT * FROM PROBLEM1;

CREATE TABLE [dbo].[PROBLEM1]
(
[ID] INT NOT  NULL,
[AUTHOR] NVARCHAR(500) NOT NULL,
[REWARD] INT ,
[NeedRemoteHelp] INT,
);

UPDATE PROBLEM1 SET REWARD =9 WHERE ID =10;

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(1,N'飞哥',10,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(2,N'飞哥',30,0);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(3,N'飞哥',5,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(4,N'小天',15,0);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(5,N'小天',11,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(6,N'小李',9,0);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(7,N'小李',8,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(8,N'飞哥',30,0);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(9,N'小天',4,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(10,N'小李',18,0);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(11,N'小明',5,4);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(12,N'小明',10,3);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(13,N'小明',7,2);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(14,N'小明',9,1);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(15,N'小黄',8,3);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(16,N'小黄',10,12);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(17,N'小黄',6,7);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,REWARD ,NeedRemoteHelp ) VALUES(18,N'小黄',3,5);

INSERT [PROBLEM1] ([ID] ,AUTHOR ,NeedRemoteHelp ) VALUES(19,N'小黄',5);
INSERT [PROBLEM1] ([ID] ,AUTHOR ,NeedRemoteHelp ) VALUES(21,N'小黄',5);


--查找出Author为“飞哥”的、Reward最多的3条求助 
SELECT TOP 3 *  FROM [PROBLEM1] WHERE AUTHOR=N'飞哥' ORDER BY REWARD DESC;


--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序 
SELECT AUTHOR ,REWARD FROM PROBLEM1  ORDER BY AUTHOR, REWARD DESC;

--查找并统计出每个作者的：求助数量、悬赏总金额和平均值 
SELECT AUTHOR,SUM (NeedRemoteHelp) AS [COUNT] FROM PROBLEM1 
GROUP BY AUTHOR ;

SELECT AUTHOR,SUM(REWARD) AS [COUNT] FROM PROBLEM1 
GROUP BY AUTHOR ;

SELECT AUTHOR ,AVG(REWARD) AS [COUNT] FROM PROBLEM1 
GROUP BY AUTHOR;

SELECT AUTHOR , AVG (NeedRemoteHelp) AS [COUNT] FROM PROBLEM1 
GROUP BY AUTHOR ;

--找出平均悬赏值少于10的作者并按平均值从小到大排序
SELECT AUTHOR , AVG(REWARD) AS [COUNT]  FROM PROBLEM1  
GROUP BY AUTHOR   HAVING AVG (REWARD) < 10   ORDER BY AVG (REWARD) ASC ;

SELECT * FROM PROBLEM1 ;

SELECT * FROM NEWPROBLEM ;

--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉） 
SELECT AUTHOR , REWARD  INTO NEWPROBLEM  FROM PROBLEM1 ;

BEGIN TRAN
DELETE PROBLEM1 WHERE  REWARD IS NULL ;


ROLLBACK;

ALTER TABLE PROBLEM1
ALTER COLUMN REWARD VARCHAR(200);

--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中 
SELECT * FROM PROBLEM1 WHERE REWARD IS NULL ;

INSERT [NEWPROBLEM]  ( AUTHOR ,REWARD) VALUES(N'小黄',NULL);
INSERT [NEWPROBLEM]  ( AUTHOR ,REWARD) VALUES(N'小黄',NULL);
INSERT [NEWPROBLEM]  ( AUTHOR ,REWARD ) VALUES(N'小黄',NULL);






