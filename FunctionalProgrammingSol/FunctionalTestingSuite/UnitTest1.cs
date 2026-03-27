using FunctionalProgramming;
using System.Numerics;
using System.Xml.Linq;

namespace FunctionalTestingSuite
{
    public class Tests
    {
        [TestCase(3, 4)]
        public void AddOne_RerturnsIncrementedOutput(int num1, int num2)
        {
            Assert.That(Exercises001.AddOne(num1).Equals(num2));
        }
        
        [TestCase(3, 9)]
        public void AddOne_RerturnsSquaredOutput(int num1, int num2)
        {
            Assert.That(Exercises001.SquareIt(num1).Equals(num2));
        }
        
        [TestCase(3, 13)]
        public void AddOne_RerturnsOutputPlusTen(int num1, int num2)
        {
            Assert.That(Exercises001.AddTen(num1).Equals(num2));
        }

        [TestCase("Hello", false)]
        [TestCase("hello!", false)]
        [TestCase("Hello!", true)]
        public void AddOne_CheckForCapitalAndExclamation(string input, bool result)
        {
            Assert.That(Exercises001.GrammarCheck(input).Equals(result));
        }

        [TestCase(new string[] { "start", "pale" }, 5)]
        public void AddOne_ReturnSumOfIndices(string[] input, int result)
        {
            var string1 = input[0];
            var string2 = input[1];
            Assert.That(Exercises001.SumIndices(string1, string2).Equals(result));
        }

        [TestCase("samuel@northcoders.com", "Email domain and user valid, please continue")]
        [TestCase("sam@northcoders.com", "Email domain and user name invalid, please check your input")]
        [TestCase("samuel@gmail.com", "Email domain and user name invalid, please check your input")]
        public void AddOne_CheckValidEmailAddress(string input, string result)
        {
            var inputToTest = Exercises001.CheckEmail(input);
            Console.WriteLine(inputToTest);
            Assert.That(inputToTest.Equals(result));
        }

        /*
        [Test]
        public void FilterEmails()
        {
            List<string> input = new List<string>();
            var result = Exercises002.FilterEmails(input);

            Assert.That(result.Equals(typeof(Dictionary<string, List<string>>)));
        }
        */

    }
}