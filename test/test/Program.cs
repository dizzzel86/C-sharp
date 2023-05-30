using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age;

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            age = byte.Parse(Console.ReadLine());


            
            Random rand = new Random();

            int x = rand.Next(3);
            Console.WriteLine($"Получено значение x = {x}");

            if (x == 1)
            {
                Console.WriteLine("x == 1");
            }
            else
            {
                Console.WriteLine("x !=1");
            }
            Console.ReadKey();


            Random r = new Random();
            double x = r.NextDouble();

            int result = (x < 0.5) ? 0 : 1;
            Console.WriteLine($"result = {result}");

            Console.ReadKey();

            if (x < 0.5)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }

            Console.ReadKey();


            Random rand = new Random();

            int firstNumber = rand.Next(-21, 23);
            int secondNumber = rand.Next(-21, 23);
            int thirdNumber = rand.Next(-21, 23);

            int maxValue;

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                maxValue = firstNumber;
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    maxValue = secondNumber;
                }
                else
                {
                    maxValue = thirdNumber;
                }
            }
            Console.WriteLine($"Максимальное значение = {maxValue}");

            Console.ReadKey();


            Console.WriteLine("Игра \"Угадай-ка\"");

            Random rand = new Random();

            int iiNumber = rand.Next(1, 101);
            int count = 0;
            int userNumber;

            while (true)
            {
                Console.WriteLine("\nВведите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
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
        }
    }
}
