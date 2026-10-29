using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 101;
            Numbers[2] = 101;

          //  ParamsMethod();    //If you will not send any parameter then also it is fine for param array
           // ParamsMethod(Numbers ); //If you send specific collection to param array then also it is fine 
            ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9,10); // you can send n number of parameters to the param arrray
            Console.ReadLine();
        }
        public static void ParamsMethod(params int[] Numbers) //Param array must be always at the last position in the method
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);

            }
        }

    }
}
