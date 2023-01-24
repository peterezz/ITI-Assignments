using Day2;
//var list = problem.myList.SortArray();
//foreach (var item in list)
//    Console.WriteLine(item);

#region task1
{
    Console.WriteLine("Task1: Sum inputs");
    int Total = 0;
while (Total < 100)
{
        Console.Write("put a number: ");
    int Input= int.Parse(Console.ReadLine());
    if(Input == 0)
        break;
    Total+=Input;
}
Console.WriteLine($"Sum: {Total}\n ----------------------");
}
#endregion

#region task2
{
    Console.WriteLine("Task2: Swapping");
    Console.Write("write a phrase: ");
    string Input= Console.ReadLine();
    string[] splitedArray = Input.Split(' ');
    if(splitedArray.Length >1)
    {
        for (int i = splitedArray.Length-1; i >= 0; i--)
        {
            Console.Write(splitedArray[i]+" ");
        }
    }
    Console.WriteLine("----------------------");
      //(splitedArray[0], splitedArray[1]) = (splitedArray[1], splitedArray[0]);
    //Console.WriteLine($"Resulted splition is: {string.Join(" ",splitedArray)} \n ----------------------");
}
#endregion

#region task3
{
    Console.WriteLine("Task3: Max Number");

    int maxNum= 0;
    for (int i = 0; i < 3; i++)
    {
       Console.Write("write a number: ");
        int Input = int.Parse(Console.ReadLine());
      if(Input>maxNum)
            maxNum = Input;
    }
    Console.WriteLine($"Max number is: {maxNum} \n ----------------------");
}
#endregion

#region task4
{
    Console.WriteLine("Task4: odd | Even");
    int[] ArrInput= new int[5];
    for (int i = 0; i < ArrInput.Length; i++)
    {
        ArrInput[i] = int.Parse(Console.ReadLine());


    }
    foreach (var item in ArrInput)
    {
        if (item % 2 == 0)
            Console.WriteLine($"{item} is an even number.");
        else
            Console.WriteLine($"{item} is an odd number.");
    }

    Console.WriteLine($"----------------------");
}
#endregion



#region task5 and task6
{
    Console.WriteLine("Task5 & 6: List");
    Console.WriteLine("1-new \n 2-Display \n 3-Exit");
    Console.Write("please choose a number from list:");
    int Input = 0;
    do
    {
     Input = int.Parse(Console.ReadLine());
    switch (Input)
    {
        case 1:
            Console.WriteLine("new");
            break;
        case 2:
            Console.WriteLine("Display");
            break;
        case 3:
            Console.WriteLine("Good Bye");
            break;

    }

    } while (Input!=3);

    Console.WriteLine($"----------------------");
}
#endregion