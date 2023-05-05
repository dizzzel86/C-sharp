using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Программа определения четноcти числа
            Console.WriteLine("\nОпределение четности числа");
            int userNumber;
            while (true)
            {
                Console.WriteLine("\nВведите число: ");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Введенное число четное.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Введенное число нечетное.");
                    Console.ReadKey();  
                    break;
                }

            }













        }

        }
    }











