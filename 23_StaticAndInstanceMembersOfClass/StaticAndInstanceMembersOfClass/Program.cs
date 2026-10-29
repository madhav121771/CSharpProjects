using System;


//*********************************************** FOR INSTANCE FIELDS OF CLASS *******************************************************
//namespace StaticAndInstanceMembersOfClass
//{

//    class Circle
//    {
//        float _PI = 3.14F; // this is instance field of the class
//        int _radius;       // this is instance field of the class


//        public Circle(int radius) // this is also instance constructor of the class
//        {
//            _radius = radius;
//        }

//        public float CalculateArea() // this is instance method of the class
//        {
//            float Area = this._PI * this._radius * this._radius;
//            return Area;
//        }

//    }

//    class Program
//    {
//        static void Main()
//        {
//            float AREA;
//            Circle C1 = new Circle(5); 
//            AREA = C1.CalculateArea();
//            Console.WriteLine("Area Of Circle is : " +AREA );
//            Console.ReadLine();
//        }
//    }


//}
//*********************************************** FOR STATIC FIELDS OF CLASS *******************************************************
namespace StaticAndInstanceMembersOfClass
{

    class Circle
    {
         static float _PI ; // this is static field of the class
        int _radius;

        static  Circle() // access modifiers are not allowed on static constructor
        {
            // need not to call this constructor explicitly
            //static constructor called before instance constructor
            Console.WriteLine("Static constructor Called");
            Circle._PI = 3.14F;

        }

        public Circle(int radius) // parameterised instance constructor
        {
            _radius = radius;
        }

        public static void Print() //static method here
        {
            // some work
        }

        public float CalculateArea() //instance method here
        {
            float Area = Circle._PI * this._radius * this._radius;
            return Area;
        }

    }

    class Program
    {
        static void Main()
        {
            float AREA;
            Circle C1 = new Circle(5);
            Circle.Print(); // name of the class is used to call static method
            AREA = C1.CalculateArea();
            Console.WriteLine("Area Of Circle is : " + AREA);
            Console.ReadLine();

        }
    }


}
