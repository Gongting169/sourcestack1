

 CREATE TABLE [dbo].[PROBLEM]
 (
 [ID] INT ,
 [TITLE] NVARCHAR(500) ,
 [CONTENT] Ntext ,
 [NeedRemoteHelp] BIT,
 [Reward] INT ,
 [PublishDateTime] Datetime ,
 );

 SELECT * FROM PROBLEM 

  INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(1,N'创建',N'需要熟悉很多的东西' ,15,'2018/9/7'); 

 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(2,N'修改一生健康%',N'修改小细节' ,30,'2019/9/5'); 

 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(3,N'装饰数据库',N'装修样式' ,8,'2020/4/7');
 
 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(4,N'后台今天升级上深%',N'仓库' ,18,'2019/7/1'); 

 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(5,N'运输不是一个好的工作敢为，并且数据库，还是%',N'汽车' ,22,'2018/8/7'); 

 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(6,N'管理是一个数据库，且其中%',N'管理员' ,5,'2020/9/7'); 

 INSERT [PROBLEM] ([Id] ,[TITLE] ,[CONTENT]  ,[Reward] ,[PublishDateTime]) VALUES(7,N'广告生源的代购%',N'又必须多' ,40,'2020/9/3'); 


-- 给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】 
BEGIN TRAN
UPDATE PROBLEM  SET TITLE =N'【推荐】'+TITLE  WHERE Reward >10;

ROLLBACK;

--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】 
BEGIN TRAN 
 UPDATE PROBLEM  SET TITLE =N'【加急】'+TITLE  WHERE Reward >20 AND  PublishDateTime <'2019/10/10';

 ROLLBACK;

--删除所有标题以中括号【】开头（无论其中有什么内容）的求助 
BEGIN TRAN
DELETE PROBLEM WHERE TITLE  LIKE N'【%】%';

ROLLBACK;

--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助 

SELECT * FROM  PROBLEM  WHERE  TITLE   NOT LIKE N'_____数据库%' AND TITLE  LIKE  N'%#%%' ESCAPE '#';

SELECT * FROM  PROBLEM  WHERE  TITLE   NOT LIKE N'_____%数据库%' AND TITLE  LIKE  N'%#%%' ESCAPE '#';

--SELECT TITLE  FROM  PROBLEM  WHERE  TITLE NOT LIKE N'%数据库%' AND  TITLE  LIKE N'%#%%'  ESCAPE '#';  TITLE第5个起

--SELECT TITLE  FROM  PROBLEM  WHERE  TITLE NOT LIKE N'%数据库%' AND  TITLE  LIKE N'%#%%'  ESCAPE '#';  TITLE第5个起


--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束 
--添加自定义约束，让Reward不能小于10

ALTER  TABLE PROBLEM 
ALTER COLUMN NeedRemoteHelp  BIT  NOT NULL;

ALTER  TABLE  PROBLEM 
 ALTER COLUMN NeedRemoteHelp BIT NULL;

 ALTER  TABLE  PROBLEM
 ADD CONSTRAINT CK_REWARD  CHECK (REWARD>=10);

 SELECT * FROM PROBLEM 

 UPDATE PROBLEM SET Reward =20 WHERE ID =6;

UPDATE PROBLEM  SET NeedRemoteHelp = Reward ;



--找出所有被使用次数（Used）大于10小于50的关键字名称（Name） 
--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1 
--删除所有使用次数为奇数的Keyword

 
  CREATE TABLE [dbo].[KEYWORDS]
 (
 [ID] INT IDENTITY(10,5) PRIMARY KEY,
 [NAME] NVARCHAR(20) NOT NULL,
 [USED] INT,
 [ISFEMALE] BIT ,
 );

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小明',1,25);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小黄',0,9);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小李',1,3);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小赵',0,NULL);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小田',1,17);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小周',0,45);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小刘',1,30);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小天',0,200);

 INSERT [KEYWORDS] ([NAME],[ISFEMALE] ,[USED]) VALUEs(N'小明',1,0);

 SELECT * FROM [KEYWORDS] ;

 --找出所有被使用次数（Used）大于10小于50的关键字名称（Name） 
SELECT [NAME],USED FROM [KEYWORDS] WHERE USED > 10 AND USED < 50;

--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1 
BEGIN TRAN
UPDATE [KEYWORDS] SET USED =1 WHERE USED <=0 OR USED IS NULL OR USED >100

ROLLBACK;

--删除所有使用次数为奇数的Keyword
BEGIN TRAN
DELETE [KEYWORDS]  WHERE USED%2=1;
