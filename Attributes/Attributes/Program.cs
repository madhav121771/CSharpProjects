namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int sum =  Calculator.Add(10, 20);
            Console.WriteLine("Addition is :" + sum);

        }
    }

    public class Calculator
    {
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;

        }
    }


}
