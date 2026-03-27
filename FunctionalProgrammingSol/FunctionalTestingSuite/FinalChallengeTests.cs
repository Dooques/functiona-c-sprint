using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionalProgramming;
using NUnit.Framework;

namespace FunctionalTestingSuite
{
    public class FinalChallengeTests
    {
        [SetUp]

        [Test]
        public void ListManager_FilterList()
        {
            List<string> names = new List<string>()
            {
                "Sam", "Chris", "David", "Lewis", "Vic"
            };

            List<string> expected = new List<string>() { "Sam", "Vic" };

            FinalChallenge.ListManager lm = new(names);
            List<FinalChallenge.Person> people = lm.People;

            Predicate<FinalChallenge.Person> FilterByNameLength = person => person.Name.Length < 4;

            var result = lm.Filter(FilterByNameLength);
            var returnedNames = new List<string>();

            result.ForEach(p =>
            {
                Console.WriteLine(p.Name);
                returnedNames.Add(p.Name);
            });

            Assert.That(returnedNames.FindAll(
                name => name.Equals(
                    expected.Find(
                        expectedName => expectedName == name
                        )
                    )
                ).Count == 2);
        }

        [Test]
        public void ListManager_SumBy_ReturnTypedSums<T>()
        {
            List<string> names = new List<string>()
            {
                "Sam", "Chris", "David", "Lewis", "Rose"
            };

            FinalChallenge.ListManager lm = new(names);
            List<FinalChallenge.Person> people = lm.People;
        }
    }
}
