
SELECT * FROM PROBLEM;
SELECT * FROM [USER] ;

--找到从未成为邀请人的用户（当心NULL值）
SELECT *  FROM [USER]   WHERE ID NOT  IN ( SELECT INVITEDBY FROM [USER] );  
--解法：像这样的题：分为两步走，第一步：找到用户 select username from user 
--第二步：找到从未成为邀请人的用户，不好理解，先找到称为邀请人的用户，看表就可以了， select invitedby from user
--第三步：建立联系：一般都通过ID来进行联系，唯一标识一行数据的列，user表的ID列的值没有invitedby列的值里面，就是没有称为邀请人的用户

--查出这些文章：其作者总共只发布过这一篇文章
SELECT * FROM Article ;
SELECT * FROM PROBLEM;

SELECT AUTHOR  ,COUNT ([ID]) AS COUNT  FROM Article  GROUP BY AUTHOR 

--为求助添加一个发布时间（PublishTime），查找每个作者最近发布的一篇求助
SELECT  ROW_NUMBER()  
OVER (PARTITION BY AUTHOR 
ORDER BY PublishTime DESC ) 
AS GID ,
[ID],AUTHOR,PublishTime 
FROM PROBLEM    

--第二种：
    SELECT [ID] ,PublishTime, AUTHOR  FROM  PROBLEM    ORDER BY PublishTime  DESC

 --第三种:
 --SELECT [ID],[AUTHOR],[PublishTime],
 --CASE 
 --WHEN 



 SELECT 
 MAX(PublishTime) OVER (PARTITION BY AUTHOR ) AS  BEST 
  ,AUTHOR,PublishTime FROM PROBLEM  GROUP BY AUTHOR ,PublishTime; 




SELECT * FROM PROBLEM;
ALTER TABLE PROBLEM
ADD PublishTime DATETIME ;

UPDATE PROBLEM SET PublishTime = '2019/12/12' WHERE ID =1;
UPDATE PROBLEM SET PublishTime = '2020/4/28' WHERE ID =3;
UPDATE PROBLEM SET PublishTime = '2020/1/17' WHERE ID =4;
UPDATE PROBLEM SET PublishTime = '2019/7/6' WHERE ID =6;
UPDATE PROBLEM SET PublishTime = '2020/3/2' WHERE ID =7;
UPDATE PROBLEM SET PublishTime = '2019/8/7' WHERE ID =8;

 

--查出每个作者悬赏最多的3篇求助
--删除悬赏相同的求助（只要相同的全部删除一个不留  
--删除每个作者悬赏最低的求助


DROP  DATABASE [17bang] ;

