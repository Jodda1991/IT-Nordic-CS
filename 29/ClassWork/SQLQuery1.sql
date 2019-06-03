SELECT LEN('TEST')
GO
SELECT P.[Name], LEN (P.[Name])
FROM Product AS P
GO
DECLARE @year AS INT
SET @year = YEAR(GETUTCDATE())
SELECT @year;
GO
SELECT * FROM [dbo].[Order]
WHERE YEAR([OrderDate])= 2017
GO
SELECT COUNT (*) FROM dbo.[Product]
GO
SELECT MIN(OrderDate) AS [Min Order Date],
MAX (OrderDate) AS [Max Order Date] 
FROM dbo.[Order]
GO
--3
SELECT MAX(CustomerId)
FROM dbo.[Order]
GO
--4
SELECT AVG (Discount)
FROM dbo.[Order]
--6
SELECT MAX (OrderDate)
FROM dbo.[Order]
WHERE YEAR(OrderDate) = 2018
--2
SELECT COUNT(Distinct OrderId) 
FROM dbo.OrderItem
--7
SELECT LEN(MAX([Name]))
FROM dbo.Product

SELECT C.Id, C.[Name]
FROM dbo.Customer AS C
WHERE C.Id IN (
SELECT O.CustomerId 
FROM dbo.[Order] AS O
WHERE YEAR (O.OrderDate) = 2017)

SELECT P1.Id, P1.[Name]
FROM Product AS P1
WHERE LEN(P1.[Name])=(
SELECT MAX(LEN(P.[Name]))
FROM Product AS P)

SELECT TOP 1*
FROM dbo.[Order] AS O
ORDER BY O.[OrderDate] ASC

--1
SELECT O.Id
FROM dbo.[Order] AS O
WHERE O.Discount =(

	SELECT MAX (Discount)
	FROM dbo.[Order] AS O
	WHERE YEAR(OrderDate) = 2016)
--2
SELECT O.Id
FROM dbo.[Order] AS O
WHERE O.OrderDate =(
	SELECT MIN(O.OrderDate)
	FROM dbo.[Order] AS O
	WHERE YEAR(O.OrderDate) = 2019)

--3
SELECT C.Id, C.[Name]
FROM dbo.Customer AS C
WHERE C.Id =(
	SELECT O.CustomerId
	FROM dbo.[Order] AS O
	WHERE O.Discount =(
		SELECT MAX (Discount)
		FROM dbo.[Order] AS O
		WHERE YEAR(OrderDate) = 2016))

--4
SELECT C.Id,C.[Name]
FROM dbo.Customer AS C
WHERE C.Id =(
	SELECT O.CustomerId
	FROM dbo.[Order] AS O
	WHERE O.OrderDate =(
		SELECT MIN(O.OrderDate)
		FROM dbo.[Order] AS O
		WHERE YEAR(O.OrderDate) = 2019))

SELECT 
	P.Id AS ProductId,
	P.[Name],
	P.Price,
	OI.NumberOfItems,
	P.Price*OI.NumberOfItems
FROM dbo.OrderItem AS OI
INNER JOIN dbo.Product AS P
	ON P.Id = OI.ProductId
WHERE OI.OrderId =22


SELECT 
	SUM(P.Price*OI.NumberOfItems) AS TotalSum
FROM dbo.OrderItem AS OI
INNER JOIN dbo.Product AS P
	ON P.Id = OI.ProductId
WHERE OI.OrderId =22


--Maria
SELECT
(SELECT SUM(P.Price*OI.NumberOfItems)
FROM dbo.[Order] AS O
INNER JOIN dbo.OrderItem AS OI
	ON O.Id = OI.OrderId
INNER JOIN dbo.Product AS P
	ON P.Id = OI.ProductId
INNER JOIN dbo.Customer AS C
	ON C.Id=O.CustomerId
WHERE C.[Name] = 'Мария')
/
(SELECT SUM(P.Price*OI.NumberOfItems)
FROM dbo.[Order] AS O
INNER JOIN dbo.OrderItem AS OI
	ON O.Id = OI.OrderId
INNER JOIN dbo.Product AS P
	ON P.Id = OI.ProductId
INNER JOIN dbo.Customer AS C
	ON C.Id=O.CustomerId)

--GROUP BY
DECLARE @total AS MONEY
SELECT @total = SUM(T.[Sum])
FROM
	(SELECT 
		C.[Name],
		(1-ISNULL(O.Discount,0))*
		SUM(P.Price*OI.NumberOfItems) AS [Sum]
	FROM dbo.[Order] AS O
	INNER JOIN dbo.OrderItem AS OI
		ON O.Id = OI.OrderId
	INNER JOIN dbo.Product AS P
		ON P.Id = OI.ProductId
	INNER JOIN dbo.Customer AS C
		ON C.Id=O.CustomerId
	GROUP BY C.[Name], O.Discount) AS T

SELECT 
T.[Name],
SUM(T.[Sum])AS [Sum],
SUM(T.[Sum])/@total AS[Percentage]
FROM
(SELECT 
		C.[Name],
		(1-ISNULL(O.Discount,0))*
		SUM(P.Price*OI.NumberOfItems) AS [Sum]
	FROM dbo.[Order] AS O
	INNER JOIN dbo.OrderItem AS OI
		ON O.Id = OI.OrderId
	INNER JOIN dbo.Product AS P
		ON P.Id = OI.ProductId
	INNER JOIN dbo.Customer AS C
		ON C.Id=O.CustomerId
	GROUP BY C.[Name], O.Discount) AS T


