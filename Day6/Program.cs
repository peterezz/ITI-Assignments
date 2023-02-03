using Day6;

#region task1
{
int cordinatesOfPoint1 = 0;
Point3D point1 = new Point3D(cordinatesOfPoint1);

int cordinatesOfPoint2 = 0;
Point3D point2 = new Point3D(cordinatesOfPoint2);

do
{

try
{
Console.Write("Please entre point: ");
cordinatesOfPoint1 = int.Parse(Console.ReadLine());
if (cordinatesOfPoint1 <= 0)
Console.WriteLine("Please enter valid value.");
else
point1 = new Point3D(cordinatesOfPoint1);
}
catch (Exception ex)
{

Console.WriteLine($"Error occuared: {ex.Message}");
}
} while (cordinatesOfPoint1 <= 0);
string point1Result = (string)point1;
Console.WriteLine($"\n-------------{nameof(point1Result)}-------------\n \t{point1Result}\n");

do
{

try
{
Console.Write("Please entre point: ");
cordinatesOfPoint2 = int.Parse(Console.ReadLine());
if (cordinatesOfPoint2 <= 0)
Console.WriteLine("Please enter valid value.");
else
point2 = new Point3D(cordinatesOfPoint2);
}
catch (Exception ex)
{

Console.WriteLine($"Error occuared: {ex.Message}");
}
} while (cordinatesOfPoint2 <= 0);

string pointsEqualityCheck = point1 == point2 ? "Coordinates of Point1 and Point2 are equal" : "Coordinates of Point1 and Point2 are not equal";
Console.WriteLine($"\n-------------{nameof(pointsEqualityCheck)}-------------\n {pointsEqualityCheck}\n");
}
#endregion

#region task2
{
double result = 0;
int ChossenOption = 0;
int firstNumber = 0;
int secondNumber = 0;
do
{
Console.WriteLine(" 1- sum\n 2- product \n 3- sub \n 4- divide");
try
{
Console.Write("chosen number: ");
ChossenOption = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{

Console.WriteLine($"Error occuared in {nameof(ChossenOption)}: {ex.Message}");
}
try
{
Console.Write("Enter first number: ");
firstNumber = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{

Console.WriteLine($"Error occuared in {nameof(firstNumber)}: {ex.Message}");
}
try
{
Console.Write("Enter second number: ");
secondNumber = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{

Console.WriteLine($"Error occuared in {nameof(secondNumber)}: {ex.Message}");
}
} while (ChossenOption <= 0 || firstNumber <= 0 || secondNumber < 0);



switch (ChossenOption)
{
case 1:
result = Operations.Sum(firstNumber, secondNumber);
break;
case 2:
result = Operations.Product(firstNumber, secondNumber);
break;
case 3:
result = Operations.Subtract(firstNumber, secondNumber);
break;
case 4:
result = Operations.Devide(firstNumber, secondNumber);
break;


default:

break;
}
Console.WriteLine($"result is: {result}");
Console.WriteLine("-----------------------");
}
#endregion
Console.WriteLine("\nPress any key to continue\n");
Console.ReadLine();

#region task3
{
    Duration duration1 = new Duration(1,10,15);
    Console.WriteLine(duration1.ToString());
    Console.WriteLine(duration1.TotalSeconds);

    Duration duration2 = new Duration(7800);
    Console.WriteLine(duration2.ToString());
    Console.WriteLine(duration2.TotalSeconds);

    Duration duration3 = duration1 + duration2;
    Console.WriteLine(duration3.ToString());
    Console.WriteLine(duration3.TotalSeconds);

    Duration duration4 = duration3 + 7800;
    Console.WriteLine(duration4.ToString());
    Console.WriteLine(duration4.TotalSeconds);

    Duration duration5 = 666 + duration4 ;
    Console.WriteLine(duration5.ToString());
    Console.WriteLine(duration5.TotalSeconds);

    duration5++;
    Console.WriteLine(duration5.ToString());
    Console.WriteLine(duration5.TotalSeconds);

    --duration5;
    Console.WriteLine(duration5.ToString());
    Console.WriteLine(duration5.TotalSeconds);
    Console.WriteLine("\t\t---------HINT--------");

    if(duration1 < duration2)
        Console.WriteLine($"{nameof(duration1.TotalSeconds)} of {nameof(duration1)} is smaller than {nameof(duration2.TotalSeconds)} of {nameof(duration2)}");
    if(duration2 > duration3)
        Console.WriteLine($"{nameof(duration2.TotalSeconds)} of {nameof(duration2)} is greater than {nameof(duration3.TotalSeconds)} of {nameof(duration3)}");

    if (duration3 <= duration4)
        Console.WriteLine($"{nameof(duration3.TotalSeconds)} of {nameof(duration3)} is smaller than or equal to{nameof(duration4.TotalSeconds)} of {nameof(duration4)}");
    if (duration4 >= duration5)
        Console.WriteLine($"{nameof(duration4.TotalSeconds)} of {nameof(duration4)} is greater than or equal to {nameof(duration5.TotalSeconds)} of {nameof(duration5)}");
    if(duration1)
    {
        Console.WriteLine($"{nameof(duration1.TotalSeconds)} of {nameof(duration1)} is greater than 0");
    }

}
#endregion