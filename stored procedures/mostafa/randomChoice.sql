ALTER function choice(@string varchar(200), @delimiter varchar(2))
RETURNS @table TABLE (items VARCHAR(200))
AS
BEGIN
insert into @table  SELECT * FROM STRING_SPLIT(@string, @delimiter)
return
end
GO

select * FROM dbo.choice('A,B,C,D', 'B')
order by NEWID()
