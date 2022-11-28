USE pubs
GO

--Proc without parameters
CREATE PROCEDURE sp_tiltles_with_price
AS

SELECT   pub_id, title_id, price, pubdate
FROM 
titles 
WHERE price IS NOT NULL
ORDER BY pub_id

GO


