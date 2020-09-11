

CREATE TABLE [dbo].[USER]
(
[USERNAME] NVARCHAR(500), 
[PASSWORD] VARCHAR(200) ,
);


--观察“一起帮”的注册和发布求助功能，试着建立表User：包含UserName（用户名），Password（密码）…… 
--为User表添加一列：邀请人（InvitedBy），类型为INT 
--将InvitedBy类型修改为NVARCHAR(10) 
--删除列InvitedBy
ALTER TABLE [USER]
ALTER COLUMN InvitedBy NVARCHAR(10);

ALTER TABLE [USER]
DROP COLUMN InvitedBy;

--ADD InvitedBy INT;

 SELECT * FROM [USER];

 
 INSERT [USER]([[USERNAME] ,[PASSWORD]) VALUES(N'小明',1234); 

 INSERT [USER]([USERNAME] ) VALUES(N''); 

 INSERT [USER]([USERNAME] ,[PASSWORD] ) VALUES(N'小李',''); 

 INSERT [USER]([USERNAME] ) VALUES(N'管理员'); 

 INSERT [USER]([USERNAME] ,[PASSWORD]  ) VALUES(N'17bang'); 

 INSERT [USER]([USERNAME] ,[PASSWORD] ) VALUES(N'管理员2',5678); 

-- 查找没有录入密码的用户 
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
