using Day3;

#region task1
{
    Employee[] employees = new Employee[1];
    for (int i = 0; i < employees.Length; i++)
    {
        int EmployeeIndex = i + 1;
        Console.Write("Enter Employee " + EmployeeIndex + " ID: ");
        employees[i].ID = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee " + EmployeeIndex + " Name: ");
        employees[i].Name = Console.ReadLine();
        Console.Write("Enter Employee " + EmployeeIndex + " salary: ");
        employees[i].salary = float.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------");

    }
    foreach (Employee employee in employees)
    {
        Console.WriteLine(employee.ShowData());
        Console.WriteLine("-----------------------");

    }
}
#endregion

#region task2
{
    int a = 10, b = 15;
    Swapping.swapByValue(a, b);
    Console.WriteLine($"Value of first element: {a} - value of second element: {b}");
    Swapping.SwapByRefrance(ref a, ref b);
    Console.WriteLine($"Value of first element: {a} - value of second element: {b}");
    Console.WriteLine("-----------------------");
}
#endregion

#region task3
{
    double result=0;
    Console.WriteLine(" 1- sum\n 2- product \n 3- sub \n 4- divide");
    int ChossenOption=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter first number: ");
    int firstNumber=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int secondNumber = int.Parse(Console.ReadLine());
    switch (ChossenOption)
    {
        case 1:
            result = Operations.Sum(firstNumber, secondNumber);
            break;
        case 2:
            result = Operations.Product(firstNumber, secondNumber);
            break;
        case 3:
            result=Operations.Subtract(firstNumber, secondNumber);
            break;
        case 4:
           result= Operations.Devide(firstNumber, secondNumber);
            break;


        default:

            break;
    }
    Console.WriteLine($"result is: {result}");
    Console.WriteLine("-----------------------");
}
#endregion
