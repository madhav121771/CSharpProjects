using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name : "); //Writing to the Console 
            string FirstName = Console.ReadLine();                // Reading line from console


            Console.WriteLine("Please enter your last name  : "); //Writing to the Console
            string LastName = Console.ReadLine();                 // Reading line from the console  

            Console.WriteLine("Hello " + FirstName + " " + LastName);//Concatening two strings using + sign
            Console.WriteLine("Hello {0} {1}", FirstName, LastName);//Concatening two strings using place holder

            Console.ReadLine(); // Finally reading the console 


        }
    }
}
