/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	DeleteStudExam 
		@stud_id int = NULL,
		@exam_id int = NULL ,
		@ques_id int = NULL,
		@answer varchar(50) = NULL
AS
	DECLARE @DeleteStatment nvarchar(300)		
		SET @DeleteStatment = 'DELETE FROM ST_EX WHERE '

	IF dbo.[IsNullOrEmpty](@stud_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' stud_id = @stud_id AND')
	IF dbo.[IsNullOrEmpty](@exam_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' exam_id = @exam_id AND')
	IF dbo.[IsNullOrEmpty](@ques_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' ques_id = @ques_id AND')
	IF dbo.[IsNullOrEmpty](@answer) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' AnsQ = @answer AND')


	IF @DeleteStatment =  'DELETE FROM ST_EX WHERE '
		SELECT 'PLS INSERT CONDITION'
	ELSE
		BEGIN
	
			SET @DeleteStatment  = SUBSTRING(@DeleteStatment, 1, (len(@DeleteStatment) - 3))
			 	
				EXECUTE sp_executesql @DeleteStatment,
				N'@stud_id int,
				@exam_id int,
				@ques_id int,
				@answer varchar(50)',
				@stud_id,
				@exam_id,
				@ques_id,
				@answer
		
		END
RETURN 
 
 /*test cases*/
 exec DeleteStudExam @answer='false'