/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	DeleteQuestion 
		@ques_id int = NULL,
		@q nvarchar(200) = NULL ,
		@q_answer varchar(200) = NULL,
		@q_grade float = NULL,
		@q_type nvarchar(50) = NULL
AS
	DECLARE @DeleteStatment nvarchar(300)		
		SET @DeleteStatment = 'DELETE FROM Questions WHERE '

	IF dbo.[IsNullOrEmpty](@q) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, 'question = @q AND')
	IF dbo.[IsNullOrEmpty](@q_type) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, 'qType = @q_type AND')
	IF dbo.[IsNullOrEmpty](@ques_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' ques_id = @ques_id AND')

	IF @DeleteStatment = 'DELETE FROM Questions WHERE '
		SELECT 'PLS INSERT CONDITION'
	ELSE
		BEGIN
			SET @DeleteStatment  = SUBSTRING(@DeleteStatment, 1, (len(@DeleteStatment) - 3))
			 EXECUTE sp_executesql @DeleteStatment,
				N'@ques_id INT ,
				@q nvarchar(200) ,
				@q_answer varchar(200),
				@q_grade float,
				@q_type nvarchar(50)',
				@ques_id,
				@q,
				@q_answer,
				@q_grade,
				@q_type;
				SELECT @@ROWCOUNT
		END
	 
RETURN 
 

/*test cases*/
EXEC DeleteQuestion @q='QUESTION NUMBER 3'

EXEC DeleteQuestion  @ques_id=14,@q_type = 'YES'	 

/*should be error*/
EXEC DeleteQuestion 

EXEC DeleteQuestion  @ques_id='345',@q_type = 23