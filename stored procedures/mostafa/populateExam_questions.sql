select *
into #tempQuestion
from Question

 while (select count(*) from #tempQuestion) != 0 
 begin
declare @quesid int

select top(1) @quesid= QuesId  from #tempQuestion
order by NEWID()

delete from #tempQuestion where QuesId = @quesid

select @quesid


insert into Exam_Question 
select (select top (1) ExamId from Exam order by NEWID()), @quesid  
end

drop table #tempQuestion

