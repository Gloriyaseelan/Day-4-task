 use AdventureWorks2019
 go

---------------------task1------------------------
SELECT COUNT(BusinessEntityID)
FROM Person.Person

SELECT SUM(BusinessEntityID)
FROM Person.Person
SELECT DATEDIFF(year, '2009-01-07 00:00:00.000', '2009-01-09 00:00:00.000') AS ModifiedDate
select ModifiedDate from Person.PersonPhone


SELECT DATEADD(year, 1, '2009-01-07 00:00:00.000') AS ModifiedDate

SELECT CONVERT(float, 25.65)
SELECT CONVERT(int, 25.65)
 
 select * from HumanResources.Employee
 select LEFT(JobTitle,BusinessEntityID) as Employee from HumanResources.Employee


 select len(JobTitle) from HumanResources.Employee


 SELECT REVERSE(JobTitle) from HumanResources.Employee
 ------------------task2----------------------------------------
 select ModifiedDate,'$'+convert(varchar,EndOfDayRate) as PaymentAmount
from Sales.CurrencyRate
-----------------task3------------------------------------------------------------
create table tbl_student
(
sno int,stuname varchar(20),stuage int
)
alter table tbl_student
add gender char(1)
select * from tbl_student

alter table tbl_student
add mobileno int
insert into tbl_student
values(1,'CAM',19,'M',45246129)
alter table tbl_student
alter column mobileno char(10)
create view vw_ss
as
select [sno],[stuname],[stuage] 
from  dbo.tbl_student
go
select * from vw_ss
insert into tbl_student
values(2,'ABI',19,'M',5629877986)

--------------------------------task4----------------------

use trail
go
select * from dbo.tbl_just
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'max','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name=@name

task1_sp 1,19,'max'
create proc taskdel_sp
@sno int
as
delete from tbl_just where sno=@sno
taskdel_sp1
----------------------------Task5-------------------
select Name , DaysToManufacture
from Production.Product
where DaysToManufacture in (select DaysToManufacture from Production.Product where Name='blade') 

-----------------task6---------------------------
select Name
from production.product
where name like '%all%' or name like '%any%' or name like'%some%'

select max(Weight) as maxweight,productModelID
from Production.Product
group by ProductModelID

----------------------task7---------------------------

select firstname,lastname
from person.person
select name
from sales.salesTerritory sst
join sales.salesTerritoryID=sst.TerriroryID
select max(salesLastYear),Name
from Sales.SalesTerritory
group by name