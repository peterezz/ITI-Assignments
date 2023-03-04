--Part-2: Use AdventureWorks DB
use AdventureWorks2012 

--1.	Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) 
--to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID,ShipDate 
from Sales.SalesOrderHeader
where  ShipDate between '7-28-2002' and '7-29-2014'

--2.	Display only Products(Production schema) with a StandardCost below $110.00 
--(show ProductID, Name only)
select ProductID,Name 
from Production.Product
where StandardCost <110.00 

--3.	Display ProductID, Name if its weight is unknown
select ProductID,Name
from Production.Product
where Weight is not null

--4.	 Display all Products with a Silver, Black, or Red Color
select *
from Production.Product
where Color in('Silver','Black','Red')

--5.	 Display any Product with a Name starting with the letter B
select *
from Production.Product
where Name like 'B%'

--6.	Run the following Query
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

--Then write a query that displays any Product description with underscore value in its description.
select P.*
from Production.Product P inner join Production.ProductDescription D
on P.ProductID = D.ProductDescriptionID
where D.Description like '%_%'

--7.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the 
--period between  '7/1/2001' and '7/31/2014'
select sum(TotalDue ) as TotalDue
from Sales.SalesOrderHeader 
group by OrderDate 
having OrderDate between  '7/1/2001' and '7/31/2014' 

--8.	 Display the Employees HireDate (note no repeated values are allowed)
select distinct(E.HireDate)
from [HumanResources].[Employee] E

--9.	 Calculate the average of the unique ListPrices in the Product table
select distinct(P.ListPrice)
from Production.Product P

--10.	Display the Product Name and its ListPrice within the values of 100 and 120
--the list should has the following format "The [product name] is only! [List 
--price]" (the list will be sorted according to its ListPrice value)
select 'the '+Name+'is only! '+convert(varchar(255),ListPrice) as colName
from Production.Product P
where  P.ListPrice between 100 and 120
order by P.ListPrice

--11
--a)	 Transfer the rowguid ,Name, SalesPersonID, Demographics from 
--Sales.Store table  in a newly created table named [store_Archive]
select S.rowguid,S.Name,S.SalesPersonID,S.Demographics
into  Sales.store_Archive
from  Sales.Store S
--b)	Try the previous query but without transferring the data? 
select S.rowguid,S.Name,S.SalesPersonID,S.Demographics
into  Sales.store_Archive2
from  Sales.Store S
where 2=1


--12.	Using union statement, retrieve the today’s date in different styles using
--convert or format funtion.
select format(getdate(),'dd-MM-yyyy') as[different date format]
union
select format(getdate(),'dddd MMMM yyyy')
union
select convert(varchar(20),getdate(),107)
union 
select format(getdate(),'dd-MM-yyyy hh:mm:ss tt')

