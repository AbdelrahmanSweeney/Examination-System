/*INSERT QUESTION TABLE  */
CREATE PROCEDURE 
	InsertExam 
      @exam_grade float= NULL,
      @exam_time float= NULL,
      @cr_id int= NULL
AS
	BEGIN
		DECLARE @InsertStatment nvarchar(300)		
		SET @InsertStatment = 'INSERT INTO  Exam(exam_grade, exam_time, cr_id) VALUES '

		SET @InsertStatment  = CONCAT(@InsertStatment, '(@exam_grade,', '@exam_time,', '@cr_id)')			
	
		EXECUTE sp_executesql @InsertStatment,
					N'@exam_grade float,
					@exam_time float,
					@cr_id int',
					@exam_grade ,
					@exam_time ,
					@cr_id 
	
	END
	 
RETURN 
 
 
/*test cases*/
EXEC  InsertExam

	 

EXEC  InsertExam 2.5, 5, 1

	 