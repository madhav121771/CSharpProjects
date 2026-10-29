using System;
using PATA = ProjectA.TeamA; // this is the namespace alias used here for A
using PATB = ProjectB.TeamB;// this is the namespace alias used here for B



namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.Print(); // This is using namespace aliases we can avoid the ambiguity 
            PATB.ClassB.Print(); //of same name of methods belonging to the different namespaces
            Console.ReadLine();
        }
    }

}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");

            }
        }
        
    }
    
}

namespace ProjectB
{
    namespace TeamB
    {
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
             }

        }
    }


}









