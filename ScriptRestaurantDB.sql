IF DB_ID('RestaurantDB') IS NULL 
	CREATE DATABASE RestaurantDB
GO

USE RestaurantDB
GO

--======================================================
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Status] [varchar](10) DEFAULT '',
	[Role] [nvarchar](50),
	PRIMARY KEY (UserName)
	)
GO

ALTER TABLE [dbo].[Users]    
	ADD CONSTRAINT [Users_Role] check ([Role] IN (N'Khách hàng', N'Nhân viên', N'Quản lý'))
ALTER TABLE [dbo].[Users] 
	ADD CONSTRAINT [Users_Password] check ('Password' is not null)
GO

--======================================================

INSERT INTO [dbo].[Users] ([UserName], [Password], [Role]) VALUES 
	('admin', '123', N'Quản lý'),
	('user1', '111', N'Khách hàng')
GO



-------GetUser---------
SELECT Username, Password, Role
FROM Users 
WHERE Username = @username AND Password = @password

--------CREATE TABLE EMPLOYEES--------------
GO
CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Salary DECIMAL(18,2) NOT NULL,
    WorkYears INT NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

DROP TABLE Employees


-------------INSERT DATA-------------------
INSERT INTO Employees (Name, Salary, WorkYears, Role) VALUES
(N'Lê Gia Hân', 50000.00, 5, N'Quản lý'),
(N'Sapo Ngonngon', 45000.00, 3, 'Developer'),
(N'ZaaHann', 40000.00, 2, 'Designer')

INSERT INTO Employees (Name, Salary, WorkYears, Role) VALUES
(N'Jimin',27050.00,1,N'Coder')


---LẤY DS NHÂN VIÊN------
GO
CREATE PROC us_procLogin
	@user varchar(50),
	@pass varchar(50)
AS
BEGIN
	SELECT UserName, Password, Status, Role
	FROM Users
	WHERE UserName=@user AND Password=@pass
END


--XÓA NHÂN VIÊN----
DELETE 
FROM Employees WHERE Id = @EmployeeId;

--Thêm nhân viên------
INSERT INTO Employees (Name, Salary, WorkYears, Role) VALUES (@Name, @Salary, @WorkYears, @Role)




