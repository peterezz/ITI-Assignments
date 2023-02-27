create database Lab3

create table Instructor(
ID int primary key identity,
HireDate date,
Address varchar(50),
FirstName varchar(50),
LastName varchar(50),
BD date,
OverTime int,
Salary int default 3000,
NetSalary as (Salary + (OverTime*1000)),
age as(year(getdate())-year(BD)),

constraint c1 check(Address in('cairo ','alex ')),
constraint c2 check(Salary between 1000 and 5000),
constraint c3 unique(OverTime) ,




)


create table Course(
CID int primary key identity,
CName varchar(50),
Duration int,

)

create table Instructor_Teach_Course(
InstructorID int,
CourseID int
constraint c4 foreign key(InstructorID) references Instructor(ID),
constraint c5 foreign key(CourseID) references Course(CID)
)
create table Lab(
LID int primary key identity,
Location varchar(50),
Capacity int,
CourseID int,
constraint c6 check(Capacity<=20),
constraint c7 foreign key(CourseID) references Course(CID)
on delete cascade on update cascade

)

alter table Instructor add default getdate() for HireDate

alter table Course add constraint c8 unique(Duration)