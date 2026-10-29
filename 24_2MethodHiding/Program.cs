using System;

namespace _24_2MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void printFullName() // bar chart
        {
            Console.WriteLine("full name is :" + FirstName + " " + LastName);
        }

    }
  
    public class PartTimeEmployee : Employee //latest bar
    {
        //after writing base keyword if you want to forcefully call the parent method
        public new void printFullName() // this method from the child class will hide parent class method and print the - contractor
        {
            base.printFullName(); // this line will tranfer this call to base class for same method

            Console.WriteLine("full name is :" + FirstName + LastName + "- contractor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            PartTimeEmployee FTE = new PartTimeEmployee();
            FTE.FirstName = "Madhav";
            FTE.LastName = "Phulpagar";
            FTE.printFullName();

            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.FirstName = "Reena";
            //PTE.LastName = "Gupta";
            //PTE.printFullName();
            Console.ReadLine();
        }
    }
}
