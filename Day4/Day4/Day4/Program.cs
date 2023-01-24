using Day4;

Employee[] employees=new Employee[1];
for (int i = 0; i < employees.Length; i++)
{
    int empIndex = i + 1;
    Console.Write($"emp {empIndex} Id:");
    employees[i].SetEmpId(int.Parse(Console.ReadLine()));

    Console.Write($"emp {empIndex} Name:");
    employees[i].SetEmpName(Console.ReadLine());

    Console.Write($"emp {empIndex} Salary:");
    employees[i].SetEmpSalary(decimal.Parse(Console.ReadLine()));

    Console.Write($"emp {empIndex} Security level:");
    employees[i].SetEmpSecurityLevel((SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine()));

    Console.Write($"emp {empIndex} Gender:");
    employees[i].SetEmpGender((Gender)Enum.Parse(typeof(Gender), Console.ReadLine()));

    Console.Write($"emp {empIndex} hiring date:");
    employees[i].SetHiringDate(Console.ReadLine());



}
Console.WriteLine("----------------- STORED DATA -----------------");
foreach (var emp in employees)
{
    Console.WriteLine(emp.GetEmpDate());
}