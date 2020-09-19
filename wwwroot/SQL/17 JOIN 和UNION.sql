  
  SELECT * FROM PROBLEM ;
  SELECT * FROM [USER] ;


--联表查出求助的标题和作者用户名
SELECT 
  P.[ID],
  p.Title,
  U.[USERNAME]
  FROM PROBLEM P JOIN [USER] U
  ON  U.PROBLEMID = P.ID;

   SELECT * FROM [USER]  ;
  SELECT *  FROM  PROBLEM ;

--查找并删除从未发布过求助的用户
--DELETE   
SELECT *
  FROM PROBLEM P JOIN [USER] U
  ON  U.PROBLEMID = P.ID;
--WHERE [USERNAME] IS NULL

--DELETE Student
--FROM [USER] U JOIN Problem P  ON U.PoblemId = P.Id
--WHERE s.FromProvince = N'重庆'

--用一句SELECT显示出用户和他的邀请人用户名