insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Harry','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Peter','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Tom','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Bill','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Jay','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Jerry','123456','M',20,'13834567890','123@qq.com',GETDATE())
insert into Users(UserId,UserName,Password,Gender,Age,Phone,Email,LastUpdateTime)values(NEWID(), 'Cary','123456','M',20,'13834567890','123@qq.com',GETDATE())

insert into Product(ProductId,Name,Version,Price)values(NEWID(), 'Camera-Canon',  '5345262652765-1.2.0', 2500)
insert into Product(ProductId,Name,Version,Price)values(NEWID(), 'Apple-富士',    '4363646767764-4.1.0', 5)
insert into Product(ProductId,Name,Version,Price)values(NEWID(), 'Computer-雷神', '5363467668585-7.4.0', 6000)
insert into Product(ProductId,Name,Version,Price)values(NEWID(), '飞科剃须刀',    '6566364747544-5.2.0', 250)
insert into Product(ProductId,Name,Version,Price)values(NEWID(), 'book-C#',       '6363685565445-4.1.0', 80)

insert into Orders(OrderId,OrderDate,UserId)values(NEWID(), GetDate(),(select UserId from Users where UserName='Harry'))
insert into Orders(OrderId,OrderDate,UserId)values(NEWID(), GetDate(),(select UserId from Users where UserName='Peter'))
insert into Orders(OrderId,OrderDate,UserId)values(NEWID(), GetDate(),(select UserId from Users where UserName='Tom'))
insert into Orders(OrderId,OrderDate,UserId)values(NEWID(), GetDate(),(select UserId from Users where UserName='Jerry'))
insert into Orders(OrderId,OrderDate,UserId)values(NEWID(), GetDate(),(select UserId from Users where UserName='Cary'))

insert into OrderProduct(OrderId,ProductId,ProductNum,Detail)values(
(select top(1) OrderId from Orders),
(select ProductId from Product where Name = 'book-C#'),
5,
'<Name>Book</Name>'
)


select * from users;
select * from Orders;
select * from Product;
select * from OrderProduct;

exec sp_executesql N'DELETE FROM Orders WHERE OrderId = @p0',N'@p0 uniqueidentifier',@p0='3C85CC1F-7485-4D66-8F89-2088903B4AC4'
exec sp_executesql N'DELETE FROM Users WHERE UserId = @p0',N'@p0 uniqueidentifier',@p0='B0B86405-6633-4B3B-A044-66908B306A8D'
exec sp_executesql N'ProcDeleteOrder',N'@OrderId uniqueidentifier,@LastUpdateTime datetime',@OrderId='D971E697-6088-428D-A494-D404C2B3110E',@LastUpdateTime='2017-08-06 21:14:53.887'

exec ProcDeleteOrder @OrderId='D971E697-6088-428D-A494-D404C2B3110E',@LastUpdateTime='2017-08-06 21:51:56.483'



