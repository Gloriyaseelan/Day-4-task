

use trail
go
create table tbl_task1
(
StudentID int identity(1,1),
FirstName varchar(20),
LastName varchar(20),
Age int,

DOB varchar(10),
Gender char(1),

SchoolName varchar(50),
CollegeName varchar(50),
Qualification varchar(20),

Cgpa varchar(20),
EmailID varchar(50),
ContactNo varchar(10)
)

alter table tbl_task1
add constraint CK_Ages check(Age>=18)

alter table tbl_task1
add constraint ck_quali check(qualification in('BE','BTECH','BCOM','BSC'))

alter table tbl_task1
add constraint ck_gender check(gender in('M','F'))

insert tbl_task1 values('swe','G',21,'20/11/2000','F','CMHSS','SJIT','BE',76,'glo@gmail.com','9150451094')
select * from tbl_task1

drop table tbl_task1
