using System;

namespace _26_1WhyProperties_problem_with_public_keys
{

    public class Student
    {
        // becouse this are public fields anyone can access and change there values( WHICH IS WRONG )
        public int ID;
        public string Name;
        public int passMark = 35;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.ID = -101; //someone should not assign negative value to this
            c1.Name = "null"; //someone should not assing null to name
            c1.passMark = 0; //someone shoul not change passing mark

            Console.WriteLine("id is " + c1.ID+ ", Name is :"+c1.Name + ", passmark is :" +c1.passMark);
            Console.ReadLine();



        }
    }
}
