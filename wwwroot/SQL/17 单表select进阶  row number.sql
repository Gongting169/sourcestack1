

--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，然后用新表ProblemStatus存放上述数据
SELECT * FROM PROBLEM

SELECT AUTHOR ,MAX(Reward)  AS MAX  ,MIN(Reward) AS MIN ,  AVG(Reward)  AS AVG  INTO PROBLEM1  FROM PROBLEM  GROUP BY AUTHOR ;

SELECT  DISTINCT AUTHOR,
MAX(Reward) OVER(PARTITION BY AUTHOR ) AS MAX  ,
MIN(Reward) OVER(PARTITION BY AUTHOR  ) AS MIN ,  
AVG(Reward) OVER(PARTITION BY AUTHOR   ) AS AVG 
--INTO ProblemStatus
FROM PROBLEM

--使用CASE...WHEN，颠倒Problem中的NeedRemote（以前是1的，现在变成0；以前是0的，现在变成1）
SELECT * FROM PROBLEM
 SELECT * ,
 CASE   
 WHEN NeedRemoteHelp=1 then 0
 WHEN  NeedRemoteHelp=0 then 1
 --WHEN  NeedRemoteHelp=null then 1 OR ELSE 1  这句话相当于NeedRemoteHelp 是null的时候 输出的结果就是1   ELSE 1 条件都不满足的话，就是不是0和1的话，那么其他的情况，我的值就是只为1.
 END FROM PROBLEM

 --[ID],[NeedRemoteHelp],AUTHOR ,
--使用CASE...WHEN，用一条SQL语句，完成SQL入门-7：函数中第4题第3小题


