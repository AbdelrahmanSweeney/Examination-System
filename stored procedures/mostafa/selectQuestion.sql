/*INSERT QUESTION TABLE  */
ALTER PROCEDURE 
	SelectQuestion 
		@ques_id_value int = NULL,
		@q_value nvarchar(200) = NULL ,
		@q_answer_value varchar(200) = NULL,
		@q_grade_value float = NULL,
		@q_type_value nvarchar(50) = NULL,

		@ques_id_condition int = NULL,
		@q_condition nvarchar(200) = NULL ,
		@q_answer_condition varchar(200) = NULL,
		@q_grade_condition float = NULL,
		@q_type_condition nvarchar(50) = NULL
AS
	DECLARE @SelectStatment nvarchar(300)		
		SET @SelectStatment = 'SELECT '

	IF dbo.[IsNullOrEmpty](@q_value) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, 'question ,')
	IF dbo.[IsNullOrEmpty](@q_type_value) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, 'qType ,')
	IF dbo.[IsNullOrEmpty](@ques_id_value) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' ques_id ,')
	IF dbo.[IsNullOrEmpty](@q_grade_value) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' qGrade ,')
	IF dbo.[IsNullOrEmpty](@q_answer_value) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' qAnswer ,')

	IF @SelectStatment = 'SELECT '
		SET @SelectStatment = CONCAT(@SelectStatment, ' * ')
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -1))
	
	SET @SelectStatment  = CONCAT(@SelectStatment, 'FROM Questions WHERE ')

	DECLARE @TempSelectStatment varchar(300) = @SelectStatment

	IF dbo.[IsNullOrEmpty](@q_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, 'question = @q_condition AND')
	IF dbo.[IsNullOrEmpty](@q_type_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, 'qType = @q_type_condition AND')
	IF dbo.[IsNullOrEmpty](@ques_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' ques_id = @ques_id_condition AND')
	IF dbo.[IsNullOrEmpty](@q_grade_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' qGrade = @q_grade_condition AND')
	IF dbo.[IsNullOrEmpty](@q_answer_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' qAnswer = @q_answer_condition AND')


	IF @SelectStatment = @TempSelectStatment
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -6))/*remove where*/
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -3))/*remove and*/

	SELECT @SelectStatment
			 /**EXECUTE sp_executesql @SelectStatment,
				N'@ques_id_value int,
				@q_value nvarchar(200) ,
				@q_answer_value varchar(200),
				@q_grade_value float,
				@q_type_value nvarchar(50),

				@ques_id_condition int,
				@q_condition nvarchar(200),
				@q_answer_condition varchar(200),
				@q_grade_condition float,
				@q_type_condition nvarchar(50)',
				@ques_id_value,
				@q_value,
				@q_answer_value,
				@q_grade_value,
				@q_type_value,

				@ques_id_condition,
				@q_condition,
				@q_answer_condition,
				@q_grade_condition,
				@q_type_condition*/

RETURN 
 

 exec SelectQuestion  @q_type_condition = 'GG'
