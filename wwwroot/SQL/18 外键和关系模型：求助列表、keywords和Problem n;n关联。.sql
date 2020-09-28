
--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字

SELECT * FROM KEYWORD ;

UPDATE KEYWORD SET [NAME] =N'律师' WHERE ID = 10;
UPDATE KEYWORD SET [NAME] =N'编程' WHERE ID = 15;
UPDATE KEYWORD SET [NAME] =N'拖欠工资' WHERE ID = 20;
UPDATE KEYWORD SET [NAME] =N'JAVA' WHERE ID = 25;
UPDATE KEYWORD SET [NAME] =N'编程开发语言' WHERE ID = 30;
UPDATE KEYWORD SET [NAME] =N'顾问咨询' WHERE ID = 35;


ALTER  TABLE Keyword
ALTER COLUMN [ID] INT  NOT  NULL;



ALTER  TABLE KEYWORD

ADD  CONSTRAINT PK_PROBLEM_ID PRIMARY KEY ([ID]);

CREATE TABLE [dbo].KeywordProblem
(
 [KeywordID] INT CONSTRAINT FK_K2P_KeywordID  FOREIGN KEY  REFERENCES Keyword(ID),
 [ProblemID] INT CONSTRAINT FK_K2P_ProblemID  FOREIGN KEY  REFERENCES Problem(ID)
);
SELECT * FROM KeywordProblem ;

INSERT KeywordProblem  VALUES(10,3);
INSERT KeywordProblem  VALUES(15,6);
INSERT KeywordProblem  VALUES(20,3);
INSERT KeywordProblem  VALUES(30,6);
INSERT KeywordProblem  VALUES(25,2);
INSERT KeywordProblem  VALUES(15,4);
INSERT KeywordProblem  VALUES(30,7);
INSERT KeywordProblem  VALUES(15,3);
INSERT KeywordProblem  VALUES(25,7);
INSERT KeywordProblem  VALUES(20,7);
INSERT KeywordProblem  VALUES(30,1);

 ALTER TABLE KeywordProblem
 ALTER  COLUMN ProblemID INT NOT  NULL;

  ALTER TABLE KeywordProblem
 ALTER  COLUMN KeywordID INT NOT  NULL;

 ALTER TABLE KeywordProblem 
 ADD CONSTRAINT PK_KeywordProblem_KP PRIMARY KEY(KeywordID,ProblemID);  

--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
 SELECT * FROM Keyword,PROBLEM,KeywordProblem  where KeywordProblem.KeywordID = Keyword.ID AND KeywordProblem.ProblemID = Problem.ID;

 SELECT ProblemID ,COUNT(ProblemID)  FROM  KeywordProblem WHERE ProblemID=1 GROUP BY   ProblemID;
 SELECT KeywordID ,COUNT(KeywordID)  FROM  KeywordProblem WHERE KeywordID=4 GROUP BY   KeywordID;

--发布了一个使用了若干个关键字的求助
--INSERT KeywordS VALUES(7,N'原理');
--INSERT KeywordS VALUES(8,N'加密'); 没有这两行就是相当于是没有用新的关键词，是表里面已经有的值

INSERT PROBLEM VALUES(8,N'试试三等奖',N'弗吉凯柏',0,23,'2019/7/1',N'飞哥',1);

INSERT KeywordProblem VALUES(7,8);
INSERT KeywordProblem VALUES(8,8);

--该求助不再使用某个关键字
  --UPDATE KeywordS SET KeyWord = N'' WHERE ID = 8 (问题： 如果有3条求助都发布了这个关键字，只删除这条的关键字，像73这样的操作，就会把3条求助的关键字都给删除了，
  --所以要删除只能删除关系表上的关联数据)

  --DELETE Keyword2Problem WHERE KeywordSID=7 AND ProblemID=8; 正确的写法
--删除该求助
BEGIN TRAN 
DELETE KeywordProblem WHERE KeywordID=7 AND ProblemID=8;
DELETE KeywordProblem WHERE KeywordID=8 AND ProblemID=8;
DELETE PROBLEM  WHERE ID =8;
--没有去执行
rollback;
--删除某关键字
BEGIN TRAN

DELETE  KeywordProblem  WHERE  KeywordID =4;
DELETE Keyword WHERE KeyWord = N'JAVA'; 

或
DELETE  Keyword2Problem  WHERE  KeywordSID =4;
--DELETE KeywordS WHERE  id = 2 ;  比较正确
--没有去执行
rollback;

SELECT * FROM Keyword;
SELECT * FROM Problem;
SELECT * FROM KeywordProblem;

