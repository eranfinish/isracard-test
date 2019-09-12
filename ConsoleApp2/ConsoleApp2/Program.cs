using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            //  string[][] queries = new string[4][];
            string[][] queries = new string[][]
{
    new string[] {"4"},
    new string[] {"add","hack"},
    new string[] {"add","hackhjg"},
    new string[] {"add","hackgdgd"},
    new string[] {"add","hak"},
    new string[] {"find", "hak"},
    new string[] {"find", "hac"}

};

            int[] result = contacts(queries);

        }
         static int[] contacts(string[][] queries)
        {
            int[] result = new int[0];
            string[] partial = new string[0];
            string[] contacts = new string[0];
            for (int i = 1; i<queries.Length; i++)
            {
                if (queries[i][0].Equals("find"))
                {
                    int l = partial.Length; 
                    Array.Resize(ref partial, l + 1);
                    partial[l] = queries[i][1];
                }
                else if (queries[i][0].Equals("add"))
                {
                    int l = contacts.Length;
                    Array.Resize(ref contacts, l + 1);
                    contacts[l] = queries[i][1];
                }

            }
            int c = 0;
            foreach (string part in partial)
            {
                if (contacts.Length > 0)
                {
                     c = contacts.Select(x => x.StartsWith(part)).ToList().Count;

                }
                int l = result.Length;
                Array.Resize(ref result, l + 1);
                result[l] = c;
                c = 0;

            }
            return result.ToArray<int>();
          //  var partial = queries.Where(x => x[0].Equals("find") && IsLower(x[0])).ToArray();
        }


        internal static bool IsLower(this string value)
        {
            // Consider string to be lowercase if it has no uppercase letters.
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}

