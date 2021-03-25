	USE master
GO
if exists (select * from sysdatabases where name='DBpremier_service_solutions') ----Uses sysdatabases And master to check if DBpremier_service_solutions already exists and drops it if it does.
		drop database DBpremier_service_solutions
go
	
	

	---Creates Database DBpremier_service_solutions

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE DBpremier_service_solutions
  ON PRIMARY (NAME = N''DBpremier_service_solutions'', FILENAME = N''' + @device_directory + N'DBpremier_service_solutions.mdf''),
  FILEGROUP SECONDARY(NAME = N''DBpremier_service_solutions_Backup'', FILENAME = N''' + @device_directory + N'DBpremier_service_solutions_Backup.ndf'')
  LOG ON (NAME = N''DBpremier_service_solutions_log'',  FILENAME = N''' + @device_directory + N'DBpremier_service_solutions.ldf'')')
go

ALTER DATABASE DBpremier_service_solutions SET AUTO_SHRINK ON 
ALTER DATABASE DBpremier_service_solutions SET RECOVERY SIMPLE
GO


	SET QUOTED_IDENTIFIER ON
	go

	SET ANSI_NULLS ON
    go

	use DBpremier_service_solutions
	go

	----Tables--------------------------------

	CREATE TABLE Business
	(
	Business_id int not null  identity(1,1) Primary key,
	Business_Name varchar(255) not null,
	Phone_Number varchar(255) not null,
	Address varchar(255) not null,
	);
	go


	CREATE TABLE Packages
	(
	Package_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Package_Priority varchar(255) NOT NULL,
	Package_Status varchar(255) not null,
	);
	go

	CREATE TABLE tbl_Services
	(
	Service_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Package_id int NOT NULL  Foreign KEY References Packages(Package_id),
	Service_Details varchar(255) NOT NULL,
	Service_Status varchar(255) not null,
	);
	go

	CREATE TABLE Contracts
	(
	Contract_id int NOT NULL identity(1,1)  Primary key,
	Contract_Details varchar(255) not null,
	Contract_Start_Date date not null,  --- change in ERD
	Contract_End_Date date not null,
	Contract_Status varchar(255) not null,  --- change in ERD
	Package_id int NOT NULL  Foreign KEY References Packages(Package_id)
	);
	go

		CREATE TABLE Clients
	(
	Client_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Client_First_name varchar(255) NOT NULL,
	Client_Last_name varchar(255) NOT NULL,
	BusinessID int Foreign KEY References Business(Business_id),
	Gender varChar(1) not null Default('U'),
	Email_Address varchar(320),
	Client_Address varchar(255) Not Null,
	Contract_id int Foreign KEY References Contracts(Contract_id)
	
	);
	go

	

	----- here is where you should start working


	CREATE TABLE Employees
	(
	Employee_id int NOT NULL identity(1,1) PRIMARY KEY,
	First_name varchar(50) NOT NULL,
	Last_name varchar(50) NOT NULL,
	Title varchar(50) Not null,
	Phone varchar(25) Not Null,
	Gender varChar(1) Default('U'),
	ID_Number varchar(13) unique not null,
	salary money not null,
	

	);
	go

	


