
CREATE TABLE [dbo].Profile
(
  [ID] INT  NOT NULL PRIMARY KEY ,
  [PHOTO]  VARCHAR(200),
  [GENDER] BIT,
  [BIRTH] DATETIME,
  [KEYWORD] NVARCHAR(200),
  [SELFDESCRIPTION] NTEXT,
  [UserId] INT CONSTRAINT FK_USER_ID
 FOREIGN KEY (USERID)
 REFERENCES [USER](ID)
);

SELECT * FROM [USER] ;
select * FROM  Profile;

 INSERT Profile  VALUES(1,'t01f48cfa8ce0661ed0.jpg',0,'2018/12/1',N'编程',N'我来自遥远的某个地方。。。。',1) ;
 INSERT Profile  VALUES(2,'t01ca9443fb7c45ae95.jpg',1,'2020/6/5',N'拖欠工资',N'史蒂夫VN等你拿据欧。。。。',2);
 INSERT Profile  VALUES(3,'t01532249c0f4783edf.jpg',1,'2020/9/1',N'流程',N'那你可能需整理的深V看。。。。',3);
 INSERT Profile  VALUES(4,'t01532249c0f4783edf.jpg',0,'2020/8/7',N'ASP.NET',N'那你可能需整理的深V看。。。。',4);

---- 用户资料，新建用户资料（Profile）表，和User形成1:1关联（有无约束？）。用SQL语句演示：
----新建一个填写了用户资料的注册用户    增加：先是从表增加然后再是主表
Firststep:  INSERT [USER]  VALUES(N'管理员吧',3698,5);
Secondstep:  INSERT Profile  VALUES(5,'t011cf2edd001fe80a4.jpg',1,'2018/8/8',N'法院',N'还上班v客句女款金币',5);
----通过Id查找获得某注册用户及其用户资料
    SELECT *
    FROM Profile P
    JOIN [USER] U
    ON P.[USERID]=U.ID
    WHERE U.ID =1;
----删除某个Id的注册用户
 BEGIN TRAN
DELETE Profile WHERE [UserId] = 1;
DELETE [USER] WHERE ID =1;
GO
 ROLLBACK;

 GO
 BEGIN TRAN 
UPDATE Profile  SET [UserId] = NULL WHERE [UserId] = 1;
  DELETE [USER] WHERE ID = 1;

----帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分   Credit(积分)表和user（用户）表之间的关系是多对一的关系：

CREATE TABLE [dbo].Credit
(
[ID] INT  NOT  NULL  ,
[USERNAME] NVARCHAR(500),
[DATETIME] DATETIME,
[CommunityActivity] NVARCHAR(500),
[Reward]  INT,
[Remark]  NVARCHAR(800),
); 

--ALTER TABLE Credit
--ADD CONSTRAINT PK_Credit_Id  Primary Key([ID]);

--ALTER TABLE  [USER]
--ADD [CreditId] INT CONSTRAINT FK_USER_CreditId FOREIGN KEY (CreditId) REFERENCES CreditId

 

--SELECT * FROM Credit ;

--INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(1,N'陈大哥','2020/9/1',N'邀请注册',10,N'别人使用了你的邀请码完成注册' );
--INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(2,N'王大哥','2019/11/11',N'首次求助',20,N'只能是第一次发布求助，并且审核通过，才能获得点数奖励' );
--INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(3,N'李大哥','2017/12/12',N'文章评论被精选',10,N'由文章作者精选' );
--INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(4,N'周大哥','2019/12/3',N'加入目标',5,N'只要加入，就可以获得' );
--INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(5,N'田大哥','2020/8/7',N'意见建议','',N'别人使用了你的邀请码完成注册' );

DROP TABLE Credit ;