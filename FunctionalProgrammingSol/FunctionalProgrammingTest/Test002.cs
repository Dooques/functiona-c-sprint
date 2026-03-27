using FunctionalProgramming;
using Shouldly;
using System.Collections.Generic;

namespace FunctionalProgrammingTests
{
    public class Test002
    {
        [Test]
        public void GetCoolPeople_ReturnsListOfCoolPeopleEmail()
        {
            List<string> expected = new List<string>
            {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.com",
                "pippa.austin@musician.com"
            };

            Exercises002.GetCoolPeople().ShouldBe(expected);
        }

        [TestCase("rich.neat@boardgamer.com", "rich.neat")]
        [TestCase("poppy.mcdonnell@irishdancer.com", "poppy.mcdonnell")]
        [TestCase("neil.hughes@walkingoncustard.com", "neil.hughes")]
        [TestCase("alice.yang@midfielder.com", "alice.yang")]
        [TestCase("pippa.austin@musician.com", "pippa.austin")]
        public void GetUsernames_PrintsTheUsernameOfInputEmail(string input, string expected)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Exercises002.GetUsernames(input);

                string result = sw.ToString().Replace(Environment.NewLine, "");
                result.ShouldBe(expected);
            }
        }

        [Test]
        public void PrintCoolPeople_PrintsTheInputListInSeperateLines()
        {
            string expected =
                "rich.neat@boardgamer.com"
                + "poppy.mcdonnell@irishdancer.com"
                + "neil.hughes@walkingoncustard.com"
                + "alice.yang@midfielder.com"
                + "pippa.austin@musician.com";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Exercises002.PrintCoolPeople(Exercises002.GetCoolPeople());

                string result = sw.ToString().Replace(Environment.NewLine, "");
                result.ShouldBe(expected);
            }
        }

        [Test]
        public void SquaredNums_SquaredAListOfIntInPlace()
        {
            List<int> input = new List<int> { 5, 8, 3, 6, 67 };
            List<int> expected = new List<int> { 25, 64, 9, 36, 4489 };
            Exercises002.SquaredNums(input);
            input.ShouldBe(expected);
        }

        [Test]
        public void PrintNums_PrintsAListOfInt()
        {
            List<int> input = new List<int> { 25, 64, 9, 36, 4489 };
            string expected =
                "25"
                + "64"
                + "9"
                + "36"
                + "4489";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Exercises002.PrintNums(input);

                string result = sw.ToString().Replace(Environment.NewLine, "");
                result.ShouldBe(expected);
            }
        }

        [Test]
        public void PrintSquaredNums_PrintsAListOfSquaredInt()
        {
            List<int> input = new List<int> { 5, 8, 3, 6, 67 };
            string expected =
                "25"
                + "64"
                + "9"
                + "36"
                + "4489";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Exercises002.PrintSquaredNums(input);

                string result = sw.ToString().Replace(Environment.NewLine, "");
                result.ShouldBe(expected);
            }
        }

        [Test]
        public void FilterEmails_ReturnsADictionaryFilteredByTopLevelDomain()
        {
            List<string> input = new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
                "link@hyrule.co.uk",
                "neil.hughes@walkingoncustard.com",
                "shrek@duloc.com",
                "csharp@microsoft.cs",
                "ziggy@spidersfrommars.co.uk",
                "lemmy@motorhead.co,uk",
                "me@myhouse.sleep"
            };

            var expected = new Dictionary<string, List<string>>
            {
                { ".co.uk", new List<string> { "link@hyrule.co.uk", "ziggy@spidersfrommars.co.uk" }},
                { ".com", new List<string> { "alice.yang@northcoders.com", "richard.neat@northcoders.com", "neil.hughes@walkingoncustard.com", "shrek@duloc.com" }},
                { "invalid", new List<string> { "mario@plumbing.it", "csharp@microsoft.cs", "lemmy@motorhead.co,uk", "me@myhouse.sleep" }},
            };

            var result = Exercises002.FilterEmails(input);

            result[".co.uk"].ShouldBe(new List<string> { "link@hyrule.co.uk", "ziggy@spidersfrommars.co.uk" });
            result[".com"].ShouldBe(new List<string> { "alice.yang@northcoders.com", "richard.neat@northcoders.com", "neil.hughes@walkingoncustard.com", "shrek@duloc.com" });
            result["invalid"].ShouldBe(new List<string> { "mario@plumbing.it", "csharp@microsoft.cs", "lemmy@motorhead.co,uk", "me@myhouse.sleep" });
        }
    }
}