using FunctionalProgramming;
using Shouldly;
using System;
using System.Collections.Generic;

namespace FunctionalProgrammingTests
{
    public class TestListManager
    {
        [Test]
        public void Filter_ReturnsAListOfNamesThatSatisifyThePredicate()
        {
            var input = new List<string>
            {
                "Jerry",
                "Donna",
                "Dorothy",
                "Michelle",
                "Emily",
                "Richard",
                "Paul",
                "Larry",
                "Maria",
                "Raymond",
                "Kimberly",
                "Janet",
                "Melissa",
                "Laura"
            };

            List<string> startsWithJ = new List<string>
            {
                "Jerry",
                "Janet"
            };

            List<string> lengthEqualsFive = new List<string>
            {
                "Jerry",
                "Donna",
                "Emily",
                "Larry",
                "Maria",
                "Janet",
                "Laura"
            };


            var listManager = new ListManager(input);

            listManager.Filter(s => s.StartsWith('J')).ShouldBe(startsWithJ);
            listManager.Filter(s => s.Length == 5).ShouldBe(lengthEqualsFive);
        }
    }
}