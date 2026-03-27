using Shouldly;
using FunctionalProgramming;

namespace FunctionalProgrammingTests
{
    public class Tests
    {
        [Test]
        public void AddOne_ReturnsOneMoreThanInput()
        {
            int input = 3;
            int expected = 4;

            int result = Exercises001.AddOne(input);

            result.ShouldBe(expected);
        }
    }
}