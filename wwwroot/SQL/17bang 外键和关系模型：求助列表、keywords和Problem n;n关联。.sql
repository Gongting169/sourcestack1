

--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字

CREATE TABLE KeywordS
(
[ID] INT NOT NULL,
[KeyWord] NVARCHAR(100),
);

INSERT KeywordS   VALUES(1,N'律师');
INSERT KeywordS   VALUES(2,N'编程');
INSERT KeywordS   VALUES(3,N'拖欠工资');
INSERT KeywordS   VALUES(4,N'JAVA');
INSERT KeywordS   VALUES(5,N'编程开发语言');
INSERT KeywordS  VALUES(6,N'顾问咨询');

--ALTER  TABLE PROBLEM
----ALTER COLUMN [ID] INT  NOT  NULL;

--ALTER  TABLE PROBLEM
--ADD  CONSTRAINT PK_PROBLEM_ID PRIMARY KEY ([ID]);

--ADD CONSTRAINT PK_KeywordS_ID  PRIMARY KEY ([ID]);

CREATE TABLE [dbo].Keyword2Problem
(
 [KeywordSID] INT CONSTRAINT FK_K2P_KeywordSID  FOREIGN KEY  REFERENCES KeywordS(ID),
 [ProblemID] INT CONSTRAINT FK_K2P_ProblemID  FOREIGN KEY  REFERENCES Problem(ID)
);

INSERT Keyword2Problem  VALUES(1,3);
INSERT Keyword2Problem  VALUES(1,6);
INSERT Keyword2Problem  VALUES(2,3);
INSERT Keyword2Problem  VALUES(3,6);
INSERT Keyword2Problem  VALUES(5,2);
INSERT Keyword2Problem  VALUES(1,4);
INSERT Keyword2Problem  VALUES(3,7);
INSERT Keyword2Problem  VALUES(5,3);
INSERT Keyword2Problem  VALUES(5,7);
INSERT Keyword2Problem  VALUES(2,7);
INSERT Keyword2Problem  VALUES(3,1);

 ALTER TABLE Keyword2Problem
 ALTER  COLUMN ProblemID INT NOT  NULL;

  ALTER TABLE Keyword2Problem
 ALTER  COLUMN KeywordSID INT NOT  NULL;

 ALTER TABLE Keyword2Problem ADD CONSTRAINT PK_Keyword2Problem_K2P PRIMARY KEY(KeywordSID,ProblemID);  

 SELECT * FROM KeywordS,PROBLEM,Keyword2Problem  where Keyword2Problem.KeywordSID = KeywordS.ID AND Keyword2Problem.ProblemID = Problem.ID;

--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
 SELECT * FROM KeywordS,PROBLEM,Keyword2Problem  where Keyword2Problem.KeywordSID = KeywordS.ID AND Keyword2Problem.ProblemID = Problem.ID;

--发布了一个使用了若干个关键字的求助
INSERT KeywordS VALUES(7,N'原理');
INSERT KeywordS VALUES(8,N'加密');

INSERT PROBLEM VALUES(8,N'试试三等奖',N'弗吉凯柏',0,23,'2019/7/1',N'飞哥',1);

INSERT Keyword2Problem VALUES(7,8);
INSERT Keyword2Problem VALUES(8,8);

--该求助不再使用某个关键字
  UPDATE KeywordS SET KeyWord = N'' WHERE ID = 8
--删除该求助
BEGIN TRAN 
DELETE Keyword2Problem WHERE KeywordSID=7 AND ProblemID=8;
DELETE Keyword2Problem WHERE KeywordSID=8 AND ProblemID=8;
DELETE PROBLEM  WHERE ID =8;
--没有去执行
rollback;
--删除某关键字
BEGIN TRAN

DELETE  Keyword2Problem  WHERE  KeywordSID =4;
DELETE KeywordS WHERE KeyWord = N'JAVA';

--没有去执行
rollback;

SELECT * FROM KeywordS;
SELECT * FROM Problem;
SELECT * FROM Keyword2Problem;


