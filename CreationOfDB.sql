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

	----Tables
		CREATE TABLE Customers
	(
	customer_id int NOT NULL identity(1,1)  PRIMARY KEY,
	customer_First_name varchar(50) NOT NULL,
	customer_Last_name varchar(50) NOT NULL,
	ID_Number varchar(13) unique not null,
	Gender varChar(1) not null Default('U'),
	Email_Address varchar(320),
	Phone varchar(25) Not Null
	
	
	);
	go

	CREATE TABLE Bookings
	(
	Booking_ID int NOT NULL identity(1,1)  Primary key,
	Flight_Details varchar(50) not null,
	Seat_Number int unique not null,
	Price money not null,
	Customer_ID int NOT NULL  Foreign KEY References Customers(Customer_ID)
	);
	go



	CREATE TABLE Waiting_List
	(
	Waiting_ID int Not Null identity(1,1)  PRIMARY KEY,
	Booking_ID int NOT NULL  Foreign key references Bookings(Booking_ID)
	);
	go

	CREATE TABLE Planes
	(
	Plane_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Plane_name varchar(50) NOT NULL,
	Plane_model varchar(50) Not null,
	);
	go



	Create TABLE Services_
    (
	Service_id int NOT NULL identity(1,1) Primary KEY,
	service_Details char(50) NOT NULL
	
	);

	go





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

	CREATE TABLE Emp_schedule
	(
	Employee_Flight_id int not null  identity(1,1) Primary key,
	Flight_Details varchar(50) not null,
	Time_of_Departure datetime,
	Time_of_arrival datetime,
	Employee_id int not null Foreign key References Employees(Employee_id),
	);
	go

	CREATE TABLE Maintenance
	(
	Maintenance_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Employee_ID int not null Foreign key references Employees(Employee_id),
	Plane_ID int not null Foreign key references Planes(Plane_id),
	Maintenance_Last_performed datetime,
	Maintenance_Cost money not null
	);
	go

	CREATE TABLE Employee_services
	(
	Service_id int NOT NULL Foreign key references Services_(service_id),
	Employee_ID int not null Foreign key references Employees(Employee_id),
	Service_Availability Varchar(30) not null,
	
	);

	go

	CREATE TABLE Flight
	(
	Flight_id int NOT NULL identity(1,1)  PRIMARY KEY,
	Flight_Location varchar(50) not null,
	Booking_ID int NOT NULL   Foreign KEY References Bookings(Booking_ID),
	Employee_Flight_id int not null   Foreign key References emp_schedule(Employee_Flight_Id),
	Plane_ID int NOT NULL   foreign key references Planes(Plane_id),
	Time_of_Departure datetime,
	Time_of_arrival datetime
	
	);


	
	go
