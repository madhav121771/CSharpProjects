using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Multiple_class_inheritance_using_interface
{
    interface IA
    {
        void Amethod();
    }

    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void Bmethod();
    }
    class B : IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
            a.Amethod();
        }

        public void Bmethod()
        {
            b.Bmethod();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            AB ab = new AB();
            ab.Amethod(); // we have achived here multiple class inheritance using interfaces
            ab.Bmethod();
            Console.ReadLine();
        }
    }
}
