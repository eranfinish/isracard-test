using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class a
    {
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
    class b : a
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
