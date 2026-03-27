using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () =>
        {
            return new List<string> {
                "rich.neat@boardgamer.com",
                "poppy.mcdonnell@irishdancer.com",
                "neil.hughes@walkingoncustard.com",
                "alice.yang@midfielder.com",
                "pippa.austin@musician.com"
            };
        };

        public static Action<List<string>> GetUsernames = (List<string> emails) =>
        {
            List<string> users = new();
            emails.ForEach(email =>
            {
                Console.WriteLine(email.Substring(0, email.IndexOf("@")));
            });
        };

        public static Action<List<string>> PrintcoolPeople = (List<string> emails) =>
            emails.ForEach(email =>
            {
                Console.WriteLine(email);
            });

        public static Action<List<int>> SquaredNums = (List<int> nums) =>
        {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] = nums[i] * nums[i];
                }    
        };

        public static Action<List<int>> PrintNums = (List<int> nums) =>
        {
            nums.ForEach(num => Console.WriteLine(num));
        };

        public static Action<List<int>> PrintSquaredNums => (List<int> nums) =>
        {
            SquaredNums(nums);
            PrintNums(nums);
        };

        public static Dictionary<string, List<string>> FilterEmails(List<string> emails)
        {
            Dictionary<string, List<string>> result = new();

            IEnumerable<string> dotco = emails.Where(email => email.Contains(".co.uk"));
            IEnumerable<string> dotcom = emails.Where(email => email.Contains(".com"));

            List<string> dotcoEmails = new();
            List<string> dotcomEmails = new();
            List<string> invalidEmails = new();

            foreach (string email in emails)
            {
                if (dotco.Contains(email))
                {
                    dotcoEmails.Add(email);
                }
                else if (dotcom.Contains(email))
                {
                    dotcomEmails.Add(email);
                }
                else
                {
                    invalidEmails.Add(email);
                }
            }

            return new()
                {
                    {
                        ".co.uk", dotcoEmails
                    },
                    {
                        ".com", dotcomEmails
                    },
                    {
                        "invalid", invalidEmails
                    }
                };
        }
    }
}
