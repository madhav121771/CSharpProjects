using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_2_MulticaseDelegate
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del();

            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4(); // this will invoke all the three methods which is called as multicast delegate
        }

         public static void SampleMethodOne()
        {
            Console.WriteLine(" SampleMethodOne Invoked");
            Console.ReadLine();
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine(" SampleMethodOne Invoked");
            Console.ReadLine();
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine(" SampleMethodOne Invoked");
            Console.ReadLine();
        }
    }
}
//* Multicast Delegate
//		- delegate that has references to more than one function
//		- when invoke multicast delegate - all functions the delegate is pointing to are invoked
//		- (+) sign will register the method with delegate and (-) sign will unregister the method with delegate
//		- multicase case delegate makes implementation of observer design pattern very simple and it is usefull there.
