
--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE Response
(
[Id]  INT,
[Content] NVARCHAR(MAX),
[AuthorId] INT  CONSTRAINT  FK_Respone_AuthorId   FOREIGN KEY   REFERENCES PROBLEM(ID),
[ProblemId] INT ,
[CreateTime] DATETIME,
[ReponseAuthorName] NVARCHAR(50),
[ProblemAuthorName]  NVARCHAR(50),
[ProblemTitle]  NVARCHAR(50)
);

INSERT Response VALUES(1,N'数据表',5,1,'2020/8/6',N'张三',N'李四',N'编程大酒');
INSERT Response VALUES(2,N'多少岁',6,1,'2019/1/6',N'王五',N'你是',N'见不到');
INSERT Response VALUES(3,N'等你拿',3,1,'2018/7/1',N'赵柳',N'参加',N'数据的');
INSERT Response VALUES(4,N'的数据',1,1,'2019/3/9',N'飞哥',N'达到',N'的深V');
INSERT Response VALUES(5,N'往往会',3,1,'2020/9/26',N'小李',N'谁说',N'是表激');
INSERT Response VALUES(6,N'大酒店',6,1,'2019/5/3',N'小明',N'实习',N'大保健');
INSERT Response VALUES(7,N'那几款',5,1,'2020/8/31',N'小黄',N'李天',N'东北局 ');

--然后生成一个视图 VResponse(ResponseId, Content, ResponseAuthorId，ReponseAuthorName, ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)，要求该视图：
GO
CREATE VIEW V_VResponse ([Id], Content, [AuthorId],ReponseAuthorName, [ProblemId], ProblemAuthorName, ProblemTitle, CreateTime)
AS 
 SELECT [Id],[AuthorId], 
 [ProblemId], Content,CreateTime,
 ReponseAuthorName,ProblemAuthorName
 ,ProblemTitle  FROM  Response

--能展示应答作者的用户名、应答对应求助的标题和作者用户名 （JOIN）
GO
SELECT * FROM PROBLEM ;
SELECT * FROM [USER]  ;
SELECT R.[ReponseAuthorName],P.TITLE ,P.AUTHOR ,U.USERNAME  
FROM  PROBLEM P 
JOIN Response R ON R.AuthorId = P.Id  
JOIN [USER] U ON P.ProbelmUserID  = U.ID

--只显示应答时间在2020年5月27日之后的数据 （JOIN）
SELECT * FROM Response R JOIN PROBLEM P ON  R.AuthorId = P.ID  WHERE CreateTime < '2020/5/27';
--已被加密
GO
ALTER VIEW V_VResponse
WITH ENCRYPTION
AS 
 SELECT [Id],[AuthorId], 
 [ProblemId], Content,CreateTime,
 ReponseAuthorName,ProblemAuthorName
 ,ProblemTitle  FROM  Response

--保证其使用的基表结构无法更改
GO
ALTER VIEW V_VResponse
WITH SCHEMABINDING
AS 
 SELECT [Id],[AuthorId], 
 [ProblemId], Content,CreateTime,
 ReponseAuthorName,ProblemAuthorName
 ,ProblemTitle  FROM  dbo.Response 
--演示：在VResponse中插入一条数据（注意业务逻辑正确性），却不能在视图中显示
GO
ALTER VIEW V_VResponse
WITH SCHEMABINDING
AS 
 SELECT [Id],[AuthorId], 
 [ProblemId], Content,CreateTime,
 ReponseAuthorName,ProblemAuthorName
 ,ProblemTitle  FROM  dbo.Response 
 WHERE CreateTime > '2020/1/1'

 INSERT V_VResponse ([Id], Content, [AuthorId],ReponseAuthorName, [ProblemId], ProblemAuthorName, ProblemTitle, CreateTime)
 VALUES(8,N'那几款',6,1,'2019/8/7',N'布局的',N'登记表',N'就看出');

--修改VResponse，让其能避免上述情形
GO
ALTER VIEW V_VResponse
WITH SCHEMABINDING
AS 
 SELECT [Id],[AuthorId], 
 [ProblemId], Content,CreateTime,
 ReponseAuthorName,ProblemAuthorName
 ,ProblemTitle  FROM  dbo.Response 
 WHERE CreateTime > '2020/1/1'
  WITH CHECK OPTION

--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
--能反映求助的标题、使用关键字数量和悬赏


GO
CREATE VIEW V_VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
AS  
SELECT *
FROM PROBLEM P JOIN KeywordProblem KP ON KP.ProblemID =P.ID ;

GO   


--在ProblemId上有一个唯一聚集索引
CREATE UNIQUE CLUSTERED INDEX IX_VProblemKeyword_ProblemId ON VProblemKeyword(ProblemId);

--在ProblemReward上有一个非聚集索引
CREATE UNIQUE NONCLUSTERED INDEX IX_VProblemKeyword_ProblemReward ON VProblemKeyword(ProblemReward)


--在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化





