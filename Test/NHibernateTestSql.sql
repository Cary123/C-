
    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[fk_user_order]') AND parent_object_id = OBJECT_ID('Orders'))
alter table Orders  drop constraint fk_user_order


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[fk_product_orderproduct]') AND parent_object_id = OBJECT_ID('OrderProduct'))
alter table OrderProduct  drop constraint fk_product_orderproduct


    if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[fk_order_orderproduct]') AND parent_object_id = OBJECT_ID('OrderProduct'))
alter table OrderProduct  drop constraint fk_order_orderproduct


    if exists (select * from dbo.sysobjects where id = object_id(N'Orders') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Orders

    if exists (select * from dbo.sysobjects where id = object_id(N'OrderProduct') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table OrderProduct

    if exists (select * from dbo.sysobjects where id = object_id(N'Product') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Product

    if exists (select * from dbo.sysobjects where id = object_id(N'Users') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Users

    create table Orders (
        OrderId uniqueidentifier not null unique,
       OrderDate datetime not null,
       UserId UNIQUEIDENTIFIER not null,
       primary key (OrderId)
    )

    create table OrderProduct (
        OrderId UNIQUEIDENTIFIER not null,
       ProductId UNIQUEIDENTIFIER not null,
       primary key (ProductId, OrderId)
    )

    create table Product (
        ProductId uniqueidentifier not null unique,
       Name nvarchar not null,
       Version nvarchar null,
       Price float null,
       primary key (ProductId)
    )

    create table Users (
        UserId uniqueidentifier not null unique,
       UserName nvarchar not null unique,
       Password nvarchar not null,
       Gender char not null,
       Age int not null,
       Phone nvarchar not null,
       Email nvarchar not null,
       LastLoginTime datetime not null,
       primary key (UserId)
    )

    alter table Orders 
        add constraint fk_user_order 
        foreign key (UserId) 
        references Users

    alter table OrderProduct 
        add constraint fk_product_orderproduct 
        foreign key (ProductId) 
        references Product

    alter table OrderProduct 
        add constraint fk_order_orderproduct 
        foreign key (OrderId) 
        references Orders
