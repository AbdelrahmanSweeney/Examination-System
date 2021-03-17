/*INSERT QUESTION TABLE  */
CREATE PROCEDURE 
	SelectStudExam
		@stud_id int = NULL,
		@exam_id int = NULL ,
		@ques_id int = NULL,
		@answer varchar(50) = NULL,

		@stud_id_condition int = NULL,
		@exam_id_condition int = NULL ,
		@ques_id_condition int = NULL,
		@answer_condition varchar(50) = NULL
AS
	DECLARE @SelectStatment nvarchar(300)		
		SET @SelectStatment = 'SELECT '

	IF @stud_id = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' st_id ,')
	IF @exam_id = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' ex_id ,')
	IF @ques_id =1
		SET @SelectStatment = CONCAT(@SelectStatment, ' q_id ,')
	IF @answer = 1
		SET @SelectStatment = CONCAT(@SelectStatment, ' AnsQ ,')

	IF @SelectStatment = 'SELECT '
		SET @SelectStatment = CONCAT(@SelectStatment, ' * ')
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -1))
	
	SET @SelectStatment  = CONCAT(@SelectStatment, 'FROM ST_EX WHERE ')

	DECLARE @TempSelectStatment varchar(300) = @SelectStatment


	IF dbo.[IsNullOrEmpty](@stud_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' st_id = @stud_id_condition AND')
	IF dbo.[IsNullOrEmpty](@exam_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' ex_id = @exam_id_condition AND')
	IF dbo.[IsNullOrEmpty](@ques_id_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, '  q_id = @ques_id_condition AND')
	IF dbo.[IsNullOrEmpty](@answer_condition) = 0
		SET @SelectStatment = CONCAT(@SelectStatment, ' AnsQ = @answer_condition AND')
	

	IF @SelectStatment = @TempSelectStatment
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -6))/*remove where*/
	ELSE
		SET @SelectStatment  = SUBSTRING(@SelectStatment, 1, (len(@SelectStatment) -3))/*remove and*/

		
	EXECUTE sp_executesql @SelectStatment,
				N'@stud_id int,
			@exam_id int,
			@ques_id int,
			@answer varchar(50),

			@stud_id_condition int ,
			@exam_id_condition int  ,
			@ques_id_condition int ,
			@answer_condition varchar(50)',
			@stud_id ,
			@exam_id   ,
			@ques_id  ,
			@answer,

			@stud_id_condition ,
			@exam_id_condition ,
			@ques_id_condition ,
			@answer_condition 
				
RETURN 
 
 exec SelectStudExam @exam_id=1, @exam_id_condition=1