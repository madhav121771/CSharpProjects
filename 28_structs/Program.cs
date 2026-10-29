using System;

namespace _28_structs
{

    public struct Customer
    {
        //We can have fields in struct like below
        private int _id;
        private string _name;

        // we can have properties in struct like below
        public int ID
        { 
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name { get => _name; set => _name = value; } // we can encapsulate this field by using refactoring

        // we can have parametrized constructor in struct like below

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        // we can have methods in struct like below
        public void PrintDetails()
        {
            Console.WriteLine("Id :" + this._id + "Name:" + this._name);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer c1 = new Customer(101, "Mark");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "Reena";
            c2.PrintDetails();

            //OBJECT INITIALIZER SYNTAX is very helpfull as below
            Customer c3 = new Customer
            {
                ID = 103,
                Name = "Madhav"
            };
            c3.PrintDetails();

        }
    }
}

//Note: DIFFERENCES BETWEEN STRUCT AND CLASSES

//1) struct id value type and class id refernce type
//2) struct are stoared on stack | classes are stored on heap
//3) Value type hold their values in memory where they are declared but referece type hold an reference to an object in memory
//4) Value type are destroyed immediatly when the scope is lost 
    // but Referece type only the referce variable is destroyed when the scope id lost
    // OBJECT is later destroyed by garbage collector
//5) when you copy a struct in to another struct - new copy is created 
//6) struct cant have destructors but classes can have
//7) struct can not contains parameter less constructor but class can have
//8) struct cn not inherit from another struct but classes can
//9) struct and classes can inherit from interface
//10) stuct are sealed type they can not inherit further 
     // sealed keyword is used to avoid being inherited by another class

