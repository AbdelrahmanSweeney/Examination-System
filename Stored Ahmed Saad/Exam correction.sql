ALTER PROC Exam_Correction @stud_id int, @exam_id int
AS
DECLARE @total_questions int
SELECT  @total_questions = count(Q_ID) FROM ST_EX
WHERE  ST_ID = @stud_id AND EX_ID = @exam_id

DECLARE @total_right_questions float
SELECT  @total_right_questions = count(Q_ID) 
FROM ST_EX SX JOIN Questions Q ON SX.Q_ID = Q.ques_id
WHERE  ST_ID = @stud_id AND EX_ID = @exam_id AND SX.AnsQ = Q.qAnswer

SELECT str(@total_right_questions/@total_questions*100)+'%'

Exam_Correction 4, 1
go
Exam_Correction 6, 2
