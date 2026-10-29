using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number :");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number :");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;

                    Console.WriteLine("result = " + result);
                    Console.ReadLine();
                }
                catch (Exception Ex)
                {
                    string filePath = @"D:\console logs\log1.txt"; // if the file name is not proper then will go to else part and inner exception is trown outside

                    if (File.Exists(filePath))
                    {
                        StreamWriter stm = new StreamWriter(filePath);
                        stm.Write(Ex.GetType().Name + "Timing :" + DateTime.Now);
                        stm.WriteLine();
                        stm.Write(Ex.Message);
                        stm.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present there", Ex); //throwing inner exception in another catch block here
                    }

                    Console.WriteLine("There is a problem please try again later");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("current exception : " + exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner exception : " + exception.InnerException.GetType().Name); //concept of inner exception here
                }

                Console.ReadLine();
            }
            
           

        }
    }
}
