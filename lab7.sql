
--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 
create view  Disp1(Sname,Cname)
as
	select s.St_Fname+' '+s.St_Lname as SFullName,c.Crs_Name
	from  [Student].[Student] s inner join [dbo].[Stud_Course] sc
	on sc.St_Id = s.[St_Id] and sc.Grade > 50
	inner join [course].[Course] c
	on c.[Crs_Id]= sc.Crs_Id

select * from Disp1

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 
create View View2
with encryption
as
	select T.[Top_Name],INS.[Ins_Name]
	from [dbo].[Topic] T inner join [course].[Course] C
	on T.[Top_Id] =C.[Top_Id]
	inner join [dbo].[Ins_Course] INSC
	on INSC.[Crs_Id]=C.[Crs_Id]
	inner join [dbo].[Instructor] INS
	on INS.[Ins_Id] = INSC.Ins_Id

sp_helptext  'View2'

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
create view View3
as
select [Ins_Name],[Dept_Name]
from[dbo].[Instructor] inner join [dbo].[Department]
on [Dept_Manager]= [Ins_Id]  and [Dept_Name] in ('SD' ,'Java')

select * from View3

--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;
create View View4
as
	select S.*
	from  [Student].[Student] S
	where St_Address in('cairo','Alex')
	with check option

select * from View4
insert into View4([St_Id],[St_Address]) values (255,'tanta')
delete from View4 where [St_Address] = 'tanta'

--5.	Create a view that will display the project name and the number of employees work on it. “Use Company DB”

use Company_SD
create view View5
as
select p.[Pname], count([ESSn]) as countEmp
from [dbo].[Works_for] inner join [dbo].[Project] p
on p.[Pnumber]=[Pno] 
group by p.[Pname]

select * from View5

--6.	Create the following schema and transfer the following tables to it 
--a.	Company Schema 
create schema Company
--i.	Department table (Programmatically)
alter schema Company transfer [dbo].[Departments]
--ii.	Project table (by wizard)
--b.	Human Resource Schema
create schema HR
--i.	  Employee table (Programmatically)
alter schema HR transfer [Company].[Employee]

--7.	Create index on column (manager_Hiredate) that allow u to cluster the data in table Department. What will happen?  - Use ITI DB
use ITI
create nonclustered index myindex7
on [dbo].[Department]([Dept_Manager])

--8.	Create index that allow u to enter unique ages in student table. What will happen?  - Use ITI DB
create unique index index8
on [Student].[Student]([St_Age])

--9.	Create a cursor for Employee table that increases Employee 
--salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
declare cursor9 Cursor
for select [Salary]
	from [HR].[Employee]
for update
declare @sal int
open cursor9
fetch cursor9 into @sal
while @@fetch_status=0
	begin
		if @sal>=3000
			update [Company].[Employee]
				set [Salary]=@sal*1.20
			where current of cursor9
		else
			update [Company].[Employee]
				set [Salary]=@sal*1.10
			where current of cursor9
		fetch cursor9 into @sal
	end
close cursor9
deallocate cursor9

--10.	Display Department name with its manager name using cursor. Use ITI DB
Declare cursor10 Cursor
for select d.Dept_Name ,  i.Ins_Name
	from Department d inner join Instructor i on i.Ins_Id = d.Dept_Manager
for read only
declare @deptname varchar(20) , @managername varchar (30)
open cursor10
Fetch cursor10 into @deptname, @managername
while @@FETCH_STATUS=0
begin
       select @deptname, @managername
		Fetch cursor10 into @deptname, @managername
   end
close cursor10
Deallocate cursor10

--11.	Try to display all instructor names in one cell separated by comma. Using Cursor . Use ITI DB
declare cursor11 Cursor
for select [Ins_Name]
	from  [dbo].[Instructor]

for read only
declare @input varchar(255)
declare @outpuut varchar(255)
open cursor11
fetch cursor11 into @input
select @outpuut = @input+' , '
while @@fetch_status=0
	begin
	
		fetch cursor11 into @input
		select @outpuut+=@input+' , '
	end
select @outpuut
close cursor11
deallocate cursor11


--12.	Try to generate script from DB ITI that describes all tables and views in this DB
-- SQL doesn't allow me
