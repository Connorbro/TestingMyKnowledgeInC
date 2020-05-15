using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[0, 0]);

            Console.ReadLine();

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");

        }
    }
}
