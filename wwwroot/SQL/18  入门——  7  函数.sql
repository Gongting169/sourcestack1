
--利用循环，打印如下所示的等腰三角形：
DECLARE @I INT ,@J INT ,@s int,@Z CHAR(50)
SET @I = 0
SET @J= 7
SET @s=0
SET @Z = ''
WHILE @I < =4
BEGIN 
SET @I =@I +1
SET @J =@J -1
SET @s = @s +1
--SET @Z = SPACE(4-@I)+REPLICATE(2*@s-1,2*@i-1)
SET @Z = REPLICATE(' ',4-@I )+REPLICATE(2*@s-1,2*@i-1)
PRINT @z
END
GO


DECLARE @b INT
SET @b=1
WHILE @b <= 4
BEGIN 
PRINT SPACE(4-@b)+REPLICATE(2*@b-1,2*@b-1)
SET @b = @b + 1
END

--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
GO
CREATE FUNCTION dbo.GetBigger( @a INT,  @b INT)
RETURNS INT
  AS 
BEGIN 
   DECLARE @max INT;
    IF (@a > @b) 
   
        SET @max = @a    
    ELSE    
        SET @max = @b 
       
RETURN @max;
END
GO

SELECT dbo.GetBigger(6,10);
--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助
GO
CREATE FUNCTION GetLatestPublish(@n INT)
RETURNS TABLE
RETURN   SELECT TOP(@n) * FROM  PROBLEM ORDER BY PublishTime  DESC 
GO
SELECT * FROM dbo.GetLatestPublish(20)

--创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。
GO
CREATE  FUNCTION [GetByReward](@n INT ,@asc BIT)
RETURNS @t TABLE ([AUTHOR] NVARCHAR(50) )
AS
BEGIN 
  IF (@asc = 1)
         BEGIN 
     INSERT  INTO  @t 
     SELECT TOP(@n)AUTHOR FROM PROBLEM  ORDER BY Reward ASC  
         END
 ELSE
         BEGIN 
      INSERT  INTO  @t 
     SELECT TOP(@n)AUTHOR  FROM PROBLEM  ORDER BY Reward DESC
        END
  RETURN ;
END
GO
drop function GetByReward
SELECT * FROM dbo.[GetByReward](3,0);
--在表TProblem中： 
--找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
SELECT * FROM PROBLEM ;
WITH DP
AS (SELECT ID,DATENAME(WEEKDAY  , CreateTime) 
AS WEEKEND   FROM PROBLEM)
 SELECT ID ,WEEKEND    FROM DP  WHERE DP.WEEKEND = 'SUNDAY' OR DP.WEEKEND = 'SATURDAY' ;
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
SELECT AUTHOR,ROUND(AVG(Reward),2)  FROM PROBLEM  GROUP BY AUTHOR 
ALTER TABLE PROBLEM
ALTER COLUMN Reward  Decimal
--有一些标题以test、[test]或者Test-开头的求助，找到他们并把这些前缀都换成大写
SELECT * FROM PROBLEM ;
BEGIN TRAN 
UPDATE PROBLEM  SET TITLE =  UPPER(N'test') + SUBSTRING (TITLE ,5,30) WHERE title LIKE N'test%'  ;
begin tran
UPDATE PROBLEM  SET TITLE =  UPPER(N'[test]')+ SUBSTRING (TITLE,7,30 )  WHERE  TITLE LIKE N'_test_%';
UPDATE PROBLEM  SET TITLE =   UPPER(N'Test')+ SUBSTRING (TITLE,5,30 ) WHERE  TITLE LIKE N'Test%';

BEGIN TRAN 
SELECT REPLACE(TITLE,N'test',N'TEST') FROM PROBLEM WHERE   title LIKE N'test%' 
SELECT REPLACE(TITLE,N'Test-',N'TEST-') FROM PROBLEM WHERE   title LIKE N'Test-%' 
SELECT REPLACE(TITLE,N'[test]',N'[TEST]') FROM PROBLEM WHERE   title LIKE N'[test]%' 


 ROLLBACK;


 




 --最后写法总结:
 --1、在一个新的计算列里面，可以用公用表达式来取出其中的几个值，但是计算列里面的值必须要用一定的符号进行标注，让SqlServer认为他不是一个变量，
 --是一个常量、固定的值，比如说文字类型计算出来的列，可以用N''加上列里面的值，就可以在where子句里用条件把它写出来，也可以用ID来做，但是比较麻烦，不建议。
 --2、一些知识点是可以相互叠加的，就是一些其他学过的知识点，可以嵌套进去，比如：if else子句里面 就可以在声明一个变量，然后用来比较大小
 --3、认真看清楚题目的要求，不要乱去做
 --4、查文档的话，建议去国外的网站去查，如果要搜索某个小问题，可以用国内的网站来查比较快。
 --5、多思考一下，要多运用学习过的知识，把这些结合起来用，不要单一的思维在哪里思考，其实也没有思考出来一些啥东西，你想要得到的是什么东西，
 --你现在写出来的又是什么样子，差一点什么样的知识结构才能达到想要的样式，就得去试一下。 而不是在哪里思考半天，啥结果也没有出来，浪费时间和精力
 --6、注意细节和一些小问题，语句的句型正不正确，不要创新，报错之后要去找一下自己的语法写对了没有，该注意的小问题注意到了没有，就是报错了之后，查看自己写的有没有问题，多检查几遍。
 --7、多注意一下知识结构,不要漏掉。







