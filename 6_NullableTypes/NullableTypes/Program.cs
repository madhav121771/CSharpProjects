using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// BOOL AS NULLABLE TYPE HERE
            //bool? AreYouMajor = null;

            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("User is major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("User is not major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the question");
            //}

            //WITHOUT NULL COALESING OPERATOR
            int ? TicketOnSale = null;
            int AvailableTicket;

            if (TicketOnSale == null )
            {
                AvailableTicket = 0;
            }
            else
            {
                AvailableTicket = (int)TicketOnSale;
            }
            Console.WriteLine("AvailableTicket are {0}", AvailableTicket );
            
            //WITH NULL COALESING OPERATOR
            AvailableTicket = TicketOnSale?? 0; // IMP
            Console.WriteLine("AvailableTicket are {0}", AvailableTicket);

            Console.ReadLine();
                
                
            
        }
    }
}
