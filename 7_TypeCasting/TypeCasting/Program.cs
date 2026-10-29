using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT CONVERSION
            int i = 100;

            // Float is bigger datatype than integer so no loss of data and exception
            //Hence implicit conversion is posible here
            float f = i;
            Console.WriteLine(f);

            //EXPLICIT CONVERSION
            float Fl = 12234765.12f;

            //can not implicitly convert float to integer
            //fractional part will be lost . float is bigger
            //datatype than int , so there is also posibility 
            //of overflow exception
            //int i = f is not posible

            int il = Convert.ToInt32(Fl); // or  int il = (int)Fl; 

            Console.WriteLine(il);
            Console.ReadLine();


        }
    }
}
