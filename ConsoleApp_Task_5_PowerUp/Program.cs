using System;

namespace ConsoleApp_Task_5_PowerUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите степень числа {x}: ");
            int pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} в степени {pow} = {PowerUp(x, pow)}");
        }


        private static int PowerUp(int N, int pow)
        {
            if (pow > 0)
            {
                 return N * PowerUp(N, --pow);
            }
            else
                return 1;
         }

    }
}
