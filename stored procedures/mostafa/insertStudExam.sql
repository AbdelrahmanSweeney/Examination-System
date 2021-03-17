/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	InsertStudExam 
		@stud_id int = NULL,
		@exam_id int = NULL ,
		@ques_id int = NULL,
		@answer varchar(50) = NULL
AS
	BEGIN
		DECLARE @InsertStatment nvarchar(300)		
		SET @InsertStatment = 'INSERT INTO  ST_EX(st_id, ex_id, q_id, AnsQ) VALUES '

		SET @InsertStatment  = CONCAT(@InsertStatment, '(@stud_id,', '@exam_id,', '@ques_id,', '@answer)')			
	
		EXECUTE sp_executesql @InsertStatment,
					N'@stud_id int,
					@exam_id int,
					@ques_id int,
					@answer varchar(50)',
					@stud_id,
					@exam_id,
					@ques_id ,
					@answer
	END
	 
RETURN 
 
 
/*test cases*/
EXEC  InsertStudExam

	 

EXEC  InsertStudExam 3, 1, NULL ,''

	 