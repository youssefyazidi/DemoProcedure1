USE pubs
GO


CREATE PROCEDURE sp_titles_price_betwenn 
@lolimit money,
@hilimit money,
@type varchar(12)
AS
	SELECT pub_id, type, title_id, price
	FROM titles
	WHERE price BETWEEN @lolimit and @hilimit AND type =@type
	ORDER BY type
GO

--Dictionnaire de données = tables system qui contennent le méta data
--Infos sur les objets de la base
select *
from sys.tables

SELECT * FROM SYS.types

SELECT SYS.parameters.name,SYS.types.name FROM SYS.parameters
JOIN SYS.procedures ON SYS.procedures.object_id=SYS.parameters.object_id
JOIN SYS.types on parameters.user_type_id= SYS.types.user_type_id
WHERE SYS.procedures.name = 'sp_titles_price_betwenn'
