
----------------------------------------------------Start Student------------------------------ 
-- -------------------------------------- First Insert In Student Tabel
Create PROC Inst_St @fname nvarchar(50),@lname nvarchar(50),@user_na nvarchar(50),@pass nvarchar(50),@email nvarchar(200),@face_book nvarchar(200),@linkedin nvarchar(200),@dept_id int,@role_type nvarchar(50)
as 
		insert into Student(st_fname,st_lname,userName,password,email,facebook,linkedin,dep_id,RoleType)
		values(@fname,@lname,@user_na,@pass,@email,@face_book,@linkedin,@dept_id,@role_type)

create trigger ins 
on Student
after insert 
as 
	select 'Insert Operation is done'

Inst_St 'Kotb','Mohamed','Kotb','1234','kotb@gmail.com',NULL,NULL,2,'ST'
Inst_St 'Haitham','Mohamed','haitham1','1234','haitham@gmail.com',NULL,NULL,2,'ST'
Inst_St 'Hager','Ahmed','hager2','1234','hager@gmail.com',NULL,NULL,2,'ST'
Inst_St 'Marlin','omar','marlin1','1234','marlin@gmail.com',NULL,NULL,3,'ST'
Inst_St 'Wafaa','sayed','wafaa1','1234','wafaa@gmail.com',NULL,NULL,3,'ST'


--------------------------------------------------------------------------------------------------------------------------
---------------------------------------------second operation  Select All Course Data
 create proc P_Student_Getall 

as
	select *
	from Student
	P_Student_Getall
--- second operation Select Proc
create proc P_ST_Role @userName nvarchar(50),@pass nvarchar(50) 


as
	select RoleType
	from Student
	where @userName=userName and @pass=password

-------------------------------------------------------------------------------------------
-------------------------------------------------tird operation Update ----------------------

create Proc update_st @id int, @fname nvarchar(50),@lname nvarchar(50),@user_na nvarchar(50),@pass nvarchar(50),@email nvarchar(200),@face_book nvarchar(200),@linkedin nvarchar(200),@dept_id int,@role_type nvarchar(50)
As 
	begin 
		Update Student
			Set st_fname = @fname,  
			st_lname = @lname,
			userName=@user_na,
			password=@pass,
			email=@email,
			facebook=@face_book,
			linkedin=@linkedin,
			dep_id=@dept_id,
			RoleType=@role_type
			where std_id=@id
	end
return 0
                   
execute update_st 7,'Ashraf','Mohamed','ashraf','1234','ashraf@gmail.com',NULL,NULL,2,'ST'
-------------------------------------------------------------------------------------------
---------------------------------------tird operation delete
create proc P_Delete_st @id int
As
	DELETE FROM [dbo].[Student]
	WHERE [std_id]= @ID


execute P_Delete_st 11;
-----------------------------------------------------------End Student---------------------------------------------


--------------------------------------------------------------Instructor---------------------------------------------
--------------------------------------------------First Insert In Instructor ------------------------
drop proc P_Inst_Instructor
Create PROC P_Inst_Instructor @fname nvarchar(50),@lname nvarchar(50),@email_na nvarchar(200),@pass nvarchar(50),@user_name nvarchar(200),@data date,@salary float,@rating float,@dep_id int,@cr_id int,@role_type nvarchar(50)
as 
		insert into instructor([ins_fname],[ins_lname],[ins_email],[password],[username],[hirDate],[salary],[rating],[dep_id],[cr_id],[Role])
		values (@fname,@lname,@email_na,@pass,@user_name,@data,@salary,@rating,@dep_id,@cr_id,@role_type)


P_Inst_Instructor  'Kotb','Mohamed','kotb@gmail.com','1234','kotb','2007-05-08',1000,3,1,1,Ins

--------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------- second operation Select Proc
create proc P_Inst_Getname 

as
	select [ins_fname]
	from instructor
	where 
--- GeTALl Data
 create proc P_Inst_GeAll 

as
	select *
	from instructor
	P_Inst_GeAll  
 ----------------------------------------------------------------------------------------------------------
 ---------------------------------------------------------Return Role Type-------------------------- 
 create proc P_Inst_GetRoleType  @userName nvarchar(50),@pass nvarchar(50)

as
	select [Role]
	from instructor
	where [username]=@userName and [password]=@pass

 P_Inst_GetRoleType kotb,1234 
 ----------------------------------------------------------------------------------------------
-----------------------------------------------------tird operation Update--------------------------------------

 create Proc P_update_Inst @id int,@fname nvarchar(50),@lname nvarchar(50),@email_na nvarchar(200),@pass nvarchar(50),@user_name nvarchar(200),@data date,@salary money,@rating float,@dep_id int,@cr_id int,@role_type nvarchar(50)
As 
	begin 
		Update instructor
		set [ins_fname]=@fname,
			[ins_lname]=@lname,
			[ins_email]=@email_na,
			[password]=@pass,
			[username]=@user_name,
			[hirDate]=@data,
			[salary]=@salary,
			[rating]=@rating,
			[dep_id]=@dep_id,
			[cr_id]=@cr_id,
			[Role]=@role_type
			where [ins_id]=@id
	end
return 0

P_update_Inst 2,'Kotb','Mohamed','kotb@gmail.com','1234','kotb','2007-05-08',1000,3,1,1,Ins

-------------------------------------------------------------------------------------------
----------------------------------------tird operation delete-------------------------
create proc P_Delete_ins @id int
As
	DELETE FROM instructor
	WHERE [ins_id]= @ID



execute P_Delete_ins 5;


--------------------------------------------------End Insructor------------

---------------------------------------------------Start COURSE---------------------------------------------------------------------------------------------------
Use [examination system]
-- ------------------------------------------First Insert In COURSE Tabel----------------------------------------------------------------------------------------------------------
Create PROC Inst_cr @name_c nvarchar(50),@hours_cr float
as 
		insert into course (cr_name,cr_hours)
		values(@name_c,@hours_cr)


execute Inst_cr 'Statistics',6;
execute Inst_cr 'Mathematics',8;
execute Inst_cr 'MachineLearnig',10;
execute Inst_cr 'BI',7;

----------------------------------------------second operation  Select All Course Data---------------------------------------------------
 create proc P_Coures_Getall 

as
	select *
	from course
	P_Coures_Getall
------------------------------------------------------------------------------------------------
---------------------------------------------------third operation Update------------------------------------------------
create Proc update_cr @cr_hours int, @name_cr nvarchar(50)
As 
	begin 
		Update course
			Set cr_hours = @cr_hours  
			where cr_name=@name_cr
	end
return 0

execute update_cr 10,'BI'
----------------------------------------------------------------------------------------------------
---------------------------------------------------fourth operation delete
create proc delete_cr @cr_name nvarchar(50)
As
	DELETE FROM course
	WHERE cr_name= @cr_name



execute delete_cr 'MachineLearnig'
---fourth operation delete  Course By ID 
create proc P_Delete_Cur @id int
As
	DELETE FROM [dbo].[course]
	WHERE [cr_id]= @ID
----------------------------------------------------------------------------------------------------------------
--------------------------------------------------Get Course ID ------------------------------------------------
create proc P_Coures_GetID  @cur_name nvarchar(50)

as
	select [cr_id]
	from course
	where [cr_name]=@cur_name



-----------------------------------------------Start Topic -----------------------------
-----------------------------------------first insert-----------------------------

Create PROC Inst_topic @top_name nvarchar(50),@cr_id int
as 
		insert into Topic(Topic_Name,Cr_ID)
		values(@top_name,@cr_id)

--------------------------------------select----------------------
create proc P_topic_Getall 

as
	select t.Topic_ID,c.cr_name,t.Topic_Name
	from course c join Topic t
	on c.cr_id=t.Cr_ID

P_topic_Getall

----------------------------------------Delete-----------------
create proc delete_topic @ID nvarchar(50)
As
	DELETE FROM Topic
	WHERE Topic_ID= @ID


execute delete_top
------------------------------------------End Topic-----------------------------
---------------------------------------Department
create proc P_Dep_GetID  @Dep_name nvarchar(50)

as
	select [dep_id]
	from Department
	where [d_name]=@Dep_name

