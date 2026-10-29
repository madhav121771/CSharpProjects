using System;

namespace _25_1MethodOverridingVsMethodHidng
{
    //this is example of method overriding
    public class BaseClass
    {
        public virtual  void print() // this virtual keyword allow child class to override method
        {
            Console.WriteLine("I am base class print method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override  void print() // this override keyword used here will override base method
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