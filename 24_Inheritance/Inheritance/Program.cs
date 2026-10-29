using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public string FirstName; //this are parent fields and any child of employee class can use this --reusable for FTE and PTE
        public string LastName;  //this are parent fields and any child of employee class can use this --reusable for FTE and PTE
        public string Email;     //this are parent fields and any child of employee class can use this --reusable for FTE and PTE

        public void PrintFullName() //this is parents method and any child of employee class can use this --reusable
        {
            Console.WriteLine(FirstName +" " + LastName);
            
        }
    }


    public class FullTimeEmployee : Employee
    {
        public float YearlySalary; // this is childs field and only this child class object can use this --FTE
    }


    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;  // this is childs field and only this child class object can use this --PTE
    }
    
    class Program
    {
        static void Main(string[] args)
        {
               FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Madhav";
            FTE.LastName = "Phulpagar";
            FTE.YearlySalary = 500000;
             
            FullTimeEmployee FTE2 = new FullTimeEmployee();
            FTE2.FirstName= "Rahul";
            FTE2.LastName = "Rane";
            FTE2.YearlySalary = 400000;
            
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Reena";
            PTE.LastName = "Gupta";
            PTE.HourlyRate = 600;

            FTE.PrintFullName(); //PARENT class method used here
            PTE.PrintFullName(); //PARENT class method used here also (that means reusable )

            Console.ReadLine();
        }
    }
}
