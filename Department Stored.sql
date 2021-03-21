
-- add new department
ALTER PROC P_addDepartment @deptName NVARCHAR(50), @deptManagerId INT
AS
BEGIN

IF EXISTS (SELECT* FROM Department WHERE d_name = @deptName) 
	SELECT 'There are department with the same name'
ELSE IF @deptManagerId IS NULL
BEGIN
	INSERT INTO Department (d_name) VALUES (@deptName)
	SELECT 'Department inserted successfully'
END
ELSE IF EXISTS (SELECT* FROM instructor WHERE ins_id = @deptManagerId)
	BEGIN
		INSERT INTO Department (d_name,Manger_ID) VALUES (@deptName, @deptManagerId)
		SELECT 'Department inserted successfully'
	END
	ELSE
		SELECT 'Selected Manager does not exists'
END
 	

EXEC P_addDepartment 'Abdo559', NULL

go

--update department
CREATE PROC P_updateDepartment @deptId INT,@deptName NVARCHAR(50),@deptManagerId INT
AS
BEGIN
IF EXISTS (SELECT* FROM Department WHERE d_name = @deptName) 
	SELECT 'There are department with the same name'
ELSE IF @deptManagerId IS NULL
BEGIN
	UPDATE Department SET d_name = @deptName, Manger_ID = @deptManagerId  WHERE dep_id = @deptId
	SELECT 'Department Updated successfully'
END
ELSE IF EXISTS (SELECT* FROM instructor WHERE ins_id = @deptManagerId)
	BEGIN
		UPDATE Department SET d_name = @deptName, Manger_ID = @deptManagerId  WHERE dep_id = @deptId
		SELECT 'Department Updated successfully'
	END
	ELSE
		SELECT 'Selected Manager does not exists'
END



--delete department
ALTER PROC P_deleteDepartment @deptId INT
AS
BEGIN
IF EXISTS(SELECT* FROM Department WHERE dep_id = @deptId)
	BEGIN
	DELETE FROM Department WHERE dep_id = @deptId
	SELECT 'Departemt deleted'
	END
ELSE 
	SELECT 'There is no department with this id'
END

GO


--get all departemts info 
CREATE PROC P_getAllDepartmentsInfo 
AS
SELECT d.dep_id, d.d_name, m.ins_fname+m.ins_lname AS 'Manager Name', i.ins_id, i.ins_fname, s.std_id, s.st_fname + s.st_lname as 'Student Name'
FROM
	Department d
JOIN Student s ON d.dep_id = s.dep_id
JOIN instructor i ON d.dep_id = i.dep_id
JOIN instructor m ON d.Manger_ID = m.ins_id

--get departemt info by id
CREATE PROC P_getDepartmentInfo @deptId INT 
AS
SELECT d.dep_id, d.d_name, m.ins_fname+m.ins_lname AS 'Manager Name', i.ins_id, i.ins_fname, s.std_id, s.st_fname + s.st_lname as 'Student Name'
FROM
	Department d
JOIN Student s ON d.dep_id = s.dep_id
JOIN instructor i ON d.dep_id = i.dep_id
JOIN instructor m ON d.Manger_ID = m.ins_id
WHERE 
	d.dep_id = @deptId
