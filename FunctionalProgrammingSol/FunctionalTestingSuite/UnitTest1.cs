using FunctionalProgramming;

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
    }
}