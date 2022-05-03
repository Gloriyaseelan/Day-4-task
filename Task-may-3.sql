use trail 
go
create table Customer
(
CustomerID int,
CustomerName varchar(30),
EmailId varchar(30),
MobileNo varchar(20),
Constraint pk_CustID Primary Key(CustomerID)
)
select * from [dbo].[Customer]

create proc GetAllCustomers
as
select CustomerID,CustomerName,EmailId,MobileNo
from dbo.Customer

exec GetAllCustomers

create proc NewCustomer
@Cname varchar(20),
@email varchar(30),
@mob varchar(10)
as
insert into Customer(CustomerName,EmailId,MobileNo)
values(@Cname,@email,@mob)



