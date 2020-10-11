
--发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
--将该求助的作者改成另外一个用户
--删除该用户

--SELECT * FROM PROBLEM ; 从表，要先设置主键不为空 not null，然后再设置一个主键约束 
--SELECT * FROM [USER] ;  主表要建立一个problemID列， 然后在创建两个约束。  一个用户可以有多个求助，但是一个求助只能找到一个用户

ALTER TABLE PROBLEM
ADD [ProbelmUserID] INT  CONSTRAINT FK_PROBLEM_ProbelmUserID  FOREIGN KEY  REFERENCES [USER]([ID]);

SELECT * FROM [USER] ;
SELECT * FROM PROBLEM ;

UPDATE PROBLEM SET ProbelmUserID = 1 WHERE  ID = 3;

UPDATE PROBLEM SET ProbelmUserID = 1 WHERE  ID = 6;

UPDATE PROBLEM SET ProbelmUserID = 3 WHERE  ID = 5;

UPDATE PROBLEM SET ProbelmUserID = 3 WHERE  ID = 2;

UPDATE PROBLEM SET ProbelmUserID = 5 WHERE  ID = 4;

UPDATE PROBLEM SET ProbelmUserID = 5 WHERE  ID = 1;

 --发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
INSERT [USER]  VALUES(N'管他的呢',1235,6);
INSERT PROBLEM  VALUES(7,N'寻求Java语言',N'十点半空间',1,16,'2019/8/27',N'小黄',6);

SELECT * FROM [USER] ;
SELECT * FROM PROBLEM ;
--将该求助的作者改成另外一个用户
BEGIN TRAN 
 UPDATE [PROBLEM]  SET AUTHOR  = N'17bang计算' WHERE ID =5;
  ROLLBACK;
--删除该用户
BEGIN TRAN
 DELETE PROBLEM   WHERE ProbelmUserID =3;
  ROLLBACK;

  BEGIN TRAN
 DELETE [USER] WHERE ID = 1;    --有点问题： 就是删除主表能行，删除从表就不行 与


