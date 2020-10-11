
--编写存储过程模拟“一起帮用户注册”的过程，包含以下逻辑：
--检查用户名是否重复。如果重复，返回错误代码：1
--检查用户名密码是否符合“长度不小于4位”的要求。如果不符合，返回错误代码：2
--如果有邀请人：
--检查邀请人是否存在，如果不存在，返回错误代码：10
--检查邀请码是否正确，如果邀请码不正确，返回错误代码：11
--将用户名、密码和邀请人存入数据库（Register）
--给邀请人增加10个帮帮点积分
--通知邀请人（在Message表中生成一条数据）某人使用了他作为邀请人。
CREATE PROCEDURE UserRegister
@USERNAME NVARCHAR(50),
@PASSWORD VARCHAR(50),
@INVITEDBYUSERNAME  INT,
@InvitedCode INT
AS
IF (EXISTS(SELECT USERNAME FROM [USER] WHERE @USERNAME != USERNAME ) ) 
BEGIN 
 IF (LEN(@USERNAME)<4 OR LEN(@PASSWORD)< 4) 
      BEGIN 
        IF ()
        BEGIN 

        END
        ELSE
        BEGIN 

        END

      END
      ELSE 
      BEGIN 
             RETURN(2)
      END
END
ELSE 
BEGIN      
  RETURN( 1)   
END





CREATE TABLE Message
(
ID  INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FromUser NVARCHAR(500),
ToUser NVARCHAR(500),
UrgentLevel INT ,
Kind NVARCHAR(20),
HasRead NVARCHAR(50),
IsDelete BIT,
Content NARCHAR(MAX)
);

--确保Problem有“发布时间（PublishTime）”和“最后更新时间（LatestUpdateTime）”两列，创建触发器实现：
--更新一条数据，自动将当前时间计入该行数据的LatestUpdateTime
GO
CREATE TRIGGER TRI_LatestUpdateTime
ON PROBLEM
FOR
UPDATE
AS
UPDATE PROBLEM SET LatestUpdateTime= GETDATE() FROM inserted I JOIN PROBLEM P  ON P.ID=I.ID
GO
--插入一条数据，自动将当前时间计入该行数据的PublishTime（提示：INSERTED伪表）
GO
CREATE TRIGGER TR_PublishTime
ON PROBLEM
FOR
INSERT
AS
UPDATE PROBLEM SET PublishTime= GETDATE() WHERE ID =@@IDENTITY ;
GO




--触发器的语句是：
--CREATE/ALTER TRIGGER TRIGGER_NAME
--ON 表名/视图
--for/after/instead of
--insert / update /delete
--AS 
--SQL语句
--最后写法总结：
--1、如果思路不清晰，先把想出来的思路写在纸上，然后根据需求慢慢的捋捋，然后检查结果。
--2、注意知识结构，计算机大部分的功能都可以依靠如果怎么样，然后结果就怎么样来写，有if else case when then 两种
--3、有时候还要把书写的环境顺序写进去，也就是把性能考虑进去，还有当插入、更改两条数据的时候，一定要用事务，trycatch 来嵌套，防止出现其他的意外情况
--更改全表的时候，一定不要写 update表 set money+=10，千万不要这样写！千万不要这样写！千万不要这样写！ 否则的话，你一定会被挨打的
--4、写不出来，先把思路写下来，慢慢的捋清楚，然后在写，结合以前学过的一些知识，并成功的完成书写
--5、IF ELSE 条件语句，if后面要跟判断语句，也就是比较大小或等的判断，也可以用if exists 就怎么样，否则就怎么样来写，切记，谨记。
--6、对于一个自增列来说，如何查找到他上一行的ID，可以用@@identity 把它打印出来
--7、SQL 作业还有一个存储过程没有写 重要！！！！！！！！！！！！！！
--5、希望引此为戒，不要在出现像存储过程和触发器的问题了,

