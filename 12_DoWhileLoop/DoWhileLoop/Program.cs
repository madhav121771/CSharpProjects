using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main()
        {
            string UserChoice = "";
            do
            {
             Console.WriteLine("Please enter your do while target?");
             int userTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= userTarget)
            {
                Console.Write(Start + " ");
                Start += 2;
            }
            do
            {
                Console.WriteLine("Do you want to continue - Yes Or No ?");
                UserChoice = Console.ReadLine().ToUpper();

                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice ,Please say Yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");

            } while (UserChoice != "YES");
            Console.ReadLine();
        }


    }

}

