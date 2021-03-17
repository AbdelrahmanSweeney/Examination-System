/*UPDATE QUESTION TABLE (U CAN SPECIFIY ALL THE COLUMNS OR SET OF COLUMNS*/
ALTER PROCEDURE 
	UpdateSudExam 
		@stud_id int = NULL,
		@exam_id int = NULL ,
		@ques_id int = NULL,
		@answer varchar(50) = NULL,

		@stud_id_condition int = NULL,
		@exam_id_condition int = NULL ,
		@ques_id_condition int = NULL,
		@answer_condition varchar(50) = NULL
AS
	DECLARE @UpdateStatment nvarchar(300)		
	SET @UpdateStatment = 'UPDATE ST_EX SET '

	IF dbo.[IsNullOrEmpty](@stud_id) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'st_id = @stud_id,')
	IF dbo.[IsNullOrEmpty](@exam_id) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'ex_id = @exam_id,')
	IF dbo.[IsNullOrEmpty](@ques_id) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'q_id = @ques_id,')
	IF dbo.[IsNullOrEmpty](@answer) = 0
		SET @UpdateStatment = CONCAT(@UpdateStatment, 'AnsQ = @answer,')
	IF @UpdateStatment != 'UPDATE ST_EX SET '
		BEGIN
			SET @UpdateStatment = (Select left(@UpdateStatment, len(@UpdateStatment)-1))
			SET @UpdateStatment = CONCAT(@UpdateStatment, ' WHERE ')
			DECLARE @TempUpdateStatment varchar(400) = @UpdateStatment

			IF dbo.[IsNullOrEmpty](@stud_id_condition) = 0
				SET @UpdateStatment = CONCAT(@UpdateStatment, 'st_id = @stud_id_condition AND')
			IF dbo.[IsNullOrEmpty](@exam_id_condition) = 0
				SET @UpdateStatment = CONCAT(@UpdateStatment, 'ex_id = @exam_id_condition AND')
			IF dbo.[IsNullOrEmpty](@ques_id_condition) = 0
				SET @UpdateStatment = CONCAT(@UpdateStatment, 'q_id = @ques_id_condition AND')
			IF dbo.[IsNullOrEmpty](@answer_condition) = 0
				SET @UpdateStatment = CONCAT(@UpdateStatment, 'AnsQ = @answer_condition AND')

			IF @UpdateStatment != @TempUpdateStatment
				SET @UpdateStatment = (Select left(@UpdateStatment, len(@UpdateStatment)-3))/*remove AND*/
			ELSE
				SET @UpdateStatment = (Select left(@UpdateStatment, len(@UpdateStatment)-6))/*remove WHERE*/


			EXECUTE sp_executesql @UpdateStatment,
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
		
		END
	ELSE
		SELECT 'please specify value(s) to update!'
	 
RETURN 



/*test cases*/
EXEC UpdateSudExam @exam_id = 1, @answer='afafafad', @exam_id_condition=1
