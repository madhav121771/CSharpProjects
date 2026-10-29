using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_1_UsageofDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emplyoee> empList = new List<Emplyoee>();

            empList.Add(new Emplyoee() { ID = 101, Name = "Madhav", Salary = 5000, Experience = 5 });
            empList.Add(new Emplyoee() { ID = 101, Name = "Rahul", Salary = 4000, Experience = 4 });
            empList.Add(new Emplyoee() { ID = 101, Name = "Reena", Salary = 6000, Experience = 6 });
            empList.Add(new Emplyoee() { ID = 101, Name = "Somesh", Salary = 8000, Experience = 3 });

            Emplyoee.PromotEmployee(empList,Promote); // passing true or false for promot by cchecking in this calling class only
                                                      //and this is the best use of delegates - which help is to decouple the logic from below class
 
            //orelse to make more easy you can use lamda expression as shown below to call it (try uncommenting)
            //Emplyoee.PromotEmployee(empList, emp => emp.Experience >= 5);

            Console.ReadLine();

        }

        public static bool Promote(Emplyoee emp) //delegate is pointing to this function where actual logic is written
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool Ispromotable(Emplyoee empl);
    class Emplyoee
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotEmployee(List<Emplyoee> emplyoeeList, Ispromotable IsEligibleToPromote)
        {
            foreach (Emplyoee employee in emplyoeeList)
            {
                if (IsEligibleToPromote(employee)) // this decision of promotion is made by caller side and no need to hard code the logic here
                {
                    Console.WriteLine(employee.Name + "Promoted");
                }
            }
        }

    }
}
//Note : delegates are type safe function pointer

