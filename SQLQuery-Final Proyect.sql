CREATE DATABASE Final_Proyect;

--drop database Final_Proyect;

USE Final_Proyect;

CREATE TABLE Users_of_System (
	Id int Identity (1,1) Primary Key NOT NULL,
	LogName nvarchar (80) NOT NULL,
	LogPassword nvarchar (15) NOT NULL,
	Name nvarchar (80) NOT NULL,
	LastName nvarchar (80) NOT NULL,
	SuperUser nvarchar(5) NOT NULL,
	Email nvarchar (80) NOT NULL
);

--drop table Users_of_System
--drop procedure SP_List_Users;

INSERT INTO Users_of_System (LogName, LogPassword, Name, LastName, SuperUser, Email)
VALUES('Admin','admin','Jerahmeel','Plasencia','true','20209494@itla.edu.do');

INSERT INTO Users_of_System (LogName, LogPassword, Name, LastName, SuperUser, Email)
VALUES('Zekkki','aaaa','Ezequiel','Vasquez','true','20209898@itla.edu.do');

INSERT INTO Users_of_System (LogName, LogPassword, Name, LastName, SuperUser, Email)
VALUES('EdwardXD','poco','Edward','De la Rosa','false','20195353@itla.edu.do');

select * from Users_of_System;

--SP

--
CREATE PROCEDURE SP_Confirm_Login
@userLogin nvarchar(80), @passwordLogin nvarchar(15)
AS
BEGIN
SELECT * FROM Users_of_System
WHERE @userLogin = LogName and @passwordLogin = LogPassword
END;
--

--Create User--
CREATE PROCEDURE SP_Create_User
@username nvarchar(50), @password nvarchar(15), @name nvarchar(80), @lastname nvarchar(80), @superuser nvarchar(5), @email nvarchar(80)
AS
BEGIN
INSERT INTO Users_of_System (LogName, LogPassword, Name, LastName, SuperUser, Email)
VALUES (@username, @password, @name, @lastname, @superuser, @email);
END;

--Edit User--
CREATE PROCEDURE SP_Edit_User
@id int,@username nvarchar(50), @password nvarchar(15), @name nvarchar(80), @lastname nvarchar(80), @superuser nvarchar(5), @email nvarchar(80)
AS
BEGIN
UPDATE Users_of_System
SET LogName = @username, LogPassword = @password, Name = @name, LastName = @lastname, SuperUser = @superuser, Email = @email
WHERE Id = @id
END;

--Delete User--
CREATE PROCEDURE SP_Delete_User
@id int
AS
BEGIN
DELETE FROM Users_of_System WHERE Id = @id
END;

--List Date--
CREATE PROCEDURE SP_List_Users
AS
BEGIN
Select * From Users_of_System
END;




	--SECOND TABLE--


--
--Dates Table
CREATE TABLE Dates (
	Id int Identity (1,1) Primary Key NOT NULL,
	Name nvarchar (80) NOT NULL,
	LastName nvarchar (80)  NOT NULL,
	Career nvarchar (80) NOT NULL,
	Email nvarchar (80) NOT NULL,
	Building nvarchar (80) NOT NULL,
	DateAndHour datetime NOT NULL,
	Classroom nvarchar (80) NOT NULL,
	Reason nvarchar (80) NOT NULL
);

INSERT INTO Dates (Name, LastName, Career, Email, Building, DateAndHour, Classroom, Reason)
VALUES ('Gean','Rodríguez','Software','20199090@itla.edu.do','Uno','08-21-2022','1-A1','Conocer el campus');


INSERT INTO Dates (Name, LastName, Career, Email, Building, DateAndHour, Classroom, Reason)
VALUES ('Perla','Montero','Software','20198888@itla.edu.do','Tres','08-21-2022','3-A1','Conocer los labs');

select * From Dates;


--SP


--Search Date--
CREATE PROCEDURE SP_Search_Date_B
@search nvarchar(80)
AS
BEGIN
SELECT * FROM Dates
WHERE Building like @search + '%'
END;

--Search Date--
CREATE PROCEDURE SP_Search_Date_C
@search nvarchar(80)
AS
BEGIN
SELECT * FROM Dates
WHERE Classroom like @search + '%'
END;

--Drop procedure SP_Search_Date_C;

--Drop procedure SP_Search_Date_B;

--Create Date--
CREATE PROCEDURE SP_Create_Date
@name nvarchar(80), @lastname nvarchar(80), @career nvarchar(80), @email nvarchar(80), @building nvarchar(80), @date datetime, @classroom nvarchar(80), @reason nvarchar(80)
AS
BEGIN
INSERT INTO Dates (Name, Lastname, Career, Email, Building, DateAndHour, Classroom, Reason)
VALUES (@name, @lastname, @career, @email, @building, @date, @classroom, @reason);
END;

--Edit Date--
CREATE PROCEDURE SP_Edit_Date
@id int, @name nvarchar(80), @lastname nvarchar(80), @career nvarchar(80), @email nvarchar(80), @building nvarchar(80), @date datetime, @classroom nvarchar(80), @reason nvarchar(80)
AS
BEGIN
UPDATE Dates
SET Name = @name, LastName = @lastname, Career = @career, Email = @email, Building = @building, DateAndHour = @date, Classroom = @classroom, Reason = @reason
WHERE Id = @id
END;

--Delete date--
CREATE PROCEDURE SP_Delete_Date
@id int
AS
BEGIN
DELETE FROM Dates WHERE Id = @id
END;

--List Date--
CREATE PROCEDURE SP_List_Date
AS
BEGIN
Select * From Dates
END;



		--BUILT AND CLASSROOM TABLE--

--
CREATE TABLE Building(
	Id int Identity (1,1) Primary Key NOT NULL,

	built nvarchar (80) NOT NULL
);


CREATE TABLE Classroom(
	Id int Identity (1,1) Primary Key NOT NULL,
	classroom nvarchar(80) NOT NULL
);

