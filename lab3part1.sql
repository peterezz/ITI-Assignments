--1.	Display the Department id, name and id and the name of its manager.
select D.[Dnum],D.[Dname],E.[SSN],E.[Fname]+' '+E.[Lname] as managerName
from [dbo].[Departments] D inner join [dbo].[Employee] E
on E.[SSN]=D.MGRSSN

--2.	Display the name of the departments and the name of the projects under its control.
select D.Dname , P.Pname
from [dbo].[Departments] D inner join [dbo].[Project] P
on D.Dnum=p.Dnum
--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select E.Fname+' '+E.Lname as EmpName, D.*
from [dbo].[Employee] E inner join [dbo].[Dependent] D
on D.ESSN = E.SSN
--4.	Display the Id, name and location of the projects in Cairo or Alex city.
select [Pnumber],[Pname],[Plocation] 
from [dbo].[Project]
where[City]in ('Cairo ' , 'Alex ') 

--5.	Display the Projects full data of the projects with a name starts with "a" letter.
select *
from [dbo].[Project]
where [Pname] like 'a%'
--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from [dbo].[Employee]
where [Salary] between 1000 and 2000 and  [Dno] = 30

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select [Fname]+' '+[Lname]as EmpName
from [dbo].[Employee] Emp inner join [dbo].[Works_for] Work
on Emp.SSN = Work.ESSn
inner join [dbo].[Project] Pro
on Work.Pno = Pro.Pnumber and Work.Hours>=10 and Pro.Pname='AL Rabwah'

--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
select E.[Fname]+' '+E.[Lname] as EmpName, MGR.[Fname]+' '+MGR.[Lname] as MGRName
from [dbo].[Employee] E inner join [dbo].[Employee] MGR
on MGR.SSN = E.Superssn and CONCAT(MGR.Fname,' ',MGR.Lname) = 'Kamel Mohamed'
--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select  E.[Fname]+' '+E.[Lname] as EmpName,Pro.[Pname]
from [dbo].[Employee] E inner join [dbo].[Works_for] Work
on E.SSN = Work.ESSn
inner join [dbo].[Project] Pro
on Work.Pno = Pro.Pnumber
order by Pro.Pname 
--10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select [Pnumber],[Dname],[Lname],[Address],[Bdate]
from [dbo].[Project] P inner join [dbo].[Departments] D 
on P.Dnum = D.Dnum and P.City='Cairo '
inner join [dbo].[Employee] E
on E.SSN = D.MGRSSN
--11.	Display All Data of the managers
select  distinct( MGR.[Fname]+' '+MGR.[Lname]) as MGRName
from [dbo].[Employee] E inner join [dbo].[Employee] MGR
on MGR.SSN = E.Superssn 
--12.	Display All Employees data and the data of their dependents even if they have no dependents
select E.*,D.*
from [dbo].[Employee] E full outer join[dbo].[Dependent]  D
on E.SSN=D.ESSN
--13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into [dbo].[Employee] ([Fname],[Dno],[SSN],[Superssn],[Salary])values('peter',30,102672,112233,3000)
--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into [dbo].[Employee] ([Fname],[Dno],[SSN])values('Sam7',30,102660)
--15.	Upgrade your salary by 20 % of its last value.
update [dbo].[Employee]
set [Salary]=[Salary]+[Salary]*20/100
where [SSN]=102672



