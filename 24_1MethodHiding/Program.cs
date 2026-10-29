using System;

namespace _24_1MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public  void printFullName()
        {
            Console.WriteLine("full name is :" + FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    public class PartTimeEmployee : Employee
    {
        //this is example of method hiding using "new" keyword
        public  void printFullName() // this method from the child class will hide parent class method and print the "full name is : Madhav Phulpagar"
        {
            Console.WriteLine("full name is :" + FirstName + LastName + "- contractor");
        }
        //note : if you do not write new keyword then also it hide the child method . by default. (with warning msg)
        //--> after writing new keyword if you want to forcefully call the child method see next example project
    }

    class Program
    
    {
        static void Main(string[] args)
        {

            Employee FTE = new PartTimeEmployee();
            FTE.FirstName = "Madhav";
            FTE.LastName = "Phulpagar";
            FTE.printFullName();

            // PartTimeEmployee PTE = new PartTimeEmployee();
            // PTE.FirstName = "Reena";
            // PTE.LastName = "Gupta";
            // PTE.printFullName();
            Console.ReadLine();
        }
    }
}
