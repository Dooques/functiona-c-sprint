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
    }
}
