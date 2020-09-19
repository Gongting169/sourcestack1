
--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字

CREATE TABLE Keyword
(
 [Id] INT ,
 [NAME] NVARCHAR(200),
 [KeyWord] NVARCHAR(100),
 [USETIME] INT,
 [Response] INT,
 [Inculde] NTEXT
);
 SELECT * FROM  Keyword ;

INSERT Keyword  VALUES(1,N'来自新疆的小哥',N'律师',12,2,N'各过各的发红包吧');
INSERT Keyword  VALUES(2,N'收到的税款VN树树',N'编程',22,5,N'会受到卡括号SDK');
INSERT Keyword  VALUES(3,N'不到十块V领开始的',N'拖欠工资',32,10,N'VB数据表');
INSERT Keyword  VALUES(4,N'上班V家不是道具v',N'JAVA',36,8,N'会死UHD速度快打个');
INSERT Keyword  VALUES(5,N'速度加快速度你看',N'编程开发语言',15,3,N'很好的私房话');
INSERT Keyword  VALUES(6,N'会死VB速度大V',N'顾问咨询',8,3,N'上过课深V领电脑');
INSERT Keyword  VALUES(7,N'方式开口VN据',N'操作系统',25,6,N'办私事打开快睡吧');

SELECT * FROM PROBLEM ;

ALTER  TABLE KEYWORD
ADD CONSTRAINT PK_KEYWORD_ID  PRIMARY KEY ([ID]);

ALTER COLUMN [ID] INT  NOT  NULL;

GO
CREATE TABLE [dbo].Keyword2Problem
(
 [KeywordID] INT CONSTRAINT FK_K2P_KeywordID  FOREIGN KEY  REFERENCES Keyword(ID),
 [ProblemID] INT CONSTRAINT FK_K2P_ProblemID  FOREIGN KEY  REFERENCES Problem(ID)
);

SELECT * FROM PROBLEM ;
 SELECT * FROM  Keyword ;
 INSERT Keyword2Problem  VALUES(1,1);
INSERT Keyword2Problem  VALUES(1,2);
INSERT Keyword2Problem  VALUES(2,1);
INSERT Keyword2Problem  VALUES(3,1);
INSERT Keyword2Problem  VALUES(5,2);
INSERT Keyword2Problem  VALUES(1,4);
INSERT Keyword2Problem  VALUES(3,1);
INSERT Keyword2Problem  VALUES(5,3);
INSERT Keyword2Problem  VALUES(1,6);
INSERT Keyword2Problem  VALUES(3,1);
INSERT Keyword2Problem  VALUES(3,5);
 SELECT * FROM Keyword2Problem ;

  --DELETE Keyword2Problem WHERE KeywordID >3; 没执行
 --ALTER TABLE Keyword2Problem
 --ALTER  COLUMN ProblemID INT NOT  NULL; 设置了prid和keid不为空

 --ALTER TABLE Keyword2Problem ADD CONSTRAINT PK_Keyword2Problem_K2P PRIMARY KEY(KeywordID,ProblemID);  没执行成功
--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
SELECT * FROM PROBLEM ;
 SELECT * FROM  Keyword ;
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
SELECT * FROM 
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
  UPDATE PROBLEM SET KeyWord = N'' WHERE ID = 5
--删除该求助
UPDATE Keyword2Problem  SET KeywordID = NULL  WHERE  KeywordID = 3;
DELETE Keyword2Problem  WHERE KeywordID = 3
DELETE Keyword WHERE ID = 3
DELETE Problem WHERE ID =1
--删除某关键字
UPDATE Keyword SET KeyWord =N'' WHERE Id =5;



