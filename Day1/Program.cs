using Day1;
using System;

Console.WriteLine("-------------------- Task1 --------------------------------\n");
Array_2D array = new Array_2D();
Console.WriteLine("-------------------- Row Sum --------------------------------\n");
int[] rowSum = array.GetRowSum();
for(int i=0; i< rowSum.Length;i++)
    Console.WriteLine($"sum of row {i+1}: {rowSum[i]}");
Console.WriteLine("\n-------------------- Column Average --------------------------------\n");
double[] colAver = array.GetColAverage();
for (int i = 0; i < colAver.Length; i++)
    Console.WriteLine($"average of column {i+1}: {colAver[i]}");


Console.WriteLine("\n----------------------- Task2 -----------------------------\n");


Employee [] employees = { new Employee(), new Employee(),new Employee() };
string EmpSecurityLevel = "";
string EmpGender = "";
string EmpHiringDate = "";




Console.WriteLine("---- Enter Employee data ----\n");

foreach (var emp in employees)
{
  

    do
    {
        if (emp.Name.Equals("Emp Name is empty"))
            Console.WriteLine("Error Occarred: Employee name is empty!");
        Console.Write("Enter employee Name: ");
        emp.Name = Console.ReadLine();
    } while (emp.Name.Equals("Emp Name is empty"));

    while (emp.Salary <= 0)
    {
        try
        {
            Console.Write("Enter employee Salary: ");
            emp.Salary = decimal.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occarred: {ex.Message}!");
        }

    }

    do
    {
        Console.Write("Enter employee security leve: ");
        EmpSecurityLevel = Console.ReadLine();
        if (!emp.SetSecurityLevel(EmpSecurityLevel))
            Console.WriteLine("Error occared: Security level is not valid!");
    } while (!emp.SetSecurityLevel(EmpSecurityLevel));

    do
    {
        Console.Write("Enter employee Gender: ");
        EmpGender = Console.ReadLine();
        if (!emp.SetGender(EmpGender))
            Console.WriteLine("Error occared: Gender is not valid!");
    } while (!emp.SetGender(EmpGender));

    do
    {
        Console.Write("Enter employee hiring date: ");
        EmpHiringDate = Console.ReadLine();
        emp.HiringDate = new HiringDate(EmpHiringDate);
        if (string.IsNullOrEmpty(emp.HiringDate.ToString()))
            Console.WriteLine("Error occared: Hiring date is not valid! EX: 30/9/1999");
    } while (string.IsNullOrEmpty(emp.HiringDate.ToString()));


    Console.WriteLine("------------\n");
}

Console.WriteLine("\n ------------------- Stored data ------------------- \n ");

Array.Sort(employees);
foreach (var emp in employees)
{
    Console.WriteLine(emp.ToString());

}
Console.WriteLine("\n ------------------- Search Result ------------------- \n ");

EmpListIndexer EmpListIndexer = new EmpListIndexer(employees);

Employee searchResult= EmpListIndexer[employees[2].GetNationalityId()];
if (searchResult != null)
    Console.WriteLine(searchResult.ToString());

 searchResult = EmpListIndexer[employees[0].HiringDate];
if (searchResult != null)
    Console.WriteLine(searchResult.ToString());
else
    Console.WriteLine("Empolyee not found");

searchResult = EmpListIndexer["peter"];
if (searchResult != null)
    Console.WriteLine(searchResult.ToString());
else
    Console.WriteLine("Empolyee not found");

searchResult = EmpListIndexer[employees[1].Name];
if (searchResult != null)
    Console.WriteLine(searchResult.ToString());
else
    Console.WriteLine("Empolyee not found");


