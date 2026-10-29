using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceParameter1
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            Console.WriteLine("Passing parameter BY VALUE(Which uses different memory location)");
            SimpleMethod( ref i);  // while passing i = 0
            Console.WriteLine("Value of i = " + i); //when come back from method i = 0
            Console.ReadLine();
        }
        public static void SimpleMethod( ref int j)
        {
            j = 101;  // but here j = 101 and i =0
        }
    }
}
