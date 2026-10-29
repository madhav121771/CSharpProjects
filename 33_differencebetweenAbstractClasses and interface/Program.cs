using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_differencebetweenAbstractClasses_and_interface
{
    public abstract class customer
    {
        public int id; // abstract class can have fields
        public void print()
        {
            Console.WriteLine("Print method");
        }

    }

    public interface Icustomer
    {
        //public int id; // interface class can not have fields (you can try uncommenting)
        void print();

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
