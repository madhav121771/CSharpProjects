using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Evennumbers = new int[3]; // simple array 
            Evennumbers[0] = 0;
            Evennumbers[1] = 2;
            Evennumbers[2] = 4;

            Console.WriteLine(Evennumbers[1]);

            int[] OddNumbers = { 1,3,5}; // initializing array in single line
            Console.WriteLine(OddNumbers[2]);


            Console.ReadLine();

        }
    }
}
