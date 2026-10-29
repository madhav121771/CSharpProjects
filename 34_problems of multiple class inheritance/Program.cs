using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_problems_of_multiple_class_inheritance
{

    class A
    {
        public virtual void print()
        {
            Console.WriteLine("A implementation");
        }
    }
    class B : A
    {
        public override void print()
        {
            Console.WriteLine("B implementation");
        }
    }

    class C : A
    {
        public override void print()
        {
            Console.WriteLine("C implementation");
        }
    }

    class D : B, C // does not allowed to have multiple base classes
    {
        public override void print()
        {
            Console.WriteLine("D implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.print(); // there would be ambugity while calling this method , thid is the problem and hence c sharp does not support multiple class inheritance

        }
    }
}
