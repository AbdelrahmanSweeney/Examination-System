/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	SelectExam
		@exam_id nchar = NULL,
		@exam_grade nchar= NULL,
		@exam_time nchar= NULL,
		@cr_id nchar= NULL,
 
		@exam_id_condition int = NULL,
		@exam_grade_condition float = NULL ,
		@exam_time_condition float= NULL,
		@cr_id_condition int = NULL
AS
	DECLARE @SelectStatment nvarchar(300)		
		SET @SelectStatment = 'SELECT '

	IF @exam_id = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' exam_id ,')
	IF @exam_grade = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' exam_grade ,')
	IF @exam_time =1
		SET @SelectStatment = CONCAT(@SelectStatment, ' exam_time ,')
	IF @cr_id = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' cr_id ,')

	IF @SelectStatment = 'SELECT '
		SET @SelectStatment = CONCAT(@SelectStatment, ' * ')
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -1))
	
	SET @SelectStatment  = CONCAT(@SelectStatment, 'FROM Exam WHERE ')

	DECLARE @TempSelectStatment varchar(300) = @SelectStatment


	IF dbo.[IsNullOrEmpty](@exam_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' exam_id = @exam_id_condition AND')
	IF dbo.[IsNullOrEmpty](@exam_grade_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' exam_grade = @exam_grade_condition AND')
	IF dbo.[IsNullOrEmpty](@exam_time_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, '  exam_time = @exam_time_condition AND')
	IF dbo.[IsNullOrEmpty](@cr_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' cr_id = @cr_id_condition AND')
	

	IF @SelectStatment = @TempSelectStatment
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -6))/*remove where*/
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -3))/*remove and*/

		
	EXECUTE sp_executesql @SelectStatment,
				N'@exam_id nchar,
				@exam_grade nchar  ,
				@exam_time nchar ,
				@cr_id nchar ,
 
				@exam_id_condition int ,
				@exam_grade_condition float  ,
				@exam_time_condition float ,
				@cr_id_condition int  ',
				@exam_id,
				@exam_grade,
				@exam_time,
				@cr_id ,
 
				@exam_id_condition,
				@exam_grade_condition ,
				@exam_time_condition,
				@cr_id_condition
				
RETURN 
 

 exec SelectExam  @exam_id=1, @exam_grade=1, @exam_id_condition=1, @exam_grade_condition=3
exec SelectExam  @exam_grade_condition=18
