use BilliardApp

-- Bảng người dùng
CREATE TABLE Users (
    UserId int primary key identity(1,1),
    account nvarchar(50),
    password nvarchar(50),
    role nvarchar(20)
);

-- Bảng thông tin người dùng
CREATE TABLE UserInfo (
    InfoId int primary key identity(1,1),
    fullname nvarchar(100),
    phonenumber nvarchar(15),
    email nvarchar(100)
);

-- Bảng bàn chơi
CREATE TABLE Tables (
    TableId int primary key identity(1,1),
    TableName nvarchar(50),
    Status nvarchar(20)
);

-- Bảng phiên chơi
CREATE TABLE Sessions (
    PhienId int primary key identity(1,1),
    TimeBegin datetime,
    TimeEnd datetime,
    TotalAmount decimal(10, 2),
    TableId int,
    UserId int,
    foreign key (TableId) references Tables(TableId),
    foreign key (UserId) references Users(UserId)
);

-- Bảng dịch vụ
CREATE TABLE Services (
    DichVuId int primary key identity(1,1),
    DichVuName nvarchar(100),
    Price decimal(10, 2)
);

-- Bảng thông tin phiên chơi
CREATE TABLE SessionDetails (
    DetailId int primary key identity(1,1),
    PhienId int,
    DichVuId int,
    Quantity int,
    Price decimal(10, 2),
    foreign key (PhienId) references Sessions(PhienId),
    foreign key (DichVuId) references Services(DichVuId)
);
