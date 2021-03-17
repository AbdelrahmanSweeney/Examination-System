/*INSERT QUESTION TABLE  */
CREATE PROCEDURE 
	DeleteExam 
		@exam_id int = NULL,
		@exam_grade float = NULL ,
		@exam_time float = NULL,
		@cr_id float = NULL
AS
	DECLARE @DeleteStatment nvarchar(300)		
		SET @DeleteStatment = 'DELETE FROM Exam WHERE '

	IF dbo.[IsNullOrEmpty](@exam_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' exam_id = @exam_id AND')
	IF dbo.[IsNullOrEmpty](@exam_grade) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' exam_grade = @exam_grade AND')
	IF dbo.[IsNullOrEmpty](@cr_id) = 0
		SET @DeleteStatment = CONCAT(@DeleteStatment, ' cr_id = @cr_id AND')

	IF @DeleteStatment = 'DELETE FROM Exam WHERE '
		SELECT 'PLS INSERT CONDITION'
	ELSE
		BEGIN
			SET @DeleteStatment  = SUBSTRING(@DeleteStatment, 1, (len(@DeleteStatment) - 3))
			 BEGIN TRY
			 EXECUTE sp_executesql @DeleteStatment,
				N'@exam_id INT ,
				@exam_grade float ,
				@exam_time float,
				@cr_id float',
				@exam_id,
				@exam_grade,
				@exam_time,
				@cr_id;
		END TRY 
		BEGIN CATCH 
			SELECT 'error removing exame, see delete role specification constraint'
		END CATCH 
		END

	 
RETURN 
 
 /*test cases*/
 exec deleteExam 66, 4,4,4