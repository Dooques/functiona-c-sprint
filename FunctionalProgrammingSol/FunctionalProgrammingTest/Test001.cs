using Shouldly;
using FunctionalProgramming;

namespace FunctionalProgrammingTests
{
    public class Test001
    {
        [Test]
        public void AddOne_ReturnsOneMoreThanInput()
        {
            int input = 3;
            int expected = 4;

            int result = Exercises001.AddOne(input);

            result.ShouldBe(expected);
        }

        [TestCase(9, 81)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(-9, 81)]
        public void SquareIt_ReturnsInputSquared(int input, int expected)
        {
            int result = Exercises001.SquareIt(input);

            result.ShouldBe(expected);
        }

        [TestCase("Amazing!", true)]
        [TestCase("Awesome!", true)]
        public void GrammarCheck_ReturnsTrue_WhenInputStartsWithCapitalAAndEndsWtihExclamationMark(string input, bool expected)
        {
            bool result = Exercises001.GrammarCheck(input);

            result.ShouldBe(expected);
        }

        [TestCase("apple!", false)]
        [TestCase("Artichoke", false)]
        public void GrammarCheck_ReturnsFalse_WhenInputNotStartsWithCapitalAOrNotEndsWtihExclamationMark(string input, bool expected)
        {
            bool result = Exercises001.GrammarCheck(input);

            result.ShouldBe(expected);
        }

        [TestCase("start", "pale", 5)]
        [TestCase("012345a789", "012e456789", 9)]
        [TestCase("01 345678a", "01234?67e9", 17)]
        public void SumIndices_ReturnsSumOfIndicesOfLowercaseAInTheFirstWordAndLowercaseEInTheSecondWord(string input1, string input2, int expected)
        {
            int result = Exercises001.SumIndices(input1, input2);

            result.ShouldBe(expected);
        }


        [TestCase("chris@northcoders.co.uk", "Email domain and user valid, please continue")]

        public void CheckValidEmail_ReturnsVaildMessage_WhenTheEmailDomainIsFromNorthcodersAndUsernameIsAtLeast5Characters(string input, string expected)
        {
            string result = Exercises001.CheckValidEmail(input);

            result.ShouldBe(expected);
        }

        [TestCase("neil@northcoders.co.uk", "Email domain and user name invalid, please check your input")]
        [TestCase("chris@gamil.com", "Email domain and user name invalid, please check your input")]

        public void CheckValidEmail_ReturnsInvaildMessage_WhenTheEmailDomainIsNotFromNorthcodersOrUsernameIsNotAtLeast5Characters(string input, string expected)
        {
            string result = Exercises001.CheckValidEmail(input);

            result.ShouldBe(expected);
        }
    }
}