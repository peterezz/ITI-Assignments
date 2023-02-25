select * from [dbo].[Employee]

select [Fname],[Lname],[Salary],[Dno]from [dbo].[Employee]

select * from[dbo].[Project]

select [Fname]+' '+[Lname] as [full name],[Salary]*120/100 as [annual commetion]from [dbo].[Employee]

select [SSN],[Fname] from [dbo].[Employee]  where [Salary]>1000

select [SSN],[Fname] from [dbo].[Employee] where [Salary] * 12 >10000 

select [Fname],[Salary] from [dbo].[Employee] where [Sex] = 'F'

select [Dnum],[Dname] from [dbo].[Departments] where [MGRSSN]=968574

select [Pnumber],[Plocation],[Pname] from [dbo].[Project] where [Dnum]=10
