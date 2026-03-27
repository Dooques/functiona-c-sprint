using FunctionalProgramming;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace FunctionalProgrammingTests
{
    public class TestListSumCalculator
    {
        [Test]
        public void ListSumCalculator_ReturnsTheSumOfTheListsTransfromedByTheLambdaFunction()
        {
            var input = new List<Person>
            {
                new Person(28, "07700900123"),
                new Person(54, "07700900456"),
                new Person(31, "01632960123"),
                new Person(72, "07700900789"),
                new Person(45, "02079460123")
            };

            ListSumCalculator<Person> calculator = new ListSumCalculator<Person>(input);

            calculator.SumBy(p => p.Age).ShouldBe(230);
            calculator.SumBy(p => long.Parse(p.PhoneNumber)).ShouldBe(26815121614);
            calculator.SumBy(p => long.Parse(p.PhoneNumber) + p.Age).ShouldBe(26815121844);
        }
    }
}