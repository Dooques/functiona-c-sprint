using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises002
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

        public static Action<List<string>> PrintCoolPeople = l =>
        {
            foreach (string people in l)
            {
                Console.WriteLine(people);
            }
        };

        public static Action<List<int>> SquaredNums = l =>
        {
            for (int i = 0; i < l.Count; i++)
            {
                l[i] = Exercises001.SquareIt(l[i]);
            }
        };

        public static Action<List<int>> PrintNums = l =>
        {
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        };

        public static Action<List<int>> PrintSquaredNums = l =>
        {
            SquaredNums(l);
            PrintNums(l);
        };

        public static Dictionary<string, List<string>> FilterEmails(List<string> emails)
        {
            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

            res[".co.uk"] = emails.Where(s => s.EndsWith(".co.uk")).ToList();
            res[".com"] = emails.Where(s => s.EndsWith(".com")).ToList();
            res["invalid"] = emails.Where(s => !s.EndsWith(".co.uk") && !s.EndsWith(".com")).ToList();

            return res;
        }
    }
}
