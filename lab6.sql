--1.	 Create a scalar function that takes date and returns Month name of that date.
create function SelectMonth(@date datetime)
returns  varchar(30)
as 
begin
declare @month varchar(30)
select @month=Month(@date)
return @month
end

select dbo.SelectMonth(getdate())

--2.	 Create a multi-statements table-valued function that takes 2 integers
--and returns the values between them.
create function GetBett(@x int, @y int)
returns @t table (
VarNum int
)
as
begin 
--declare @i int = @x + 1
if @x < @y begin
while (@x < @y)
begin
set @x += 1
insert @t 
select @x
end

end

else if @x > @y begin
--declare @j int = @y + 1

while @y < @x
begin
insert @t 
select @y
set @y += 1
end

end

return
end

Select * from dbo.GetBett(10,20)

--3.	 Create inline function that takes Student No and returns 
--Department Name with Student full name.
create function GetStdData(@StdNum int)
returns  table
as
return(
select S.St_Fname+' '+S.St_Lname as StdFullName,D.Dept_Name
from Student S inner join Department D
on D.Dept_Id = S.Dept_Id 
where S.St_Id=@StdNum
)


select * from GetStdData(2)

--4.	Create a scalar function that takes Student ID and returns a message to user 
--a.	If first name and Last name are null then display 'First name & last name are null'
alter function DisplayMSGA( @StdId int)
returns varchar(450)
as
begin
declare @FirstName varchar(450)
declare @LastName  varchar(450)
select @FirstName=S.St_Fname,@LastName=S.St_Lname
from Student S
where S.St_Id = @StdId
if (@FirstName='' and @LastName='')
  return 'First name & last name are null'
else if(@FirstName ='')
  return 'first name is null'
  else if(@LastName ='')
  return 'last name is null'
  else
  return 'First name & last name are not null'
  return ''
end

select dbo.DisplayMSGA(14)

--5.	Create inline function that takes integer which represents manager ID and displays department name,
--Manager Name and hiring date 
alter function DisplayDepData(@MGRID int)
returns table
as
return(
select D.Dept_Name,I.Ins_Name,D.Manager_hiredate
from Department D inner join Instructor I
on I.Ins_Id = D.Dept_Manager
where D.Dept_Manager = @MGRID
)

select * from DisplayDepData(10)

--	6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function
create function DisplayName(@Name varchar(50))
returns @t table(
StdName varchar(250)
)
as
begin
if(@Name ='first name')
 insert into @t
 select ISNULL( S.St_Fname,'name is empty')
 from Student S
 else if(@Name ='last name' )
  insert into @t
 select ISNULL( S.St_Lname,'name is empty')
 from Student S
  else if(@Name ='full name' )
  insert into @t
 select ISNULL( S.St_Fname+' '+S.St_Lname,'name is empty')
 from Student S
 return
 end

 select * from DisplayName('full name')

 --7.	Write a query that returns the Student No and Student first name without the last char
 create function GetStudentNo_Fnam()
 returns table
 as
 return(
  select SUBSTRING(S.St_Fname,1,LEN(S.St_Fname)-1) as StName,S.St_Id
  from Student S
 )
 select * from GetStudentNo_Fnam()

 --8.	Wirte query to delete all grades for the students Located in SD Department 
 update [dbo].[Stud_Course]
 set Grade = null
 where [St_Id] in (select s.St_Id from Student s where s.Dept_Id=10)

 --9.	Using Merge statement between the following two tables [User ID, Transaction Amount]
 create table LastT
(
 id int,
 MyValue int
)

create table DailyT
(
 id int primary key identity,
 Val int
)

insert into DailyT values (1000)
insert into DailyT values (2000)
insert into DailyT values (1000)


Merge into LastT as T
using DailyT as S
on T.id=S.id
when matched then
	update 
		Set T.MyValue =S.Val
when not matched then
	insert 
	values(S.id,S.Val);

--10.	Try to Create Login Named(ITIStud) who can access Only student and 
--Course tables from ITI DB then allow him to select and insert data into tables and deny Delete and update
create schema Student

create schema course
alter schema Student transfer Student
alter schema course transfer Course


