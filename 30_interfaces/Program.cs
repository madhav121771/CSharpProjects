using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_interface_example
{

    interface ICustomer
    {
        void Print(); // inteface can have method declaration but not implementation
    }

    interface ICustomer2
    {
        void print2();
    }
    class  customer : ICustomer, ICustomer2 // "multiple interface inheritance" can be achived here (but multiple class inheritance is not allowed)
    {

        public void Print() // inherited class needs to provide implementation for the declared class above
        {
            Console.WriteLine("This is implementation for print method");
            Console.ReadLine();
        }

        public void print2()
        {
            Console.WriteLine("This is implementation for print2 method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.Print();

            ICustomer cust = new customer(); // this is allowed - an interface refernce variable can point to a derived class object
            cust.Print();
            

        }  
    }
}
//NOTE:
//1- we crete interface using interface keyword. It also contains property, method, delegate, events but only declaration not implementation
//2- It shows compile time error to provide implementation for any interface member 
//3- Inteface members public by default, they do not allow explicit access modifiers
//4- interface can not contain fields
//5- if a class or struct inherit from interface , it must provide implementation for all the interface members
//6- A class or stuct can inherit from more than one interface at the same time whereas ( multiple class inheritance is not allowed )
//7- interface can inherit from other interface and class that inherit this interface must provide implementatio for 
    // all the  interface memebers in the entire interface inheritance chain
//8 - We can not create instance of an interface but an interface refernce variable can point to a derived class object
//9


