using System;
using System.Runtime.InteropServices;

namespace ConsoleApp6
{
    internal class A
    {
        internal virtual void FuncA(int i)        
        {
            Console.WriteLine("FuncAAA");
        }


    }

    internal class B : A
    {
        internal void FuncB()
        {
            Console.WriteLine("FuncBBB");
        }
        internal override void FuncA(int i)
        {
            if (i == 0)
            {
                base.FuncA(i);
            }
            else
            {
                Console.WriteLine("SSSSS");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.FuncA(0);
        }
    }
}
