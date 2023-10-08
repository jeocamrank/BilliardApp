create database BilliarApp

CREATE TABLE Users (
    UserId int primary key identity(1,1),
    account nvarchar(50),
    password nvarchar(50),
	email nvarchar(50),
    role nvarchar(20)
);