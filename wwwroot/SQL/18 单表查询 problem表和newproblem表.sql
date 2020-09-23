
--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作： 
--查找出Author为“飞哥”的、Reward最多的3条求助 
--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序 
--查找并统计出每个作者的：求助数量、悬赏总金额和平均值 
--找出平均悬赏值少于10的作者并按平均值从小到大排序
--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉） 
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中 

ALTER TABLE PROBLEM
ADD AUTHOR NVARCHAR(50);

SELECT * FROM PROBLEM ;
 UPDATE   PROBLEM  SET AUTHOR = N'飞哥'  WHERE ID = 1;
 UPDATE   PROBLEM  SET AUTHOR = N'飞哥' WHERE ID = 2;
 UPDATE   PROBLEM  SET AUTHOR = N'小黄'  WHERE ID = 3;
 UPDATE   PROBLEM  SET AUTHOR = N'小天'  WHERE ID = 4;
 UPDATE   PROBLEM  SET AUTHOR = N'小天'  WHERE ID = 5;
 UPDATE   PROBLEM  SET AUTHOR = N'小李'  WHERE ID = 6;


--查找出Author为“飞哥”的、Reward最多的3条求助 
SELECT TOP 3 *  FROM [PROBLEM] WHERE AUTHOR=N'飞哥' ORDER BY REWARD DESC;

--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序 
SELECT AUTHOR ,REWARD FROM PROBLEM  ORDER BY AUTHOR, REWARD DESC;

--查找并统计出每个作者的：求助数量、悬赏总金额和平均值 
SELECT AUTHOR,SUM(REWARD),AVG(REWARD)  AS [COUNT] FROM PROBLEM
GROUP BY AUTHOR ;

--找出平均悬赏值少于10的作者并按平均值从小到大排序
SELECT AUTHOR , AVG(REWARD) AS [COUNT]  FROM PROBLEM  
GROUP BY AUTHOR   HAVING AVG (REWARD) < 10   ORDER BY AVG (REWARD) ASC ;

SELECT * FROM NEWPROBLEM ;
SELECT * FROM PROBLEM ;


--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem （把原Problem里Author或Reward为NULL值的数据删掉） 
SELECT *  INTO NEWPROBLEM  FROM PROBLEM  WHERE  AUTHOR IS NOT NULL AND  REWARD  IS NOT NULL;

--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中 
BEGIN TRAN 
INSERT  NEWPROBLEM 
SELECT [ID] ,Title,PublishDateTime,Content,[AUTHOR] ,[REWARD] ,[NeedRemoteHelp]  From PROBLEM WHERE  REWARD IS  NULL; -- 由于没有NULL 所以 这里没有执行

ROLLBACK;

