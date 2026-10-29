using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {                
                streamReader = new StreamReader(@"D:\data0.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadLine();
                
            }
            catch (FileNotFoundException ex) // we can write specific exceptions like this 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
            catch (Exception ex) // orelse we can have generic exception to catch any type of exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close(); //always release the resources in finally block - it is garanteed to excecute
                }                
                Console.WriteLine("finally block executed !");
                Console.ReadLine();
            }

         
        }
    }
}
