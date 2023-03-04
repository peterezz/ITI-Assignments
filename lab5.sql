--Part-1: Use ITI DB
use ITI
--1.	Retrieve number of students who have a value in their age. 
select count([St_Id]) as stdNum
from [dbo].[Student]
where [St_Age] is not null

--2.	Get all instructors Names without repetition
select distinct([Ins_Name])
from [dbo].[Instructor]

--2.	Get all instructors Names without repetition
select [St_Id],[St_Fname]+' '+ISNULL([St_Lname],' NoLastName') as [student full name],[Dept_Name] as [department name]
from [dbo].[Student] s inner join [dbo].[Department]d
on d.[Dept_Id]=s.[Dept_Id]

--4.	Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not
select [Ins_Name],[Dept_Name]
from [dbo].[Department] D full outer join [dbo].[Instructor] I
on D.[Dept_Id]=I.[Dept_Id]

--5.	Display student full name and the name of the course he is taking
--For only courses which have a grade  
select concat([St_Fname],' ', [St_Lname]),[Crs_Name],[Grade]
from [dbo].[Student] S inner join [dbo].[Stud_Course] SC
on S.[St_Id] = SC.[St_Id] and sc.Grade is not null
inner join [dbo].[Course] C
on C.Crs_Id = SC.Crs_Id 

--6.	Display number of courses for each topic name
select count([Crs_Id]) as numCourses
from [dbo].[Course]
group by [Top_Id]

--7.	Display max and min salary for instructors
select max([Salary]) as maxSalary, min([Salary]) as minSalary
from [dbo].[Instructor]

--8.	Display instructors who have salaries less than the average salary of all 
--instructors.
select *
from [dbo].[Instructor]
where [Salary]< (select AVG([Salary]) from [dbo].[Instructor])

--9.	Display the Department name that contains the instructor who receives the 
--minimum salary.
select [Dept_Name]
from [dbo].[Department] 
where [Dept_Id] = (select min([Salary]) from [dbo].[Instructor])

--10.	 Select max two salaries in instructor table. 
select [Salary]
from (select  [Salary],ROW_NUMBER() over (order by  [Salary] desc ) RN from [dbo].[Instructor]) newTable
where RN <=2

--11.	 Select instructor name and his salary but if there is no salary display instructor 
--bonus keyword. “use coalesce Function”
select COALESCE (convert(varchar(255),[Salary]),'bonus') as salary
from [dbo].[Instructor]


--12.	Select Average Salary for instructors 
select avg([Salary]) as AvgSalary from [dbo].[Instructor]

--13.	Select Student first name and the data of his supervisor 
select Std.[St_Fname] as StudentFirstName,Super.*
from [dbo].[Student] Std inner join [dbo].[Student] Super
on Super.[St_Id] = Std.St_super

--14.	Write a query to select the highest two salaries in Each Department for
--instructors who have salaries. “using one of Ranking Functions”
select  [Salary],[Dept_Id]
from (select  [Salary],[Dept_Id],ROW_NUMBER() over ( partition by [Dept_Id] order by  [Salary] desc) RN 
from [dbo].[Instructor]
) newTable
where RN <=2

--15.	 Write a query to select a random  student from each department.  
-- “using one of Ranking Functions”
select[St_Fname]
from( 
select [St_Fname],ROW_NUMBER() over (partition by [Dept_Id] order by  newid()) AS RN
from [dbo].[Student] 
) NewTable
where RN =1

