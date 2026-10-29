using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please Enter your target :");
            int Target = Convert.ToInt32(Console.ReadLine());
            int Start = 0;

             
            while (Start <= Target) //while loop run till condition becomes false and it checks the condition first
            {
                Console.Write(" \n" + Start);
                Start += 1;
            }

            Console.ReadLine();
        }
    }

}
