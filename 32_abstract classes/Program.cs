using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_abstract_classes
{
    public abstract class customer 
    {
        public abstract void print(); // here is only declaration of method
    }

    public class Program : customer
    {

        public override void  print()
        {
            Console.WriteLine("print method"); // here is implementation of above method
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            customer  c1 = new Program();
            c1.print();
        }
    }

}

//note :
//1 - abstract keyword is used to create abstract classes
//2 - abstract class is incomplete and hence can not be instantiated
//3 - abstract class can only be used as base class
//4 - abstract class can not be sealed (sealed is opposite of abstract)
//5 - abstract class may contain abstract members(method , property , indexer , events) but not mandatory
//6 - an non abstract class derived from an abstract class must provide implementations for all inherited abstract members

//7 - If a class inherit from an abstract class there are two options
// option1 : provide implementation for all the  abstract members inherited from base abstract class
// option2 : If the class does not wish to provide implementation for all the abstract members inherited from the abstract class, then class has to mark as abstract



