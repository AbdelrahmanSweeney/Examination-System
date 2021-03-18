Alter PROC Exam_Random_generation  @cr_name VARCHAR(20), @no_TF INT, @no_ML INT
AS
begin
	DECLARE @minute_question INT =2
	DECLARE @gread_question INT =5
	INSERT INTO Exam(exam_grade, exam_time, cr_id)
	VALUES     ((@no_TF+@no_ML)*@gread_question, (@no_TF+@no_ML)*@minute_question,
			   (SELECT cr_id FROM course WHERE cr_name = @cr_name))

DECLARE @ex_id INT
SELECT  @ex_id = MAX(exam_id) FROM Exam

INSERT INTO Exam_Question    --Generate true & false Question
	SELECT TOP(@no_TF) @ex_id, Q.ques_id
	FROM Questions Q JOIN question_course QC ON Q.ques_id=QC.ques_id
					 JOIN course C ON C.cr_id =QC.cr_id
	WHERE C.cr_name = @cr_name AND Q.qType IN('YN','TF')
	ORDER BY NEWID()	
INSERT INTO Exam_Question	--Generate true & false Question
	SELECT TOP(@no_ML) @ex_id, Q.ques_id
	FROM Questions Q JOIN question_course QC ON Q.ques_id = QC.ques_id
					 JOIN course C ON C.cr_id =QC.cr_id
	WHERE c.cr_name =@cr_name AND Q.qType IN('ML')
	ORDER BY NEWID()

SELECT  Q.question, mcq.choices  --Return Exam Question
	FROM Questions Q JOIN Choices mcq ON Q.ques_id=mcq.ques_id
	JOIN Exam_Question EX ON Q.ques_id = EX.ques_id
	WHERE EX.exam_id = @ex_id

end

Execute Exam_Random_generation @cr_name='Programming', @no_TF=3, @no_ML=1

