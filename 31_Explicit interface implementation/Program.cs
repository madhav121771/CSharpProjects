using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Explicit_interface_implementation
{

    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
   public class Program : I1 ,I2
    {

         void I1.InterfaceMethod() // Writting class name before method will make it explicit method implementation
        {
            Console.WriteLine("I1 interface method");
         }
         void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            ((I1)p).InterfaceMethod(); // explicit interface implementation to solve ambiguty error in same method

            ((I2)p).InterfaceMethod();

            Console.ReadLine();

        }
    }
}
//Note :
//1 -  if a class inherits from 2 interfaces and both contains same method , how shoud that class implements that methods for both interfaces ??

//2 - answer : using "Explicit interface implementation"
//3 - when a class explicitly implements, an inteface member - then the interface members can no longer be accessible to class reference variable but only though the interface reference variable
//4 - Access modifiers are not allowed on explicit implemented inteface members

//5 - DEFAULT IMPLEMENTATION
//6 - If you want to make one of the interface method as default. then implement that method normally and implement other method explicitly
    // this makes the default mothod to be accessible though class instance
