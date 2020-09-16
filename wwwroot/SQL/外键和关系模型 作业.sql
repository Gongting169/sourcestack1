
CREATE TABLE [dbo].Profile
(
  [ID] INT  NOT NULL,
  [HEADPORTRAIT]  VARCHAR(200),
  [GENDER] BIT,
  [BIRTH] DATETIME,
  [KEYWORD] NVARCHAR(200),
  [SELFDESCRIPTION] NTEXT,
);
  ALTER TABLE [USER]
  ADD CONSTRAINT PK_ID  PRIMARY KEY(ID);

 INSERT Profile  VALUES(7,'t01f48cfa8ce0661ed0.jpg',0,N'我来自遥远的某个地方。。。。');
 INSERT Profile  VALUES(8,'t01ca9443fb7c45ae95.jpg',0,N'史蒂夫VN等你拿据欧。。。。');
 INSERT Profile  VALUES(9,'t01532249c0f4783edf.jpg',1,N'那你可能需整理的深V看。。。。');

 INSERT [USER]([ID] , BIRTHDAY ,KEYWORD)  VALUES(7,'2020/9/1',N'法律');
 INSERT [USER]([ID] ,BIRTHDAY ,KEYWORD)  VALUES(8,'2020/3/6',N'编程');
 INSERT [USER]([ID] ,BIRTHDAY ,KEYWORD)  VALUES(9,'2020/8/25',N'拖欠工资');

 ALTER TABLE Profile
 ADD CONSTRAINT FK_USER_ID
 FOREIGN KEY (USERID)
 REFERENCES [USER](ID);

 BEGIN TRAN
 UPDATE Profile SET USERID =9 WHERE ID = 9;

 SELECT 
    P.[GENDER],                     -- Student表的Name
    U.BIRTHDAY,   -- City表的FromProvince，还给一个列别名Province
    U.KEYWORD              -- City表的FromCity，还给一个列别名City
FROM Profile P      
JOIN [USER] U                   
ON P.USERID = U.Id  

SELECT * FROM [USER];
SELECT * FROM [Profile];

-- 用户资料，新建用户资料（Profile）表，和User形成1:1关联（有无约束？）。用SQL语句演示：
--新建一个填写了用户资料的注册用户    增加：先是从表增加然后再是主表
INSERT Profile ([ID] ,HEADPORTRAIT ,GENDER ,SELFDESCRIPTION ,USERID)  VALUES(10,'t011cf2edd001fe80a4.jpg',1,N'还上班v客句女款金币',10);
INSERT [USER]([ID] ,BIRTHDAY ,KEYWORD )  VALUES(10,'2020/9/4',N'ASP.NET');
--通过Id查找获得某注册用户及其用户资料
    SELECT 
    P.HEADPORTRAIT,
    P.GENDER,
    P.SELFDESCRIPTION,
    U.BIRTHDAY,
    U.KEYWORD
    FROM Profile P
    JOIN [USER] U
    ON P.[USERID]=U.ID ;
--删除某个Id的注册用户
DELETE Profile WHERE ID = 10;
DELETE [USER] WHERE ID = 10;

--帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分

CREATE TABLE [dbo].Credit
(
[ID] INT,
[USERNAME] NVARCHAR(500),
[DATETIME] DATETIME,
[CommunityActivity] NVARCHAR(500),
[Reward]  INT,
[Remark]  NVARCHAR(800),
);

SELECT * FROM Credit ;

INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(1,N'陈大哥','2020/9/1',N'邀请注册',10,N'别人使用了你的邀请码完成注册' );
INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(2,N'王大哥','2019/11/11',N'首次求助',20,N'只能是第一次发布求助，并且审核通过，才能获得点数奖励' );
INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(3,N'李大哥','2017/12/12',N'文章评论被精选',10,N'由文章作者精选' );
INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(4,N'周大哥','2019/12/3',N'加入目标',5,N'只要加入，就可以获得' );
INSERT Credit([ID] ,[USERNAME],DATETIME,CommunityActivity ,Reward ,Remark  ) VALUES(5,N'田大哥','2020/8/7',N'意见建议','',N'别人使用了你的邀请码完成注册' );








