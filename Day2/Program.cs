using Day2;
using System.Text.RegularExpressions;

#region task1
Console.WriteLine("\n---------------------------------Task1 ---------------------------------\n");
Console.WriteLine("Enter an array  IE: Type '7 8 9 5 8 6 7 5 3 2 1 2'\n---------------------------------\n");
Regex validateNumberRegex = new Regex("^(\\d+\\s{0,1})+$");
string userInput;
do
{
    userInput = Console.ReadLine();
    if (!validateNumberRegex.IsMatch(userInput))
        Console.WriteLine("invalid input  IE: Type '7 8 9 5 8 6 7 5 3 2 1 2'");


} while (!validateNumberRegex.IsMatch(userInput));


LongestDistanceBetweenTwoEqualCells problem = new LongestDistanceBetweenTwoEqualCells(userInput);
var result = problem.FindLongestDistance();
foreach (var item in result)
{
    Console.WriteLine($"\nnumber: {item.item}, distance: {item.distance},\n" +
        $"First occureance in the array: {item.initIndex}, last occureance in the array: {item.lastIndex}" +
        $"\n----------------------------------------------");
}

Console.WriteLine("\n---------------------------------Find longest distace ---------------------------------\n");
Console.WriteLine("Enter a number to search for");

Regex validateNumberRegex1 = new Regex("^\\d+$");
string userSearch;
do
{
    userSearch = Console.ReadLine();
    if (!validateNumberRegex1.IsMatch(userSearch))
        Console.WriteLine("invalid input  IE: Type '7'");


} while (!validateNumberRegex1.IsMatch(userSearch));

problem.SearchArray(int.Parse(userSearch));
#endregion

#region task2
Console.WriteLine("\nPress any key to continue");
Console.ReadLine();
Console.WriteLine("\n---------------------------------Task2 ---------------------------------\n");
NICSingltonClass NIC1 = NICSingltonClass.CreateNicCard();
NICSingltonClass NIC2 = NICSingltonClass.CreateNicCard();
NICSingltonClass NIC3 = NICSingltonClass.CreateNicCard();
Console.WriteLine(NIC1.GetHashCode());
Console.WriteLine(NIC2.GetHashCode());
Console.WriteLine(NIC3.GetHashCode());
#endregion

