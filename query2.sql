use AdventureWorks2019
go
------------task1-----------------
select * from person.person
select title,FirstName,LastName
from Person.Person
where Title is not null

------------------------task2---------------
select FirstName,LastName
from Person.Person
where FirstName like '%a%'
or LastName like '%a%'

--------------------------task3------------------

select Sales.CountryRegionCurrency.CurrencyCode,name
from sales.Currency,sales.CountryRegionCurrency



------------------task4---------------------
select * into HR_dept from HumanResources.Department

select * from HR_dept


------------------task5----------------------

create table tbl_task5
(
SNo int identity(1,1),
name varchar(20),
age int,
gender char(1),
DOB varchar(10),
contactNo varchar(10)
)

insert into  tbl_task5 values('gloriya',21,'F','20/11/2000','9150451094')
select * from tbl_task5


------------------------task6------------------

select dadd.BusinessEntityID, dadd.AddressTypeID,dept.DepartmentID
from HumanResources.Department dept
join person.businessEntityAddress dadd
on dept.departmentid=dadd.businessEntityID

----------------task7------------------------------------

select distinct  GroupName
from HumanResources.Department

---------------task8-----------------

select * from Production.ProductCostHistory
select pro.StandardCost,sum(listprice) sumlist,sum(pro.standardcost+listprice) sumcost
from Production.Product pro 
join Production.ProductCostHistory phis
on pro.ProductID=phis.ProductID
group by pro.StandardCost


------------------task9------------------
select DATEDIFF(YY,startdate,enddate) as YearsOnRole
from HumanResources.EmployeeDepartmentHistory

--------------------------task 10-------------------------
select sum(salesQuota)
from Sales.SalesPersonQuotaHistory
where salesQuota>5000 and salesQuota<100000
group by salesQuota

-----------------------task 11---------------------

select max(taxrate) as MaximumTaxRate
from Sales.SalesTaxRate
 
 --------------------task 12------------------

 select dhis.BusinessEntityID,dept.DepartmentID,ShiftID
 from HumanResources.Employee emp
 join HumanResources.EmployeeDepartmentHistory dhis
 on emp.BusinessEntityID=dhis.BusinessEntityID
 join HumanResources.Department dept
 on dept.DepartmentID=dhis.DepartmentID
 select BirthDate,getdate() as currentDate,DATEDIFF(yy,birthdate,getdate()) as age
 from HumanResources.Employee

------------------------task 13---------------------

create view task12
as 
select BirthDate,GETDATE() as currentDate,DATEDIFF(yy,BirthDate,getdate()) as age
from HumanResources.Employee
go
select * from task12

-------------------------------------task 14-----------------------------
select count(*)
from HumanResources.Department,HumanResources.Employee,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory,HumanResources.Shift

---------------------------task 15--------------------
select max(rate) as maxsalary,name 
from HumanResources.EmployeePayHistory epay
join HumanResources.EmployeeDepartmentHistory ehis
on epay.BusinessEntityID=ehis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=ehis.DepartmentID
group by name

-----------------------------task 16------------------
select firstName,Middlename,title,badd.BusinessEntityID
from Person.BusinessEntityAddress badd
left outer join Person.Person per
on per.BusinessEntityID=badd.BusinessEntityID
where title is not null


--------------------task 17-------------------
select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and LocationID=50

------------task 18----------------------------------
select pin.LocationID,Shelf,name 
from Production.ProductInventory pin
join Production.Location plo
on pin.LocationID=plo.LocationID

-----------------------------task 19-----------------------

select AddressID,AddressLine1,AddressLine2,padd.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince spro
join Person.Address padd
on spro.StateProvinceID=padd.StateProvinceID

-------------task 20-------------------
select sum(subtotal),sum(taxamt)
from sales.CountryRegionCurrency curr
join Sales.SalesTerritory ster
on curr.CountryRegionCode=ster.CountryRegionCode
join Sales.SalesOrderHeader shead
on ster.TerritoryID=shead.TerritoryID
group by ster.TerritoryID
























































































