CREATE TABLE [dbo].[Registration]
(
	[Id] INT NOT NULL , 
    [firstname] NVARCHAR(50) NOT NULL, 
    [lastname] NVARCHAR(50) NOT NULL, 
    [username] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [contact] NVARCHAR(50) NOT NULL, 
    [role] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY ([username])
)
