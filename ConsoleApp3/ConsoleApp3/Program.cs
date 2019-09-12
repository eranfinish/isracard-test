//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[][] queries = new string[][]
//{
//    new string[] {"4"},
//    new string[] {"add","hack"},
//    new string[] {"add","hackhjg"},
//    new string[] {"add","hackgdgd"},
//    new string[] {"add","hak"},
//    new string[] {"find", "hak"},
//    new string[] {"find", "hac"}

//};


//        }
//        internal static int[] Contacts(string[][] queries)
//        {
//            int[] result = new int[0];
//            string[] partial = new string[0];
//            string[] contacts = new string[0];
//            for (int i = 1; i < queries.Length; i++)
//            {
//                if (queries[i][0].Equals("find"))
//                {
//                    int l = partial.Length;
//                    Array.Resize(ref partial, l + 1);
//                    partial[l] = queries[i][1];
//                }
//                else if (queries[i][0].Equals("add"))
//                {
//                    int l = contacts.Length;
//                    Array.Resize(ref contacts, l + 1);
//                    contacts[l] = queries[i][1];
//                }

//            }
//            int c = 0;
//            foreach (string part in partial)
//            {
//                if (contacts.Length > 0)
//                {
//                 //   c = contacts.Select(x => x.StartsWith(part)).ToList().Count;

//                }
//                int l = result.Length;
//                Array.Resize(ref result, l + 1);
//                result[l] = c;
//                c = 0;

//            }
//            return result.ToArray();
//            //  var partial = queries.Where(x => x[0].Equals("find") && IsLower(x[0])).ToArray();
//        }


//        internal static bool IsLower(this string value)
//        {
//            // Consider string to be lowercase if it has no uppercase letters.
//            for (int i = 0; i < value.Length; i++)
//            {
//                if (char.IsUpper(value[i]))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }


//    }
//}


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        var n = arr[0].Length;
        int xsum = 0;
        int ysum = 0;
        for(int i = 0; i<n; i++)
        {
            int k = n - i - 1;
            xsum += arr[i][i];
            ysum += arr[i][k];
        }


        var res = ysum;//xsum;// -ysum ;
        if (res < 0)
        {
            res = -1 * res;

        }
        return res;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);
        Console.Write(result);
        Console.ReadLine();
       // textWriter.WriteLine(result);

     //   textWriter.Flush();
     //   textWriter.Close();
    }
}

