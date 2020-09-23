
SELECT * FROM PROBLEM;
SELECT * FROM [USER] ;

--找到从未成为邀请人的用户（当心NULL值）
SELECT *  FROM [USER]   WHERE ID NOT  IN ( SELECT INVITEDBY FROM [USER] );  

SELECT * FROM [USER] U1 LEFT JOIN [USER] U2 ON U1.ID = U2.INVITEDBY ; 
--解法：像这样的题：分为两步走，第一步：找到用户 select username from user 
--第二步：找到从未成为邀请人的用户，不好理解，先找到称为邀请人的用户，看表就可以了， select invitedby from user
--第三步：建立联系：一般都通过ID来进行联系，唯一标识一行数据的列，user表的ID列的值没有invitedby列的值里面，就是没有称为邀请人的用户

--查出这些文章：其作者总共只发布过这一篇文章
--SELECT * FROM  PROBLEM WHERE 

SELECT TITLE ,AUTHOR FROM PROBLEM  GROUP BY AUTHOR 







SELECT * FROM Article ;
SELECT * FROM PROBLEM;

   SELECT*FROM problem WHERE AuthorId IN (
   
   SELECT AuthorId FROM problem
   GROUP BY AuthorId
   HAVING COUNT(title)=1)

--SELECT AUTHOR  ,COUNT ([ID]) AS COUNT  FROM Article  GROUP BY AUTHOR  -- 这是以artice建立的查询语句

--为求助添加一个发布时间（PublishTime），查找每个作者最近发布的一篇求助
SELECT  ROW_NUMBER()  
OVER (PARTITION BY AUTHOR 
ORDER BY PublishTime DESC ) 
AS GID ,
[ID],AUTHOR,PublishTime 
FROM PROBLEM    

--第二种：
 
  SELECT*FROM problem
    WHERE publishdatetime IN (
    SELECT MAX(publishdatetime) FROM problem
    GROUP BY AuthorId
    )
 --第三种:
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
UPDATE PROBLEM SET PublishTime = '2019/8/7' WHERE ID =5;
UPDATE PROBLEM SET PublishTime = '2020/11/5' WHERE ID =2;

--查出每个作者悬赏最多的3篇求助  
 SELECT  * FROM   PROBLEM WHERE   ID IN (SELECT AUTHOR  , MAX(REWARD) AS GID FROM PROBLEM  GROUP BY  AUTHOR  HAVING COUNT(TITLE)>1 );

   SELECT *FROM problem WHERE ID NOT IN (

     SELECT COUNT(title), MAX(reward) ,AuthorId  FROM problem 
     group by AuthorId
)
--删除悬赏相同的求助（只要相同的全部删除一个不留)
 DELETE problem WHERE ID IN(
       SELECT reward FROM problem
       GROUP BY reward
       HAVING COUNT(reward)>1
       )
       ROLLBACK

--删除每个作者悬赏最低的求助

   DELETE problem WHERE ID IN(
    SELECT ID FROM problem OPB

    WHERE reward =(
    SELECT MIN(reward) FROM problem IPB
    WHERE OPB.AuthorId=IPB.AuthorId
    )
    )
    ROLLBACK
