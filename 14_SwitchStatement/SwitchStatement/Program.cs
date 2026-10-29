using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20,30");
                    break;
            }
         
            Console.ReadLine();
        }
    }
}
