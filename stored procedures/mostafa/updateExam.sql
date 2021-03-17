/*UPDATE QUESTION TABLE (U CAN SPECIFIY ALL THE COLUMNS OR SET OF COLUMNS*/
ALTER PROCEDURE 
	UpdateExam 
		@exam_id int,
		@exam_grade float = NULL ,
		@exam_time float= NULL,
		@cr_id int = NULL
AS
	DECLARE @UpdateStatment nvarchar(300)		
	SET @UpdateStatment = 'UPDATE Exam SET '

	IF dbo.[IsNullOrEmpty](@exam_grade) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'exam_grade = @exam_grade,')
	IF dbo.[IsNullOrEmpty](@exam_time) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'exam_time = @exam_time,')
	IF dbo.[IsNullOrEmpty](@cr_id) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'cr_id = @cr_id,')
	IF @UpdateStatment != 'UPDATE Exam SET '
		BEGIN
			SET @UpdateStatment = (Select left(@UpdateStatment, len(@UpdateStatment)-1))
			SET @UpdateStatment = CONCAT(@UpdateStatment, ' WHERE exam_id = @exam_id ')
			EXECUTE sp_executesql @UpdateStatment,
			N'@exam_id int,
			@exam_grade float,
			@exam_time float,
			@cr_id int',
			@exam_id,
			@exam_grade,
			@exam_time,
			@cr_id

			SELECT  @@ROWCOUNT
		END
	ELSE
		SELECT 'please specify value(s) to update!'
	 
RETURN 



/*test cases*/
EXEC UpdateExam @exam_id = 1, @exam_grade=18
