using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class ListManager
    {
        List<string> Names;
        public ListManager(List<string> names) 
        {
            Names = names;
        }

        public List<string> Filter(Predicate<string> predicate)
        {
            List<string> result = new List<string>();

            foreach (string name in Names)
            {
                if (predicate(name))
                {
                    result.Add(name);
                }
            }

            return result;
        }
    }
}
