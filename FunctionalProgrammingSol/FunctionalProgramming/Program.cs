// See https://aka.ms/new-console-template for more information
using FunctionalProgramming;

List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

foreach (int number in numbers)
{
    Console.WriteLine(Exercises001.AddTen(number));
}
