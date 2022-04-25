create database Activity
use Activity 
go
create table prodList
(
productID int identity(200,1),
prodName varchar(20),
price money,
DateOfManufacture date,
ExpDate date
)
drop table prodList
select * from prodList

insert into ProdList values('Hide And Seek',25,GETDATE(),30+GETDATE())
insert into ProdList values('Happy Happy',20,GETDATE(),30+GETDATE())
insert into ProdList values('Little Hearts',10,GETDATE(),30+GETDATE())
insert into ProdList values('Oreo',30,GETDATE(),30+GETDATE())


delete from prodList
alter table prodList
add constraint pk_prodList primary key(productID)
select * from prodList

select* /*cusName,gender,DOB,Contactno,emailID,cityname*/ from cusList where cusName='maya'

select * from cusList where cusName='juck'

create table cusList
(
customerID int identity(1,1),
cusName varchar(20),
gender varchar(1),
DOB varchar(20),
contactno varchar(10),
emailID varchar(20),
cityname varchar(20),
constraint pk_cusID primary key(customerID)
)
drop table cusList

select dateadd(YYYY,DOB,GETDATE()) from cusList
insert into cusList values('juck','M',getDATE(),'2352342333','luke@gmail','chennai')
insert into cusList values('riya','F','21/11/2000','1234567890','riya@gmail','banglore')
insert into cusList values('maya','M','23/11/2000','9876543213','maya@gmail','hydrabad')
insert into cusList values('jack','F','24/11/2000','2456789087','jack@gmail','coimbatore')
insert into cusList values('glo','f','23 jan','233534634','vadvav','svvvsd')


select * from cusList
where DOB='20-11-2000'

alter table cusList


drop table cusList

create table purchase
(
billNo int identity(3000,1),
quantity int,
TotalAmount int,
customerID int,
productID int

)
select pur.productID,customerID,prodName,pur.TotalAmount
from prodList plist
join purchase pur
on plist.productID=pur.productID


alter table cusList
add constraint fk_CuID foreign key (customerID) references cusList(customerID)
alter table prodList
add constraint fk_proID foreign key (productID) references prodList(productID)

select * from purchase

drop table purchase


select * from cusList
select customerID,cusName,gender,DOB,contactno,emailID,cityname from cusList 
where cusName like 'jill'
