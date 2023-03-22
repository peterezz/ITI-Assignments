using Day06;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using static Day06.ListGenerators;

#region LINQ - Restriction Operators

/*////Find all products that are out of stock
//IEnumerable<Product> list1 = ProductList.Where(product => product.UnitsInStock == 0);
//foreach (var item in list1)
//    Console.WriteLine(item);*/

/*//// . Find all products that are in stock and cost more than 3.00 per unit.
//IEnumerable<Product> list2 = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3.00M);
//foreach (var item in list2)
//    Console.WriteLine(item);*/

/*////Returns digits whose name is shorter than their value.
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//for (int i = 0; i < Arr.Length; i++)
//{
//    if (Arr[i].Length == i)
//        Console.WriteLine(Arr[i]);
//}*/

#endregion

#region LINQ - Element Operators

/*//// Get first Product out of Stock
//Console.WriteLine(ProductList.First());*/

/*//// Return the first product whose Price > 1000, unless there is no match, in which case null
////is returned.
//Console.WriteLine(ProductList.FirstOrDefault(product => product.UnitPrice > 1000M));*/

/*////Retrieve the second number greater than 5
//int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//var res = Arr1.OrderBy(num => num).Where(num => num > 5).Take(2);
//Console.WriteLine(res.LastOrDefault());*/

#endregion

#region LINQ - Set Operators

/*//Find the unique Category names from Product List
//IEnumerable<string> list3 = ProductList.Select(pro => pro.Category).Distinct();
//foreach (var item in list3)
//    Console.WriteLine(item);*/

/*//Produce a Sequence containing the unique first letter from both product and customer
//names.
//foreach (var item in ProductList.Select(pro => pro.ProductName[0])
//         .Union(
//         CustomerList.Select(customer => customer.CompanyName[0])
//         ))
// Console.WriteLine(item);*/

/*//. Create one sequence that contains the common first letter from both product and
//customer names
//foreach (var item in ProductList.Select(prop => prop.ProductName[0])
//    .Intersect(
//        CustomerList.Select(cus => cus.CompanyName[0])
//    ))
//    Console.WriteLine(item);*/

/*//Create one sequence that contains the last Three Characters in each names of all
//customers and products, including any duplicates
//foreach (var item in ProductList.Select(pro => pro.ProductName[^3..pro.ProductName.Length])
//    .Concat(
//       CustomerList.Select(cus => cus.CompanyName[^3..cus.CompanyName.Length])
//    ))
//    Console.WriteLine(item);*/

#endregion

#region LINQ - Aggregate Operators

/*//1. Uses Count to get the number of odd numbers in the array
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//Console.WriteLine(Arr.Count(num=>num%2==1));*/

/*//2. Return a list of customers and how many orders each has
//foreach (var item in CustomerList.Select( customer => $"{customer} ,  {customer.Orders.Length}"))
//    Console.WriteLine(item);*/

/*//3. Return a list of categories and how many products each has
//foreach (var item in  ProductList.DistinctBy( pro=>pro.Category).Select(pro=>pro.Category))
//    Console.WriteLine($"category {item} has {ProductList.Count(pro=>pro.Category.Equals(item))}");*/

/*//4.Get the total of the numbers in an array.
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
//Console.WriteLine(Arr.Sum());*/

/*//5. Get the total number of characters of all words in dictionary_english.txt (Read
//dictionary_english.txt into Array of String First).
string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
Console.WriteLine(lines.Sum(str => str.Length));*/

/*//6. Get the total units in stock for each product category
//foreach (var item in ProductList.DistinctBy(pro=>pro.Category).Select(pro=>pro.Category))
//    Console.WriteLine($"category {item} has total unit in stock: {ProductList.Sum(pro =>pro.UnitsInStock)}");*/

/*//7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into
//Array of String First).
string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
Console.WriteLine(lines.Min(str => str.Length));*/

/*//8.Get the cheapest price among each category's products
//foreach (var group in ProductList.GroupBy(Pro => Pro.Category)
//    .Select(p => new { category = p.Key, CheapestProduct = p.Min(ele => ele.UnitPrice) }))
//    Console.WriteLine(group);*/

/*//9.Get the products with the cheapest price in each category (Use Let)
//foreach (var item in 
//    from product in ProductList
//    group product by product.Category 
//    into groups
//    let cheapestPrice = groups.Min(product=>product.UnitPrice)
//    select new {Category=groups.Key,CheapestProduct = cheapestPrice }
//    )
//    Console.WriteLine(item);*/

/*//10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt
//into Array of String First).
string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
Console.WriteLine(lines.Max(word=>word.Length));*/

/*//11. Get the most expensive price among each category's products.
foreach (var item in from product in ProductList
                     group product by product.Category 
                     into groups
                     let expensivePrice = groups.Max(pro=>pro.UnitPrice)
                     select new {Category= groups.Key, expensiveProduct = expensivePrice })
    Console.WriteLine(item);
*/

/*//12.Get the products with the most expensive price in each category.
//foreach (
//    var item in 
//    ProductList.GroupBy(group=> group.Category).
//    Select (gruop=> new { Category = gruop.Key , mostExpensiveProduct = gruop.MaxBy(product=>product.UnitPrice)})
//    )
//    Console.WriteLine(item);*/

/*//13.Get the average length of the words in dictionary_english.txt (Read
//dictionary_english.txt into Array of String First).
//string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
//Console.WriteLine(lines.Average(str=>str.Length));*/

/*//14.Get the average price of each category's products.
//foreach (
//    var item in
//    ProductList.GroupBy(group=>group.Category).
//    Select (g => new {Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice)}))
//    Console.WriteLine(item);*/

#endregion

#region LINQ - Ordering Operators

/*////Sort a list of products by name
//IEnumerable<Product> list4 = ProductList.OrderBy(pro => pro.ProductName);
//foreach (var item in list4)
//    Console.WriteLine(item);*/

/*////Uses a custom comparer to do a case-insensitive sort of the words in an array.
//string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//foreach (var item in Arr3.OrderBy(str=>str, new IgnoreUpperCaseComparer()))
//    Console.WriteLine(item);*/

/*////Sort a list of products by units in stock from highest to lowest
//var list5 = ProductList.OrderByDescending(pro => pro.UnitsInStock);
//foreach (var item in list5)
//    Console.WriteLine(item);*/

/*////Sort a list of digits, first by length of their name, and then alphabetically by the name
////itself.
//foreach (var item in ProductList.OrderByDescending(pro => pro.ProductName.Length).ThenBy(pro => pro.ProductName))
//  Console.WriteLine(item);*/

/*////Sort first by word length and then by a case-insensitive sort of the words in an array.
//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//foreach (var item in words.OrderBy(str=>str.Length).ThenBy(str=>str,new IgnoreUpperCaseComparer()))
//    Console.WriteLine(item);*/

/*////. Sort a list of products, first by category, and then by unit price, from highest to lowest.
//foreach (var item in ProductList.OrderByDescending(pro=>pro.Category).ThenByDescending(pro=>pro.UnitPrice))
//    Console.WriteLine(item);*/

/*////Sort first by word length and then by a case-insensitive descending sort of the words in
////an array.
//string[] Arr9 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
//foreach (var item in Arr9.OrderBy(str=>str.Length).ThenByDescending(str=>str,new IgnoreUpperCaseComparer()))
//    Console.WriteLine(item);*/

/*////Create a list of all digits in the array whose second letter is 'i' that is reversed from the
////order in the original array.
//string[] Arr10 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
//"nine" };
//Array.Reverse(Arr10);
//foreach (var item in Arr10.Where(str => str[1] == 'i'))
//    Console.WriteLine(item);*/

#endregion

#region LINQ - Partitioning Operators

/*  //1.Get the first 3 orders from customers in Washington
foreach (var item in CustomerList.Where(customer => customer.City.Equals("Washington")).SelectMany(o => o.Orders).Take(3))
    Console.WriteLine(item);*/

/*//2. Get all but the first 2 orders from customers in Washington.
foreach (var item in CustomerList.Where(customer =>customer.City.Equals("São Paulo")).SelectMany(customer =>customer.Orders).Skip(2))
    Console.WriteLine(item);*/

/*//3. Return elements starting from the beginning of the array until a number is hit that is
//less than its position in the array.
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
foreach (int i in numbers.TakeWhile((num,index)=>num>index))
    Console.WriteLine(i);*/

/*//4. Get the elements of the array starting from the first element divisible by 3.
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
foreach (var item in numbers.SkipWhile(num=>num % 3 !=0))
    Console.WriteLine(item);*/

/*//5. Get the elements of the array starting from the first element less than its position.
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
foreach (int i in numbers.SkipWhile((num, index) => num > index))
    Console.WriteLine(i);*/

#endregion

#region LINQ - Projection Operators

/*//1. Return a sequence of just the names of a list of products.
foreach (var item in ProductList.Select(p =>p.ProductName))
    Console.WriteLine(item);*/

/*//2. Produce a sequence of the uppercase and lowercase versions of each word in the
//original array(Anonymous Types).
string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
foreach (var item in words.Select(str=>str.ToUpper()).Union(words.Select(str=>str.ToLower())))
    Console.WriteLine(item);*/

/*//3. Produce a sequence containing some properties of Products, including UnitPrice which
//is renamed to Price in the resulting type.
foreach (var item in ProductList.Select(pro => new { pro.ProductID , Price = pro.UnitPrice , pro.ProductName}))
    Console.WriteLine(item);*/

/*//4. Determine if the value of ints in an array match their position in the array
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
foreach (string i in Arr.Select((num,index)=> $"{num}: {num == index}"))
    Console.WriteLine(i);*/

/*//5. Returns all pairs of numbers from both arrays such that the number from numbersA is
//less than the number from numbersB.
int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };
Console.WriteLine("Pairs where a < b:");
foreach (string str in from numA in numbersA
                       let numAA= numA
                       from numB in numbersB
                       let numBB= numB
                       where numAA<numBB
                       select $"{numAA} is less than {numBB}")

    Console.WriteLine(str);*/


/*//6. Select all orders where the order total is less than 500.00.
foreach (var item in CustomerList.SelectMany(customer=> customer.Orders.Where(o=>o.Total < 500.00M) ))
    Console.WriteLine(item);*/

/*//7. Select all orders where the order was made in 1998 or later.
foreach (var item in CustomerList.SelectMany(customer=>customer.Orders.Where(order=>order.OrderDate.Year >= 1998)))
    Console.WriteLine(item);*/

#endregion

#region LINQ - Quantifiers

/*//1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into
//Array of String First) contain the substring 'ei'.
Regex rx = new Regex(@".*(ei).*",
         RegexOptions.Compiled | RegexOptions.IgnoreCase);
string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
Console.WriteLine(lines.Any(str=>rx.IsMatch(str)));*/

/*//2. Return a grouped a list of products only, for categories that have at least one product
//that is out of stock.
foreach (var group in
    ProductList.GroupBy(product => product.Category).
    Where(group => group.
    Any(product => product.UnitsInStock <= 0))
    )
{
    Console.WriteLine($"------------- {group.Key}-------------");
    foreach (var product in group)
        Console.WriteLine($"{group.Key}:- {product} ");
    Console.WriteLine();
}*/

/*//3. Return a grouped a list of products only for categories that have all of their products in
//stock.
foreach (var group in ProductList.
     GroupBy(product=>product.Category)
    .Where(group=>group
    .All(product=>product.UnitsInStock>0))
    )
{
    Console.WriteLine($"------------- {group.Key}-------------");
    foreach (var product in group)
        Console.WriteLine($"{group.Key}:- {product} ");
    Console.WriteLine();
}*/

#endregion

#region LINQ - Grouping Operators

/*//1. Use group by to partition a list of numbers by their remainder when divided by 5
int[] numbers = { 0, 5, 10, 1, 6, 11, 3, 8, 7, 2, 13, 4, 12, 9, 14 };
foreach (var group in numbers.GroupBy(num => num % 5))
{
    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
    foreach (var num in group)
        Console.WriteLine(num);
    Console.WriteLine("--------------");
}*/

/*//Uses group by to partition a list of words by their first letter.
//Use dictionary_english.txt for Input
string[] lines = System.IO.File.ReadAllLines(@"E:\Demo Projects\ITI\ITI-Assignments\Day06\Day06\dictionary_english.txt");
foreach (var group in lines.GroupBy(str => str[0] ))
{
    foreach (var num in group)
        Console.WriteLine(num);
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
}*/

/*//3. Consider this Array as an Input
string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
//Use Group By with a custom comparer that matches words that are consists of the same
//Characters Together
foreach (var strGroup in Arr.GroupBy(str => str, new ArrEqualityComparer()))
{
    foreach (var str in strGroup)
    {
        Console.WriteLine(str);
    }
        Console.WriteLine("---------------------------------------------------------");
}*/

#endregion