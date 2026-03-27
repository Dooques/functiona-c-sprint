namespace FunctionalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

            numbers.ForEach(Exercises001.PrintValues);

        }
    }
}