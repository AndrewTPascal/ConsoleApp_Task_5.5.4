using System;

namespace ConsoleApp_Task_5_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x}! = {Factorial(x)}") ;
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

    }
}
