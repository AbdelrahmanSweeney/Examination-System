alter PROC Exam_Random_generation  @cr_name VARCHAR(20), @no_TF INT, @no_MC INT, @exam_time int, @exam_grade int
AS
begin
/*insert exam into exam table*/
	INSERT INTO Exam(exam_grade, exam_time, cr_id)
	VALUES     (@exam_grade, @exam_time,
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
	SELECT TOP(@no_MC) @ex_id, Q.ques_id
	FROM Questions Q JOIN question_course QC ON Q.ques_id = QC.ques_id
					 JOIN course C ON C.cr_id =QC.cr_id
	WHERE c.cr_name =@cr_name AND Q.qType IN('MC')
	ORDER BY NEWID()

SELECT  Q.question,Q.ques_id, Q.qType, mcq.a, mcq.b, mcq.c, mcq.d  --Return Exam Question
	FROM Questions Q left JOIN Choices mcq ON Q.ques_id=mcq.ques_id
	JOIN Exam_Question EX ON Q.ques_id = EX.ques_id
	WHERE EX.exam_id = @ex_id

end

Execute Exam_Random_generation @cr_name='C#', @no_TF=5, @no_MC=5 ,@exam_time=60 ,@exam_grade=20

