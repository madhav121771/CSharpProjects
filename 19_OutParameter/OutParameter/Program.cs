using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class Program
    {
        static void Main()
        {
            int Total = 0;
            int Multi = 0;
            int dev = 0;
            // this two out parameter are passed to the method and get result return
            Calculate(20,10 ,out Total,out  Multi, out dev);

            Console.WriteLine("Sum =" + Total + " And Multiple =" + Multi);
            Console.WriteLine(  "devide = "+ dev);
            Console.ReadLine();
        }
        //This method can return more than two values using out parameter 
        public static void Calculate(int FN, int SN, out int Sum, out int product,out int devide)
        {
            Sum = FN + SN;
            product = FN * SN;
            devide = FN / SN;
        }

    }
}
