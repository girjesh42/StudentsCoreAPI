create database StudentsDb
--drop table Students
use StudentsDb
create table Students(
SId int primary key identity,
SName nvarchar(50) not null,
SAge int not null,
SCourse nvarchar(50) not null,
SEmail nvarchar(100) not null,
SContact nvarchar(10) not null
)
select*from Students
Insert into Students values ('Ravi Kumar',25,'.Net','Ravi23@gmail.com','7546983215')
Insert into Students values ('Sanjay Sikhawat',22,'Full Stack','sanja54564@gmail.com','8457962154')
Insert into Students values ('Ramesh',23,'Mean Stack','rames65421@gmail.com','7951364456')
Insert into Students values ('Salman khan',45,'Testing','Salman84656@gmail.com','8456212365')
Insert into Students values ('Surbhi',24,'.Net','surbhi5654@gmail.com','7965412589')




