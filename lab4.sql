--1.	Display (Using Union Function)
--a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
select [Dependent_name],[Sex]
from [dbo].[Dependent] where [Sex]='f'
union 
select [Fname]+' '+[Lname] ,[Sex]
from [dbo].[Employee]
where [Sex]= 'f'

--b.	 And the male dependence that depends on Male Employee.
select [Dependent_name],[Sex]
from [dbo].[Dependent] where [Sex]='m'
union 
select [Fname]+' '+[Lname] ,[Sex]
from [dbo].[Employee]
where [Sex]= 'm'

--2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select [Pname],sum([Hours]) as totalHR
from [dbo].[Project]inner join [dbo].[Works_for]
on [Pno]=[Pnumber]
group by [Pname]

--3.	Display the data of the department which has the smallest employee ID over all employees' ID.
select *
from[dbo].[Departments] inner join [dbo].[Employee]
on [Dno]=[Dnum]
where [SSN]= (select min([SSN]) from [dbo].[Employee])

--4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select [Dname],max([Salary]) as maxSalary,min([Salary]) as minSalary,AVG([Salary]) as avgSalary
from [dbo].[Departments] inner join [dbo].[Employee]
on [Dno]= [Dnum]
group by [Dname]

--5.	List the full name of all managers who have no dependents.
select  (M.[Fname]+' '+M.[Lname]) as MGRFullName, M.[SSN]
from [dbo].[Employee] M inner join [dbo].[Employee] E
on M.SSN = E.Superssn 
where M.SSN not in (select distinct([ESSN]) from [dbo].[Dependent])




--6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
select count([SSN]) as EmpNum,[Dname],[Dnum]
from [dbo].[Departments] inner join [dbo].[Employee]
on [Dno]=[Dnum]
group by [Dname],[Dnum]
having Avg([Salary])<(select Avg([Salary]) from[dbo].[Employee] )

--7.	Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
select [Fname]+' '+[Lname] as EmpName,[Pname]
from [dbo].[Employee] inner join [dbo].[Works_for]
on [ESSn]=[SSN]
inner join [dbo].[Project]
on [Pnumber]=[Pno]
order by [Dno],[Lname],[Fname]

--8.	Try to get the max 2 salaries using sub query
select
  (SELECT MAX(Salary) FROM Employee) maxsalary,
  (SELECT MAX(Salary) FROM Employee
  WHERE Salary NOT IN (SELECT MAX(Salary) FROM Employee )) as [2nd_max_salary]

--9.	Get the full name of employees that is similar to any dependent name

select fname+' '+Lname
from [dbo].[Employee] 
intersect (select [Dependent_name] from [dbo].[Dependent])

--10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
select [Fname],[SSN]
from [dbo].[Employee]
where EXISTS  (select[ESSN] from  [dbo].[Dependent] where [SSN]=[ESSN])

--11.	In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into [dbo].[Departments]([Dname],[Dnum],[MGRSSN],[MGRStart Date]) values ('DEPT IT',100,112233,1-11-2006)

--12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 
--a.	First try to update her record in the department table
update [dbo].[Departments] set [MGRSSN] =968574 where [Dnum]=100

--b.	Update your record to be department 20 manager.
update [dbo].[Employee] set [Dno]=20 where [SSN]=102672

--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update [dbo].[Employee] set [Superssn]=102672 where [SSN]=102660 

--13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Check if Mr. Kamel has dependents, 
delete from [dbo].[Dependent] where [ESSN]=223344
--works as a department manager
update [dbo].[Departments] set [MGRSSN]=102672 where [MGRSSN]=223344
--supervises any employees or works in any projects and handle these cases
update [dbo].[Employee] set [Superssn]=102672 where [Superssn]=223344

--14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update [dbo].[Employee] set [Salary]=[Salary]+30/100 where [SSN] in
(select [ESSn] from 
[dbo].[Works_for] w inner join [dbo].[Project] p
on w.[Pno] =p.Pnumber and p.Pname = 'Al Rabwah')

 