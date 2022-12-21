using System;

namespace ConsoleApp_Task_5._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }

        static void color(int deep)
        {
            switch (deep)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                                          
                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                                         
                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    
                                        
                    break;
                
                case 4:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
 
                    break;

                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    break;


                default:
                    Console.BackgroundColor = ConsoleColor.Gray;
                                        
                    break;
            }

        }

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            color(deep);
            
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

    }
}
