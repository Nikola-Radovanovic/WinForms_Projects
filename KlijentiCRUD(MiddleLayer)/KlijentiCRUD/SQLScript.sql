USE TSQL2012;
GO

IF (OBJECT_ID('dbo.Klijenti') IS NOT NULL) DROP TABLE dbo.Klijenti;
GO

CREATE TABLE dbo.Klijenti 
(
	KlijentId INT IDENTITY PRIMARY KEY NOT NULL,
	Naziv NVARCHAR(40) NOT NULL,
	Kontakt NVARCHAR(30) NOT NULL,
	Grad NVARCHAR(15) NOT NULL,
	Zemlja NVARCHAR(15) NOT NULL
);
GO

INSERT INTO dbo.Klijenti
(Naziv, Kontakt, Grad, Zemlja)
SELECT companyname, contactname, city, country
FROM Sales.Customers;
GO

-------------
---C-R-U-D---
-------------

--READ
CREATE PROC dbo.KlijentiRead
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	SELECT KlijentId, Naziv, Kontakt, Grad, Zemlja
	FROM dbo.Klijenti
	ORDER BY KlijentId DESC;
	RETURN 0
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER()
END CATCH
GO

--CREATE
CREATE PROC dbo.KlijentiInsert
@Naziv NVARCHAR(40),
@Kontakt NVARCHAR(30),
@Grad NVARCHAR(15),
@Zemlja NVARCHAR(15)
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	INSERT INTO dbo.Klijenti
	(Naziv, Kontakt, Grad, Zemlja)
	VALUES
	(@Naziv, @Kontakt, @Grad, @Zemlja);
	RETURN 0
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO

--UPDATE
CREATE PROC dbo.KlijentiUpdate
@KlijentId INT,
@Naziv NVARCHAR(40),
@Kontakt NVARCHAR(30),
@Grad NVARCHAR(15),
@Zemlja NVARCHAR(15)
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	UPDATE dbo.Klijenti
	SET Naziv = @Naziv,
		Kontakt = @Kontakt,
		Grad = @Grad,
		Zemlja = @Zemlja
	WHERE KlijentId = @KlijentId;
	RETURN 0
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO

--DELETE
CREATE PROC dbo.KlijentiDelete
@KlijentId INT
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	DELETE FROM dbo.Klijenti
	WHERE KlijentId = @KlijentId;
	RETURN 0
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO