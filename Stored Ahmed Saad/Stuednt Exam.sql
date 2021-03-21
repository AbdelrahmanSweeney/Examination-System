ALTER PROC exam_student @student_id int, @course_id int
AS
	DECLARE @exam_id int
	SELECT  @exam_id = MAX(exam_id) FROM Exam
	WHERE   cr_id = @course_id
	ORDER BY NEWID()

	SELECT  Q.question, mcq.choices 
	FROM Questions Q JOIN Choices mcq ON Q.ques_id=mcq.ques_id
	JOIN Exam_Question EX ON Q.ques_id = EX.ques_id
	WHERE EX.exam_id = @exam_id

	select @exam_id Exam_ID

	SELECT exam_time Exame_Time FROM Exam
	WHERE  exam_id = @exam_id

	SELECT COUNT(ques_id) Number_Questoin FROM Exam_Question
	WHERE  exam_id = @exam_id


exam_student 1,1