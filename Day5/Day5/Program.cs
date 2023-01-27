using Day4;
using Day5;

Employee[] employees = { new Employee(),new Employee(),new Employee()};
string EmpSecurityLevel = "";
string EmpGender = "";
string EmpHiringDate = "";

string[] securityLevels = { "Guest", "Developer", "Secretary", "DBA" };
string[] Genders = { "Male", "Female" };


Console.WriteLine("---- Enter Employee data ----\n");

foreach (var emp in employees)
{
    while (emp.ID <= 0)
    {
        try
        {
            Console.Write("Enter employee ID: ");
            emp.ID = int.Parse(Console.ReadLine());
            if(emp.ID <=0)
                Console.WriteLine("Error occared: Employee ID is not Valid!");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Occarred: {ex.Message}!");
        }

    }

    do
    {
        if(emp.Name.Equals("Emp Name is empty"))
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
        if (Enum.IsDefined(typeof(SecurityLevel), EmpSecurityLevel))
            emp.SecurityLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), EmpSecurityLevel);
        else
            Console.WriteLine("Error occared: Security level is not valid!");
    } while (!securityLevels.Any(level => level.Equals(EmpSecurityLevel)));

    do
    {
        Console.Write("Enter employee Gender: ");
        EmpGender = Console.ReadLine();
        if (Enum.IsDefined(typeof(Gender), EmpGender))
            emp.Gender = (Gender)Enum.Parse(typeof(Gender), EmpGender);
        else
            Console.WriteLine("Error occared: Gender is not valid!");
    } while (!Genders.Any(Gender => Gender.Equals(EmpGender)));

    do
    {
        Console.Write("Enter employee hiring date: ");
        EmpHiringDate = Console.ReadLine();
        emp.HiringDate = new HiringDate(EmpHiringDate);
        if(string.IsNullOrEmpty(emp.HiringDate.GetHiringDate()))
            Console.WriteLine("Error occared: Hiring date is not valid! EX: 30-9-1999");
    } while (string.IsNullOrEmpty(emp.HiringDate.GetHiringDate()));


    Console.WriteLine("------------\n");
}

Console.WriteLine("\n ------------------- Stored data ------------------- \n ");

foreach (var emp in employees)
{
Console.WriteLine(emp.GetEmpData());

}
