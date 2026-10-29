using System;

namespace _25_1MethodOverridingVsMethodHidng
{
    //this is example of method hiding
    public class BaseClass
    {
        public virtual void print() 
        {
            Console.WriteLine("I am base class print method");
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void print() // this method will be hidden even if it is written as new ( called method hiding)
        {
            Console.WriteLine("I am derived class print method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass BC = new DerivedClass();
            BC.print();
            Console.ReadLine();

        }
    }
}
// note : this is example of method overrriding 
// here virtual keyword allow child method to override print method and child class method get called