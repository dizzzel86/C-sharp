using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Игра "Угадай число"
            Console.WriteLine("Игра \"Угадай число\"");

            Random rand = new Random();

            Console.Write($"Введите максимальное число диапазона: ");
            int maxValue;
            int.TryParse(Console.ReadLine(), out maxValue);
            int iiNumber = rand.Next(0, maxValue + 1);
            int count = 0;
            int userNumber;

            while (true)
            {
                Console.WriteLine("\nВведите число: ");
                count++;

                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out userNumber);
                if (userInput == string.Empty)
                {
                    Console.WriteLine($"Загаданное число: " + iiNumber);
                    Console.ReadKey();
                    break;
                }

                if (isNumber)
                {
                    if (userNumber < iiNumber)
                    {
                        Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз");
                    }
                    else if (userNumber > iiNumber)
                    {
                        Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз");
                    }

                    else
                    {

                        Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
                        Console.ReadKey();
                        break;
                    }
                }

                else
                {
                    Console.WriteLine($"Введите числовое значение!!!");
                }
            }
        }
    }
}
