using System;
namespace Operators

{
    class Program
    {
        static void Main()
        {
            //~ASSIGNMENT~ Operator Example
            //Single= is the assignment operator
            int i = 10;
            bool b = true;
            
            // deviding 2 numbers we can use either % or /
            int numerator = 10;
            int Denominator = 2;
            //~ARITHMATIC~ operator / returns quoitient
            int Quotient = numerator / Denominator;

            
            Console.WriteLine("Quotient {0}",Quotient);
            //Arithmatic oprator % return  remainder
            int Remainder = numerator % Denominator;
            Console.WriteLine("Remainder {0}", Remainder);

            //To ~COMPARISION~ if 2 numbers are equal use comparision operator ==
            int number = 10;
            if ( number == 10)
            {
                Console.WriteLine("Number is equals to 10");
            }
            //ToCompare if 2 numbers are not equal then use comparision != operator
            if ( number != 10)
            {
                Console.WriteLine("Number is not eqauls to 10");
            }
            
            //~CONDITIONAL~
            //when && operator is used all the conditions must be true in the if blog
            int number1 = 10;
            int number2 = 20;
            if (number1 ==10 && number2 == 20)
            {
                Console.WriteLine("Both Conditions are true");
            }
            //When || operator is used atlease one condition must be true in if blog
            if (number1 == 10 || number2 == 21)
            {
                Console.WriteLine("Atlest one  Conditions is true");
            }

            //without ~TERNORY OPERATOR~
            int number3 = 10;
            bool isNumber10;

            if (number3 == 10)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("Number3 == 10 is {0}", isNumber10);

            //With ~TERNORY OPERATOR~
            isNumber10 = number3 == 10 ? true : false;
            Console.WriteLine("Number3 == 10 is {0}", isNumber10);
            
            Console.ReadLine();
        }
    }
}
