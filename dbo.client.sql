CREATE TABLE [dbo].[client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Fname] NCHAR(10) NULL, 
    [Sname] NCHAR(10) NULL, 
    [DOB] NCHAR(10) NULL, 
    [Address] NCHAR(10) NULL, 
    [Email] NCHAR(10) NULL, 
    [city] NCHAR(10) NULL, 
    [Med] NCHAR(10) NULL, 
    [Alergies] NCHAR(10) NULL, 
    [NGP] NCHAR(10) NULL, 
    [AGP] NCHAR(10) NULL, 
    [TPlan] NCHAR(10) NULL
)
