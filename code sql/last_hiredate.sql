USE pubs
GO

CREATE PROCEDURE last_hiredate 
@id_job int,
@date datetime OUTPUT
AS

	if(not exists(SELECT * FROM employee WHERE job_id = @id_job))
	BEGIN
		PRINT('Id de job inexistant')
		RETURN
	END

	SELECT @date = MAX(hire_date) FROM employee
	WHERE job_id =@id_job
GO

