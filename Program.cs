using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            throwErrorFunction();
            
        }

            static void throwErrorFunction()
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter a second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num1 / num2);
                }
                catch(Exception e)
                {
                Console.WriteLine(e.Message);

                }
                Console.ReadLine();
            }
     }
}

