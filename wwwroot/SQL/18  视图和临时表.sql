
--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE Response
(
[ResponseId]  INT IDENTITY(1,1),
[Content] NVARCHAR(MAX),
[ResponseAuthorId] INT  CONSTRAINT  FK_Response_AuthorId   FOREIGN KEY   REFERENCES [User](ID),
[ProblemId] INT  CONSTRAINT FK_Response_ProblemId  FOREIGN KEY   REFERENCES Problem(ID) ,
[CreateTime] DATETIME,
);
SELECT * FROM Response ;
INSERT Response VALUES(N'数据表',5,1,'2020/8/6');
INSERT Response VALUES(N'多少岁',6,1,'2019/1/6');
INSERT Response VALUES(N'等你拿',3,3,'2018/7/1');
INSERT Response VALUES(N'的数据',1,4,'2019/3/9');
INSERT Response VALUES(N'往往会',3,3,'2020/9/26');
INSERT Response VALUES(N'大酒店',6,5,'2019/5/3');
INSERT Response VALUES(N'那几款',5,3,'2020/8/31');

--然后生成一个视图 VResponse(ResponseId, Content, ResponseAuthorId，ReponseAuthorName, ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)，要求该视图：
GO
CREATE VIEW V_VResponse (ResponseId, Content, ResponseAuthorId, ReponseAuthorName, ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)
WITH ENCRYPTION,SCHEMABINDING
AS 
 SELECT
 ResponseId,
 R.Content ,
 R.ResponseAuthorId ,
 RU.USERNAME  ,
 R.ProblemId ,
 PU.USERNAME  ,
 P.TITLE ,
 R.CreateTime 
 FROM  dbo.Response  R 
 JOIN dbo.[USER] RU ON R.ResponseAuthorId =RU.ID
 JOIN dbo.PROBLEM P ON R.ProblemId = P.ID  
 JOIN dbo.[USER] PU ON P.ProbelmUserID = PU.ID 
 WHERE CreateTime > '2020/5/27'
  WITH CHECK OPTION
 GO
--能展示应答作者的用户名、应答对应求助的标题和作者用户名 （JOIN）
--只显示应答时间在2020年5月27日之后的数据 （JOIN）
--已被加密
--保证其使用的基表结构无法更改
--演示：在VResponse中插入一条数据（注意业务逻辑正确性），却不能在视图中显示
INSERT V_VResponse (Content, ResponseAuthorId, ProblemId, CreateTime)
 VALUES(N'那几款',1,1,'2019/8/7');
 SELECT * FROM V_VResponse ;
--修改VResponse，让其能避免上述情形
--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
GO
CREATE VIEW V_VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
WITH SCHEMABINDING
AS
SELECT P.ID ,P.TITLE ,P.Reward , COUNT_BIG (*) AS Amount FROM
dbo.KeywordProblem KP 
JOIN dbo.PROBLEM P ON KP.ProblemID =P.ID 
GROUP BY P.ID ,P.TITLE ,P.Reward 

go

DROP VIEW V_VProblemKeyword ;
--能反映求助的标题、使用关键字数量和悬赏
--在ProblemId上有一个唯一聚集索引

CREATE UNIQUE CLUSTERED INDEX IX_V_VProblemKeyword_ProblemId ON dbo.V_VProblemKeyword(ProblemId);

--在ProblemReward上有一个非聚集索引
CREATE  INDEX IX_V_VProblemKeyword_ProblemReward ON dbo.V_VProblemKeyword(ProblemReward);


--在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化
--会变化




最后写法总结：
1、认真看题目和需求，不要乱去理解 很重要！！！！！！
2、时间之后说的是时间以后的时间，就是大于当前的这个时间
3、凡是涉及到作者ID、用户ID等一切与人之间的ID，都和用户有关，也就是user表