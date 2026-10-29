using System;

namespace MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + LastName);
        }
        
    }
    public class PartTimeEmployee :Employee
    {
        public new void PrintFullName() // "new" keyword is used for hiding the above parent class method
        {
            Console.WriteLine(FirstName + LastName + " – contractor");
        }
    }
    public class FullTimeEmployee : Employee
    {
        //public void PrintFullName()
        //{
        //    Console.WriteLine(FirstName + LastName + "contractor");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Fulltime";
            FTE.LastName = " Employee";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Parttime";
            PTE.LastName = " Employee";
            PTE.PrintFullName();

            Console.ReadLine();
        }
    }
}
