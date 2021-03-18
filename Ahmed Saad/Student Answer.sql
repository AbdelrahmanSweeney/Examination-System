ALTER PROC Stud_Answer @stud_id int, @exam_id int, @question_id int, @stud_answer varchar(30)
AS
	IF EXISTS (SELECT * FROM ST_EX WHERE ST_ID = @stud_id AND EX_ID = EX_ID)
			SELECT'Student already take this Exam'
	ELSE
		INSERT INTO ST_EX(ST_ID, EX_ID, Q_ID, AnsQ)
		VALUES(@stud_id, @exam_id, @question_id, @stud_answer )
