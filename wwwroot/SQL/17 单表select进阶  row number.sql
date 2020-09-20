

--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，然后用新表ProblemStatus存放上述数据
SELECT * FROM PROBLEM 

SELECT AUTHOR , AVG(Reward) OVER(PARTITION BY REWARD) AS [COUNT] FROM PROBLEM GROUP BY AUTHOR 

SELECT
MAX(Reward) OVER(PARTITION BY AUTHOR ) AS MAX  ,
MIN(Reward) OVER(PARTITION BY AUTHOR  ) AS MIN ,  
AVG(Reward) OVER(PARTITION BY AUTHOR   ) AS AVG ,
AUTHOR,Reward 
FROM PROBLEM GROUP BY AUTHOR ,Reward 


--使用CASE...WHEN，颠倒Problem中的NeedRemote（以前是1的，现在变成0；以前是0的，现在变成1）
--使用CASE...WHEN，用一条SQL语句，完成SQL入门-7：函数中第4题第3小题


