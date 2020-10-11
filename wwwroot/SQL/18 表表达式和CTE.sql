
--分别使用派生表和CTE，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：

--一起帮每月各发布了求助多少篇  
--SELECT * FROM 
--(
SELECT  COUNT(Title) AS MOUNT,
MONTH(PublishTime) AS MONTH ,
YEAR(PublishTime) AS YEAR
FROM PROBLEM 
GROUP BY MONTH(PublishTime),YEAR(PublishTime);
--)
SELECT * FROM PROBLEM ;

SELECT MONTH ,YEAR , COUNT(Title) FROM 
( 
SELECT *, 
MONTH(PublishTime) AS MONTH ,
YEAR(PublishTime) AS YEAR
FROM PROBLEM 
) ymp
GROUP BY ymp.MONTH ,ymp.YEAR ;

WITH PM    --用CTE写
AS
(SELECT *, MONTH(PublishTime) AS MONTH ,
YEAR(PublishTime) AS YEAR  FROM PROBLEM 
) 
SELECT MONTH , YEAR , COUNT(*) FROM PM  
GROUP BY  PM.MONTH , PM.YEAR ;

--每月发布的求助中，悬赏最多的3篇  
--第一种：
SELECT * FROM (
SELECT ROW_NUMBER()
OVER( PARTITION BY MONTH(PublishTime),
YEAR(PublishTime)  
ORDER BY Reward) AS GID,Reward 
FROM PROBLEM 
) ymp
WHERE ymp.GID <= 3;


 --第二种：
 WITH ymp
 AS 
 (SELECT MONTH(PublishTime) AS [MONTH] ,
 YEAR(PublishTime) AS [YEAR] FROM PROBLEM )
 SELECT MONTH ,YEAR ,COUNT(*) AS MOUNT FROM ymp GROUP BY ymp.[MONTH]  ,ymp.[YEAR]  ;


--每个作者，每月发布的，悬赏最多的3篇
SELECT *  FROM (
    SELECT *, ROW_NUMBER()
    OVER( PARTITION BY Author
    ORDER BY Reward DESC) AS GID
FROM
(       SELECT Author, Reward,
        MONTH(PublishTime) AS MONTH ,
        YEAR(PublishTime) AS YEAR  
        FROM PROBLEM 
) ymp )p 
WHERE p.GID <= 3 ;

SELECT * FROM PROBLEM ;

--分别按发布时间和悬赏数量进行分页查询的结果
SELECT * FROM (
 SELECT ROW_NUMBER() OVER( ORDER BY PublishTime) rn,*
 FROM PROBLEM  
) PM
WHERE PM.rn BETWEEN 4 AND 6 ; --用pageindex A 和 page size B  来确定第几页第几行   （A-1）*B +1


SELECT * FROM (
         SELECT ROW_NUMBER() OVER( ORDER BY Reward) rn ,*
        FROM PROBLEM  
) PM
 WHERE PM.rn BETWEEN 5 AND 8



    SELECT * FROM PROBLEM  ORDER BY PublishTime
    OFFSET 6 ROWS                           
    FETCH NEXT 3 ROWS ONLY   
GO

SELECT *  FROM PROBLEM ORDER BY  Reward 
OFFSET 2 ROWS                            
FETCH NEXT 3 ROWS ONLY   
   


最后的写法总结：
1、GROUP BY 后面可以跟函数（MONTH(PublishTime)）,group by 后面的列要和select后面的列数量一一对应，然后在可以使用聚合函数成为一个新的计算列
2、GID是在表的内部进行使用，再往外部使用之后，where子句不能用别名来作为引导的条件， 就是要在表内部使用的GID,才能在where句子后面做引导条件，
在外部就是相当于一个别名，在内部的话，就是一个计算列
3、派生表的本质是有一个select查询语句可以当做另一个查询语句select的子表 派生表是有一个查询会生成一个查询结果，另一个查询会利用这个查询结果在进行一次查询 
如： select YEAR ，MONTH，COUNT(Title) FROM
( SELECT MONTH(PublishTime) AS MONTH, YEAR(PublishTime)AS YEAR  FROM PROBLEM ) ymp  GROUP BY  ymp.YEAR, ymp.MONTH;
4、我们写的sql语句要符合需求，符合题目的要求 
5、分组的对象要明确，一定要按照题目的要求来进行分组，分组是分组列里面的值相同，就会成为同一个数据
6、派生表：是用一个select * from 后面接一个select语句的，这个语句被当做是一个表或是一个查询结果，select * from 后面再接这个表，然后后面再跟where条件语句。
如： select MONTH ,YEAR ,COUNT(*) from 
( select MONTH（PublishTime）AS MONTH, YEAR(PublishTime) AS YEAR FROM PROBLEM )ymp  
GROUP BY ymp.MONTH ,ymp.YEAR ;
7、CTE：是先用WITH加表名 AS  再接一个select语句，这个select语句被当做with后面表的结果，也可以被认为是一个表， 在下一个select语句会用到这个表的结果，或者说是会用到这个表
如：with pm       PM 代表的是as后面跟的第一个select语句的查询结果。
as ( select MONTH(PublishTime) as month ,YEAR(PublishTime) AS YEAR FROM PROBLEM )
SELECT MONTH ,YEAR ,COUNT(*) AS MOUNT FROM PM GROUP MONTH ,YEAR;
8、使用表表达式是为了能够使用他的别名 
9、如果GID像平常写row_number 函数一样的写法，select row_number。。。。。 from problem  problem后面跟的where子句后面不能使用别名，使用时会报错，跑不起来
只有把窗口函数语句当做成一个表来使用时，也就是把GID当做成一个列，后面接个where子句gid的条件判断，这样才行。

