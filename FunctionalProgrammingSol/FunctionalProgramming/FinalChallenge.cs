using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FinalChallenge
    {
        public class ListManager
        {
            public List<Person> People {  get; private set; }


            public ListManager(List<String> names)
            {
                Random random = new Random();
                List<Person> people = new List<Person>();
                
                names.ForEach(name =>
                {
                    people.Add(new Person(
                        name, 
                        random.Next(101), 
                        random.NextInt64(07000000000, 07999999999).ToString())
                        );
                });
                People = people;
            }

            public List<Person> Filter(Predicate<Person> filterBy)
            {
                return People.FindAll(filterBy);
            }
        }

        public class Person
        {
            public string Name;
            public int Age;
            public string PhoneNumber;

            public Person(string name, int age, string phoneNumber)
            {
                Name = name;
                Age = age;
                PhoneNumber = phoneNumber;
            }
        }

        public class ListSumCalculator<T>
        {
            public List<T> List {  get; private set; }
            public ListSumCalculator(List<T> list)
            {
                List = list;
            }

            public int SumBy(Delegate transformToInt)
            {
                return 0;
            }
        }
    }
}
