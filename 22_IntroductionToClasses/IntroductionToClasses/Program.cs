using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClasses
{
    class Customer          // this is example of class
    {
        string _firstName;  // this are class fields
        string _lastName;
         string _middleName;

        //if method name = class name then it is called "constructor" as below Customer is default constructor
        public Customer() : this("No FirstName","No MiddleName","No LastName") //using this keyword you can redirect call to another constructor like below

        {
            Console.WriteLine("this is also imp");
        }

        public Customer(string FirstName , string LastName) // this is parameterised constructor of that class with two para
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public Customer(string FN, string MN ,string LN) // this is parameterised constructor of that class with three para
        {
            this._firstName = FN;
            this._middleName = MN;
            this._lastName = LN;
        }

        public void PrintFullName() // this is the method in that class (We Also call it as behavior of that class)
        {
            Console.WriteLine("Full name is : "+ this._firstName + " " + this._lastName);
        }

    }  

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(); // creating object of the class here will atomatically call the default constructor
            C1.PrintFullName(); // we have called method of customer class using its object C1 here
            Console.ReadLine();

            // defination : Class is refernce data type which consist fields and methods
                // : Class is blue print from which objects are created
        }
    }
}
