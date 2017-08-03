     
drop table If Exists [OrderProduct]
Create table OrderProduct
(
OrderId uniqueidentifier,
ProductId uniqueidentifier,
Details xml,
primary key(OrderId, ProductId),
)

DROP TABLE IF EXISTS [Order]
create table [Order](
OrderId uniqueidentifier primary key default NewID(),
UserId uniqueidentifier,
OrderDate datetime not null,
)

DROP TABLE  IF EXISTS [Product]
create table Product(
ProductId uniqueidentifier primary key default NewID(),
Name nvarchar(100) not null,
Version nvarchar(100),
Price float not null
)

DROP TABLE  IF EXISTS [Users]
create table [Users](
UserId uniqueidentifier primary key default NewID(),
Username nvarchar(100) unique,
Password nvarchar(100) not null,
Gender char(2) not null,
Age int,
Phone nvarchar(100),
Email nvarchar(100),
LastLoginTime datetime
) 

alter table [Order] drop constraint fk_001
alter table [Order] drop constraint fk_002
alter table [OrderProduct] drop constraint fk_003

alter table [Order] add constraint fk_001 foreign key(UserId) references [Users](UserId)
alter table [OrderProduct] add constraint fk_002 foreign key(ProductId) references Product(ProductId)   
alter table [OrderProduct] add constraint fk_003 foreign key(OrderId) references [Order](OrderId)
--INSERT INTO [Users] (UserName, Password, Gender, Age, Phone, LastLoginTime) VALUES ('Joseph','123456', 'M', 22, null, '2017/8/2 22:19:45')
--Select * from [Users]