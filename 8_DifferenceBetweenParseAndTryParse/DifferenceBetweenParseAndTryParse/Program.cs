using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenParseAndTryParse
{
    class Program
    {
        static void Main()
        {

            string strNumber = "100TG";
            int Result = 0;

            bool IsConversionSuccessfull = int.TryParse(strNumber, out Result);

            if (IsConversionSuccessfull)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }

            Console.ReadLine();
        }
    }
}
