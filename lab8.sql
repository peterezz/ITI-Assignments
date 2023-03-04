--1.	Create a stored procedure without parameters to show the number of students per department name.[use ITI DB] 
create proc proc1
as
	select count([St_Id])
	from[Student].[Student]
	group by [Dept_Id]

proc1
--2.	Create a stored procedure that will check for the # of employees in the
--project p1 if they are more than 3 print message to the user “'The number
--of employees in the project p1 is 3 or more'” if they are less display a 
--message to the user “'The following employees work for the project p1'” in 
--addition to the first name and last name of each one. [Company DB] 

alter proc proc2
as
declare @NumOfEmp int 
select @NumOfEmp= count([ESSn])
from [dbo].[Works_for]
group by [Pno]
having [Pno]=100
if (@NumOfEmp>=3)
select 'The number of employees in the project p1 is 3 or more'
else if(@NumOfEmp<3)
begin
declare @Emp1 nvarchar(50)
declare @Emp2 nvarchar(50)

select top(1) @Emp1=[Fname],@Emp2=lead([Fname]) OVER(partition by  [Pno] ORDER BY [Pno])	  
	   from [dbo].[Works_for] inner join [HR].[Employee]
	   on [ESSn]=[SSN] and 
	    [Pno]=100
select 'The following employees work for the project p1: '+@Emp1 +', '+@Emp2 

end

proc2

--3.	Create a stored procedure that will be used in case there is an old
--employee has left the project and a new one become instead of him. The 
--procedure should take 3 parameters (old Emp. number, new Emp. number
--and the project number) and it will be used to update works_on table. [Company DB]

alter proc proc3 @OldEmpNum int, @NewEmpNumber int , @ProjectNum int
as
begin try
 update [dbo].[Works_for]
 set [ESSn] = @NewEmpNumber
 where [Pno] = @ProjectNum and [ESSn]=@OldEmpNum
 select 'it is ok'
end try
begin catch
select 'Error occare'
end catch

proc3 112233,968574,100


--4.	add column budget in project table and insert any draft values in it then 
--then Create an Audit table with the following structure 
alter trigger t4
on [dbo].[Project]
after update
as
if(update([budget]))
begin
declare @ProjectNo int
declare @OldBudget int
declare @NewBudget int
select @OldBudget = [budget] from deleted
select @ProjectNo=[Pnumber], @NewBudget=[budget] from inserted

insert into [dbo].[Audit] ([ProjectNo],[UserName],[ModifiedDate],[Budget_Old],[Budget_New])
values (@ProjectNo,suser_name(),getdate(),@OldBudget,@NewBudget)
end

update [dbo].[Project] set  [budget]= 360000 where [Pnumber]=100


--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--“Print a message for user to tell him that he can’t insert a new record in that table”
create trigger t5
on [dbo].[Departments]
instead of insert
as
select 'can’t insert a new record in that table'
insert into [dbo].[Departments]([Dname]) values ('nsjjs')

--6.	 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].
alter trigger [HR].t6
on [HR].[Employee]
after insert
as
if( format(getdate(),'MMMM') = 'March')
begin
rollback
end

insert into [HR].[Employee]([SSN],[Fname]) values (4555555,'dsdds')

--7.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note) where note will 
--be “[username] Insert New Row with Key=[Key Value] in table [table name]”
alter trigger [Student].c7
on [Student].[Student]
after insert
as 
declare @StdId int
select @StdId= [St_Id] from inserted
insert into [dbo].[Student_Audit]([Server_User_Name],[Date],[Note])
values (SUSER_NAME(),GETDATE(),CONCAT(SUSER_NAME(), ' Insert New Row with Key= ',@StdId, ' in table student'))

insert into [Student].[Student]([St_Id],[St_Fname]) values (25556666,'dsdsd')


--8.	 Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note) 
--where note will be“ try to delete Row with Key=[Key Value]”
alter trigger [Student].c8
on [Student].[Student]
 instead of delete
as 
declare @StdId int
select @StdId= [St_Id] from deleted
insert into [dbo].[Student_Audit]([Server_User_Name],[Date],[Note])
values (SUSER_NAME(),GETDATE(),CONCAT(SUSER_NAME(), ' try to delete Row with Key= ',@StdId, ' in table student'))

delete from [Student].[Student] where [St_Id]= 2556666

--Part2

--