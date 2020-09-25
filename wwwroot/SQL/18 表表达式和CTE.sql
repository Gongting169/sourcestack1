
--分别使用派生表和CTE，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：

--一起帮每月各发布了求助多少篇
SELECT * FROM PROBLEM ;

SELECT * FROM 
(SELECT PublishTime,COUNT(Title) AS COUNT  ,MONTH(PublishTime) 
AS MONTH FROM PROBLEM  GROUP BY PublishTime ) SP   
--依照下面的需求就不能使用表子查询 ，只能够使用CTE 公用表表达式。



--每月发布的求助中，悬赏最多的3篇



--每个作者，每月发布的，悬赏最多的3篇
--分别按发布时间和悬赏数量进行分页查询的结果



