using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;
        public static Func<int, int> SquareIt = num => num * num;
        public static Func<int, int> AddTen = num => num + 10;
        public static Predicate<string> GrammarCheck = s => s.StartsWith('A') && s.EndsWith('!');
        public static Func<string, string, int> SumIndices = (a, b) => a.IndexOf('a') + b.IndexOf('e');
        public static string CheckValidEmail(string email)
        {
            Predicate<string> domainCheck = s => s.Split('@')[1] == "northcoders.co.uk";
            Predicate<string> usernameCheck = s => s.Split('@')[0].Length >= 5;
            
            if (domainCheck(email) && usernameCheck(email))
            {
                return "Email domain and user valid, please continue";
            }
            else
            {
                return "Email domain and user name invalid, please check your input";
            }

        }


    }
}
