using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string>
        {
            "rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"
        };

        public static Action<string> GetUsernames = s => Console.WriteLine(s.Split('@')[0]);
    }
}
