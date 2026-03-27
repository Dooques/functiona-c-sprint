using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Person
    {
        public int Age { get; }
        public string PhoneNumber { get; }
        public Person(int age, string phoneNumber)
        {
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
