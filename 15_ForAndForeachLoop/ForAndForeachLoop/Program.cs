using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];

            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            Numbers[3] = 4;

            //Foreach loop is used when we have collection
            Console.WriteLine("Using Foreach Loop");
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }

            //For loop is used if you know the number of itteration
            Console.WriteLine("Using for loop");
            for (int i = 0; i <= Numbers.Length - 1; i++)
            {
                //if (i == 3)


            }
            

            Console.ReadLine();



        }
    }
}
