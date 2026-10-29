using System;
using System.Net.WebSockets;
//This example can explain properties with GET And  SET accesors
namespace _26_2WhyProperties_problem_solved_by_properties
{
    public class Student
    {
        // making this as private field and writting get and set method to access this fields outside

        private int _id;
     
        public int id
        {
            //using set and get accessors here
            set 
            {
                if (value < 0)
                {
                    throw new Exception("student id can not be negative.");
                }
                this._id = value;
            }

            get
            {
                return this._id;
            }

            //imp : getter and setter has too many line of code so they have implemented auto-implemented properties
            //    see that in next project example
    }
                     
       
        //similar properties can be created for other private fields of class and 
            //any logic can be written to validate those fields
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.id = 101; // this setting value will automatically invoke set accessor and set the value // MAKE NEGATIVE VALUE TO CHECK THIS
            

            Console.WriteLine("student id is " + c1.id);// here getting value will automatically invoke get accessor and get the value
            Console.ReadLine();

        }
    }
}
// to encalpsulate those fields we use properties for that

// that means encapsulation can be achived by using properties

//NOTE : Encapsulation is one of the primary pillar of object oriented programming