/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class A
    {
        private static A singleton;

         A() { }
        public static A Singleton
        {
            get
            {
                if(singleton == null)
                {
                    singleton = new A();
                }
                return singleton;
            }

            set
            {
                singleton = value;
            }
        }
        public int paramA
        {
            get;
            set;

        }

        public int paramB
        {
            get;
            set;
        }
        public virtual void MethodA()
        {
            Console.WriteLine("A");
        }
        public void MethodC()
        {
            Console.WriteLine("C");
        }
    }
    class B : A
    {private static B singleton;
        public new static  B Singleton
        {
        get
            {
                if (singleton == null)
                {
                    singleton = new B();
                }
                return singleton;
            }
        }
         B()
        {
            
        }
        public override void MethodA()
        {
            //base.MethodA();
            Console.WriteLine("B");
        }
        public void MethodB()
        {
            //base.MethodA();
            Console.WriteLine("Bc");
        }
    }

    public class C : A
    {
        public override void MethodA()
        {
            //base.MethodA();
            Console.WriteLine("B");
        }
        public void MethodB()
        {
            //base.MethodA();
            Console.WriteLine("Bc");
        }
    }

    class Program
    {
        public static double Average(int a, int b)
        {
            return ((float)(a + b) / 2) ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
            Console.ReadLine();
            //var dict  = new Dictionary<int, int>();
            //dict.Add(1, 2);
            //dict.Add(1, 3);
            //Console.Write(dict[1]);
            //a objB = new b();
            //((b)objB).MethodB();
            //Console.Read();
        }
    }
   // public class MathUtils
   // {
   //     public static double Average(int a, int b)
   //     {
   //         return (a + b) / 2;
   //     }
   //public static void Main(string[] args)
   // {
   //   
   // }

   // }
 
}

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

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        int toys = 0;
        if (k <= 0)
        {
            return 0;
        }
        List<int> sPrices = new List<int>();
        sPrices = prices.ToList<int>();
        sPrices.Sort();
        long s = 0;
        var i = 0;
        while (s + sPrices[i] <= k)
        {
            s += sPrices[i];
            //     var i = sPrices.Count - 1;
            sPrices.RemoveAt(i);
            toys++;

        }

        return toys;
    }


    static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        Console.WriteLine(result);

     //   textWriter.Flush();
    //    textWriter.Close();
    }
}
*/
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


public class Program
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        var tarr = s.Split(':');
        if (tarr.Length == 3 && s.Contains("AM"))
        {
            var hh = int.Parse(tarr[0]);

            var h = hh == 12 ? "00" : (hh < 10 ? "0" + hh : hh + "");
            var res = h + ":" + tarr[1] + ":" + tarr[2].Replace("AM", "");
            return res;
        }
        else if (tarr.Length == 3 && s.Contains("PM"))
        {
            var hh = int.Parse(tarr[0]) + 12;
            // var h = hh ==24 ? "00" : hh+"";
            var res = hh + ":" + tarr[1] + ":" + tarr[2].Replace("PM", "");
            return res;
        }
        /*
         * Write your code here.
         */
        return s;
    }


    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        int rank = 1;
        var res = new List<int>();
        var sRank = new Dictionary<int,int>();
        var dScore  = new Dictionary<int, int>();
        int j=0 //Alice
            , k = 0;//All
        var item = 0;
        for (var i = 0; i < scores.Length + alice.Length; i++) 
        {
          
            if (alice[j] > scores[k])
            {
                if (item == scores[k])
                {
                    dScore[item]++;
                }
               

                if (j < alice.Length-1)
                {
                    j++;
                }
            }
            else if (alice[j] == scores[k])
            {
                
                item = alice[j];

                if (j < alice.Length-1)
                {
                    j++;
                }
                if (k < scores.Length-1)
                {
                    k++;
                }
            }
            else if (alice[j] < scores[k])
            {
                item = scores[k];
                if (k < scores.Length-1)
                {
                    k++;
                }
            }
            if (!sRank.ContainsKey(item))
            {
                sRank[item] = rank;
                Console.Write(item);
                Console.Write(", "+rank);
                Console.WriteLine("");
                rank++;
            }
          
        }

        for(int n = 0;  n < alice.Length; n++)
        {
            Console.Write(alice[n]);
            Console.Write(", " + n);
            Console.WriteLine("");
            // res.Add(sRank[alice[n]]);
        }

        return res.ToArray();

    }

    static void Main(string[] args)
    {
        //  TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var score = new List<int>();
         score.Add(100);
        score.Add(100); score.Add(50); score.Add(40); score.Add(40); score.Add(20); score.Add(10);
        var alice = new List<int>();
        ; alice.Add(5); alice.Add(25); alice.Add(50); alice.Add(120);
        var res = climbingLeaderboard(score.ToArray(), alice.ToArray());
      //  var score = scr.Split(' ');
        string s = Console.ReadLine();

        string result = res.ToString();//timeConversion(s);

        Console.WriteLine(result);
        Console.ReadLine();
        // tw.Flush();
        // tw.Close();
    }
}

