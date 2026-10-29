using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_delegates
{
    public delegate void HelloFunctionDelegate(string message);
     class Program
    {
        static void Main(string[] args)
        {   
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hello from delegate");

            //delegate is type safe function pointer

        }
        public static void Hello(string strmessage)
        {
            Console.WriteLine(strmessage);
            Console.ReadLine();
        }

    }
}

//note
//1 - delegate is type safe function pointer, it holds refernce to a function
//2 - signiture of delegate must match with signiture of function the delegates points to, otherwise you will get compile error.
    // this is why delegates are called as type safe function pointers.
//3 - delegate is very similar to a class and you can create a instance of it & you pass in function name as parameter to delegate constructor

//4 -  delegate syntax is very much similar to function with delegate keyword

