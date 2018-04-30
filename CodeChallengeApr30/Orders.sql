
create database CodeChallengeApr30;
go;

use CodeChallengeApr30;


create table Customers (
	Id int primary key,
	FirstName nvarchar(30),
	LastName nvarchar(30),
	CardNumber nvarchar(30)
);

create table Products (
	Id int primary key,
	ProductName nvarchar(100) not null,
	Price decimal
);

create table Orders (
	Id int primary key,
	CustomerId int not null
		references Customers(Id),
	ProductId int not null
		references Products(Id)
);

go;

insert into Customers(FirstName, LastName, CardNumber)
values (N'John', N'Smith', N'1234 1234 1234'), (N'Anne', N'Bee', N'4321 4321 4321'), (N'Bob', N'Gregg', N'123 123 123 123'), (N'Tina', N'Smith', N'456');

insert into Products(ProductName, Price)
values (N'iPhone', 200.00)


-- skipping ahead
-- Lookup tina's orders
select * from Orders as ord inner join Customers as cust on ord.CustomerId = cust.Id where FirstName = 'Tina' and LastName = 'Smith';

-- Get iPhone revenue
select sum(Price) from Orders as ord inner join Products as prod on prod.Id = ord.ProductId where ProductName = 'iPhone';