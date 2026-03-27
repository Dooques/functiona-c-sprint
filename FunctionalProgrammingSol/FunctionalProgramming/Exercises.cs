using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises001
    {
        public static Func<int, int> AddOne = num => num + 1;
        public static Func<int, int> SquareIt = num => num * num;
        public static Func<int, int> AddTen = num => num + 10;
        public static Predicate<string> GrammarCheck = word =>
        {
            string firstChar = word.Substring(0, 1);
            string firstCharCap = firstChar.Substring(0, 1).ToUpper();
            return (firstChar.Equals(firstCharCap) && word[word.Length - 1] == '!');
        };

        public static Func<string, string, int> SumIndices = (string string1, string string2) =>
        {
            var index1 = string1.IndexOf("a") + 1;
            var index2 = string2.IndexOf("a") + 1;
            Console.WriteLine($"{index1} + {index2}");
            return index1 + index2;
        };

        public static string CheckEmail(string email)
        {
            Predicate<string> checkDomain =  email =>
            {
                string domain = email.Substring(email.IndexOf('@'), email.Length - email.IndexOf('@'));
                return domain.Contains("northcoders");
            };

            Predicate<string> checkUsername = email =>
            {
                int domainStart = email.IndexOf('@');
                string username = email.Substring(0, domainStart);
                return username.Length >= 5;
            };

            return (checkDomain(email) && checkUsername(email)) ?
                "Email domain and user valid, please continue" : 
                "Email domain and user name invalid, please check your input";
        }
    }
}
