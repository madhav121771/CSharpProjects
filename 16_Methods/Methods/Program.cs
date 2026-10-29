using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            //Creating object of class to call method in it
            Program obj = new Program();
            obj.EvenNumbers();
            int Sum = obj.Add(10, 20);
            Console.WriteLine("Result of add :" + Sum);
            Console.ReadLine();

            
        }
        //Add method
        public int Add(int FN, int SN)
        {
            int Result = FN + SN;
            return Result;
        }

        //Even number method
        public  void EvenNumbers() 
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start += 1;
            }
        }
              
    }
}
