/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	InsertQuestion 
		@q nvarchar(200) = NULL ,
		@q_answer varchar(200) = NULL,
		@q_grade float = NULL,
		@q_type nvarchar(50) = NULL
AS
	DECLARE @InsertStatment nvarchar(300)		
	SET @InsertStatment = 'INSERT INTO  Questions(question, qGrade,qType,qanswer) VALUES '

	IF dbo.[IsNullOrEmpty](@q) = 1 or
	dbo.[IsNullOrEmpty](@q_answer) = 1
	or dbo.[IsNullOrEmpty](@q_grade) = 1
	or dbo.[IsNullOrEmpty](@q_type) = 1
		SELECT 'value can not to be null'
	ELSE
		BEGIN
			SET @InsertStatment  = CONCAT(@InsertStatment, '(', '@q,', '@q_grade,', '@q_type,', '@q_answer)')
				SELECT @InsertStatment
				EXECUTE sp_executesql @InsertStatment,
				N'@q nvarchar(200) ,
				@q_answer varchar(200),
				@q_grade float,
				@q_type nvarchar(50)',
				@q,
				@q_answer,
				@q_grade,
				@q_type;
				SELECT @@ROWCOUNT
		END
	 
RETURN 
 

/*test cases*/
EXEC InsertQuestion @q='QUESTION NUMBER 3',
				@q_answer = 'QUESTION NUMBER 3 ANSWER ',
				@q_grade= 11,
				@q_type = ''


EXEC InsertQuestion @q='QUESTION NUMBER 3',
	@q_answer = 'QUESTION NUMBER 3 ANSWER ',
	@q_grade= 11,
	@q_type = 'gg'
	 