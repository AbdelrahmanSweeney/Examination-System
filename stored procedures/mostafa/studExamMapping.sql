declare @c int = 1000
delete from Student_Exam
drop table #tempExam_stud
create table #tempExam_stud(examid int, stuid int)


while @c > 0
	begin
		set @c = @c - 1 
		/*get random exam*/
		DECLARE @examId int = (select top (1) ExamId
		from Exam_Question order by NEWID())
		/*get random student*/
		DECLARE @studId int = (select top (1) StudID
		from Student order by NEWID())

		/*if the student didnt take the exam*/
		if ((select count(*) from #tempExam_stud where examid = @examId and stuid=@studId) = 0)
			begin
				/*insert into temexamstud examid and studid*/
				insert into #tempExam_stud values(@examId, @studId)
				/*insert into examstud values*/
				
				DECLARE @quesId int 

				DECLARE db_cursor CURSOR FOR 
				SELECT QuesId
				FROM Exam_Question
				where ExamId = @examId

				OPEN db_cursor  
				FETCH NEXT FROM db_cursor INTO @quesId

				WHILE @@FETCH_STATUS = 0
				BEGIN  
						declare @answer varchar(3)
						if ((select QuesType from Question where QuesId = 1861) = 'MC' )
							set @answer = (select top(1) * from choice('a,b,c,d', ',') order by NEWID())
						else
							set @answer = (select top(1) * from choice('T,F', ',') order by NEWID())

      					insert into Student_Exam(StudId, ExamId, QuesId, StudQuesAns)
						values(@studId, @examId, @quesId, @answer)

						

					  FETCH NEXT FROM db_cursor INTO @quesId 
				END 

				CLOSE db_cursor  
				DEALLOCATE db_cursor

			end
		else
			continue
	end









