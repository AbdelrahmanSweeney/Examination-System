/*USER DEFINED FUNCTION TO RETURN IF THE GIVEN VALUE IS NULL / EMPTY 
IF IT IS RETURNS 1 ELSE 0*/
CREATE FUNCTION IsNullOrEmpty(@value nvarchar(200))
	RETURNS INT
AS
BEGIN
	DECLARE @RESULT INT
	IF (@value is null or @value = '')
		SET @RESULT = 1
	ELSE
		SET @RESULT = 0
	RETURN @RESULT
END	

/*CREATE POROCEDURE THAT INSERT INTO QUESTION TABLE WITH GIVEN VALEUS AND 
CHECK IF THE VALEUS IS NOT EMTPY / NULL */
CREATE PROCEDURE 
	InsertQuestion 
		@q varchar(200),
		@q_answer varchar(200),
		@q_grade float,
		@q_type nvarchar(50)
AS
	INSERT INTO Questions(question, qAnswer, qGrade, qType)
	VALUES(@q, @q_answer, @q_grade, @q_type)
 
 
 
 /*test cases*/
 InsertQuestion @q= 'question number 2',
				@q_grade = 10.4,
				@q_answer = 'question number 2 answer',
				@q_type = 'question type 2'

/*should throw exception*/
 InsertQuestion 
				@q_grade = 10.4,
				@q_answer = 'question number 2 answer',
				@q_type = 'question type 2'