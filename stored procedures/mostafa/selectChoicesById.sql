/*INSERT QUESTION TABLE  */
create PROCEDURE 
	p_select_choices_by_ques_id
		@ques_id int = NULL
		
AS
	DECLARE @SelectStatment nvarchar(300)		
		SET @SelectStatment = 'SELECT top(1) * FROM Choices WHERE ques_id = @ques_id '

	
	EXECUTE sp_executesql @SelectStatment,
				N'@ques_id int',
				@ques_id

RETURN 
 

 exec p_select_choices_by_ques_id 210
