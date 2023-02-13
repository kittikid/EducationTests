	/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[id_user]
      ,[id_test]
      ,[id_question]
      ,[id_answer]
  FROM [EducationTests].[dbo].[user_tests]