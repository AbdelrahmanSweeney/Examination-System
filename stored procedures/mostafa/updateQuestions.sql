/*UPDATE QUESTION TABLE (U CAN SPECIFIY ALL THE COLUMNS OR SET OF COLUMNS*/
CREATE PROCEDURE 
	UpdateQuestion 
		@q_id int,
		@q nvarchar(200) = NULL ,
		@q_answer varchar(200) = NULL,
		@q_grade float = NULL,
		@q_type nvarchar(50) = NULL
AS
	DECLARE @UpdateStatment nvarchar(300)		
	SET @UpdateStatment = 'UPDATE Questions SET '

	IF dbo.[IsNullOrEmpty](@q) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'question = @q,')
	IF dbo.[IsNullOrEmpty](@q_answer) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'qAnswer = @q_answer,')
	IF dbo.[IsNullOrEmpty](@q_grade) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'qGrade = @q_grade,')
	IF dbo.[IsNullOrEmpty](@q_type) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'qType = @q_type,')
	IF @UpdateStatment != 'UPDATE Questions SET '
		BEGIN
			SET @UpdateStatment = (Select left(@UpdateStatment, len(@UpdateStatment)-1))
			SET @UpdateStatment = CONCAT(@UpdateStatment, ' WHERE ques_id = @q_id ')
			EXECUTE sp_executesql @UpdateStatment,
			N'@q_id int,
			@q nvarchar(200) ,
			@q_answer varchar(200),
			@q_grade float,
			@q_type nvarchar(50)',
			@q_id,
			@q,
			@q_answer,
			@q_grade,
			@q_type;

			SELECT  @@ROWCOUNT
		END
	ELSE
		SELECT 'please specify value(s) to update!'
	 
RETURN 



/*test cases*/
EXEC UpdateQuestion @q_id = 12, @q_grade=10
EXEC UpdateQuestion @q_id = 12, @q_answer= 'answer is 2' 
EXEC UpdateQuestion @q_id = 12, @q_type= 'question type 2'
EXEC UpdateQuestion @q_id = 12,@q_grade=10, @q_answer= 'answer is 2' 
EXEC UpdateQuestion @q_id = 12