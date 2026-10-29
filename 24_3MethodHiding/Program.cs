using System;

namespace _24_2MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void printFullName()
        {
            Console.WriteLine("full name is :" + FirstName + LastName);
        }

    }
    public class FullTimeEmployee : Employee
    {
    }

    public class PartTimeEmployee : Employee
    {
        //after writing new keyword if you want to forcefully call the parent method
        public new void printFullName() // this method from the child class will hide parent class method and print the - contractor
        {
             Console.WriteLine("full name is :" + FirstName + LastName + "- contractor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Madhav";
            FTE.LastName = "Phulpagar";
            FTE.printFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Reena";
            PTE.LastName = "Gupta";
            //PTE.printFullName();
            ((Employee)PTE).printFullName(); // using this way also we can achive [24_3MethodHiding]project objective
                                    // this is called as using type casting we can override method hiding
            Console.ReadLine();
        }
    }
}
