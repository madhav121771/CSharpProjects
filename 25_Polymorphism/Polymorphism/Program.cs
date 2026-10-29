using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "Madhav";
        public string LastName = "Phulpagar";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }
    }

    public class TempororyEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temp");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TempororyEmployee();


            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }




            Console.ReadLine();

        }
    }
}
