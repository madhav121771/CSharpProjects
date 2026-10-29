using System;
//this is the auto implemented properties example
namespace _26_3WhyProperties_Autoimplemented_properties
{
    public class Student
    {
        // NOTICE no need to write here private field ( compiler automatically do that for us)
             
        public int id
        {
            //using set and get accessors here
            get;
            set;
                   
        }

        public string name { get; set; } // see how simple is this code to write properties
              
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.id = 101; // this setting value will automatically invoke set accessor and set the value

            c1.name = "madhav";

            Console.WriteLine("student id is " + c1.id);// here getting value will automatically invoke get accessor and get the value
            Console.WriteLine("student name is " + c1.name);
            Console.ReadLine();

        }
    }
}
