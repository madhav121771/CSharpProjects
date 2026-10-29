using System;

class TriangleDrawer
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle: ");
        if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
