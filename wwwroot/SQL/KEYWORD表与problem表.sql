
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
 [Title] NVARCHAR(400),
 [DateTime] DATETIME,
 [Content] NTEXT,
 [KeyWord] NVARCHAR(100),
 [USETIME] INT,
 [Reward] INT,
 [Response] INT,
 [Inculde] NTEXT
);
SELECT * FROM PROBLEM ;

