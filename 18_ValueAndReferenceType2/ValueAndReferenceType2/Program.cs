using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceParameter2
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            Console.WriteLine("Passing parameter BY Reference(Which uses same memory location)");
            SimpleMethod(ref i); // while passing to method i = 0
            Console.WriteLine("Value of i =" +i); //When Come back from method i = 101
            Console.ReadLine();
        }
        public static void SimpleMethod(ref int j)
        {
            j = 101; // but here j= 101 and i = 101
        }
    }
}
