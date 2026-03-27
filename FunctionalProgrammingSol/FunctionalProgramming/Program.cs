// See https://aka.ms/new-console-template for more information
using FunctionalProgramming;
using System.Threading.Channels;

// Task 3
Console.WriteLine("Task 3");
List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

foreach (int number in numbers)
{
    Console.WriteLine(Exercises001.AddTen(number));
}
Console.WriteLine();

// Task 4
Console.WriteLine("Task 4");
List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };

foreach (string word in words)
{
    Console.WriteLine(Exercises001.GrammarCheck(word));
}
Console.WriteLine();

// Task 5
Console.WriteLine("Task 5");
Console.WriteLine(Exercises001.SumIndices("start", "pale"));
Console.WriteLine();

// Task 6
Console.WriteLine("Task 6");
string goodEmail = "chris@northcoders.co.uk";
string badEmail = "example@gmail.com";

Console.WriteLine(Exercises001.CheckValidEmail(goodEmail));
Console.WriteLine(Exercises001.CheckValidEmail(badEmail));
Console.WriteLine();

// Task 7
Console.WriteLine("Task 7");
List<string> coolPeople = Exercises002.GetCoolPeople();

coolPeople.ForEach(Console.WriteLine);

Console.WriteLine();

// Task 8
Console.WriteLine("Task 8");

coolPeople.ForEach(Exercises002.GetUsernames);

Console.WriteLine();

// Task 9
Console.WriteLine("Task 9");

Exercises002.PrintCoolPeople(coolPeople);

Console.WriteLine();

// Task 10
Console.WriteLine("Task 9");
List<int> numList = new List<int> { 5, 8, 3, 6, 67 };

Exercises002.PrintSquaredNums(numList);

Console.WriteLine();