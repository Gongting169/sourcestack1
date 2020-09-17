
--发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
--将该求助的作者改成另外一个用户
--删除该用户

--SELECT * FROM PROBLEM ; 从表，要先设置主键不为空 not null，然后再设置一个主键约束 
--SELECT * FROM [USER] ;  主表要建立一个problemID列， 然后在创建两个约束。 

ALTER TABLE [PROBLEM]
ADD  Orientation NVARCHAR(200);

ADD  Reward  INT ;

ADD Keywords NVARCHAR(100);

ADD  Explain  NTEXT ;

ADD Title NVARCHAR(500);

ALTER  TABLE [USER]
ADD [PROBLEMID] INT ;

SELECT * FROM  [USER] ;
SELECT * FROM  [PROBLEM] ;

ALTER TABLE PROBLEM
ALTER COLUMN NeedRemoteHelp BIT NULL;
ADD CONSTRAINT PK_PROBLEM_ID PRIMARY KEY([ID]);

ALTER COLUMN [ID] INT NOT NULL;

ALTER TABLE [USER]
ADD CONSTRAINT FK_PROBLEM_ID
FOREIGN KEY (PROBLEMID)
REFERENCES PROBLEM(ID);

--发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
INSERT PROBLEM ([ID] ,Orientation ) VALUES(8,N'大神飞哥');
INSERT PROBLEM ([ID] ,Orientation ) VALUES(9,N'阿泰');

INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward  ) VALUES(10,N'求助解决数据库的传值问题',N'试胆大会为嗨嗨嗨是滴',N'求助数据库',30);
INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward  ) VALUES(11,N'求助解决数',N'试胆大会为滴',N'求助数据库',40);
INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward ) VALUES(12,N'求助解决数据库的传值问题',N'试胆嗨嗨嗨是滴',N'求助数据库',50);
INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward ) VALUES(13,N'求助',N'试胆大会为嗨是滴',N'求助数据库',20);
INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward ) VALUES(14,N'求助解决数据库',N'为嗨嗨嗨是滴',N'求助数据库',10);

UPDATE [USER] SET [PROBLEMID] =8 WHERE ID =11;
UPDATE [USER] SET [PROBLEMID] =8 WHERE ID =12;
UPDATE [USER] SET [PROBLEMID] =9 WHERE ID =13;
UPDATE [USER] SET [PROBLEMID] =9 WHERE ID =14;

 SELECT 
 U.Title,
 U.Explain,
 U.Reward ,
 P.Orientation
 FROM [USER] U JOIN PROBLEM P
 ON U.PROBLEMID = P.ID ;

 SELECT * FROM  [USER] ;
SELECT * FROM  [PROBLEM] ;
 --发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
INSERT [USER] ([ID] ,Title ,Explain ,Keywords ,Reward ) VALUES(15,N'求助解决编程语言',N'为嗨BDJBDS',N'求助JAVASCRIPT',20);
UPDATE [USER] SET PROBLEMID =9 WHERE ID =15
--将该求助的作者改成另外一个用户
 UPDATE [USER] SET ID = 16 WHERE ID =15;

--删除该用户
UPDATE [USER] SET PROBLEMID = 8 WHERE  ID = 15;

BEGIN TRAN
 DELETE [USER]  WHERE ID =15; 



 





