using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Random rand = new Random();

            //            int x = rand.Next(3);
            //            Console.WriteLine($"Получено значение x = {x}");

            //            if (x == 1)
            //            {
            //                Console.WriteLine("x == 1");
            //            }
            //            else
            //            {
            //                Console.WriteLine("x !=1");
            //            }
            //            Console.ReadKey();


            //            Random r = new Random();
            //            double x = r.NextDouble();

            //1й СПОСОБ
            //
            //            int result = (x < 0.5) ? 0 : 1;
            //            Console.WriteLine($"result = {result}");

            //            Console.ReadKey();


            //2й СПОСОБ
            //            if (x < 0.5)
            //            {
            //                Console.WriteLine(0);
            //            }
            //            else
            //            {
            //                Console.WriteLine(1);
            //            }

            //            Console.ReadKey();

            //ОПРЕДЕЛЕНИЕ МАКСИМАЛЬНОГО И МИНИМАЛЬНОГО ЧИСЛА
            //            Random rand = new Random();

            //            int firstNumber = rand.Next(-21, 23);
            //            int secondNumber = rand.Next(-21, 23);
            //            int thirdNumber = rand.Next(-21, 23);

            //            int maxValue;

            //            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            //            {
            //                maxValue = firstNumber;
            //            }
            //            else
            //            {
            //                if (secondNumber > thirdNumber)
            //                {
            //                    maxValue = secondNumber;
            //                }
            //                else
            //                {
            //                maxValue = thirdNumber;
            //            }
            //        }
            //        Console.WriteLine($"Максимальное значение = {maxValue}");

            //                Console.ReadKey();


            //            Console.WriteLine("Игра \"Угадай-ка\"");

            //            Random rand = new Random();

            //        int iiNumber = rand.Next(1, 101);
            //        int count = 0;
            //        int userNumber;

            //            while (true)
            //            {
            //                Console.WriteLine("\nВведите число: ");
            //                count++;
            //                userNumber = Convert.ToInt32(Console.ReadLine());
            //                if (userNumber<iiNumber)
            //                {
            //                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз");
            //                }
            //                else if (userNumber > iiNumber)
            //                {
            //                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз");
            //                }
            //                else
            //{
            //    Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
            //    Console.ReadKey();
            //    break;
            //}




            //            }


            ////Заказчик просит создать эмулятор игры, в котором у игрока есть возможность выбрать
            ////уровень сложности, в зависимости от которого будет генерироваться разный игровой мир
            //Console.WriteLine("Введите уровень сложности. 1 - Простой, 2 - Средний, 3 - Сложный");
            //int level; // 1 - Простой
            //           // 2 - Средний
            //           // 3 - Сложный
            //           //Простой - 2 NPC
            //           //Средний - 4 NPC
            //           //Сложный - 6 NPC
            //level = Convert.ToInt32(Console.ReadLine());

            //if (level == 1) 
            //{
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //}
            //else if (level == 2)
            //{
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //}

            //else if (level == 3) 
            //{
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");
            //    Console.WriteLine("NPC Сгенерирован");

            //}

            //else
            //{
            //    Console.WriteLine("Выбран неизвестный уровень сложности");
            //}

            //Random rand = new Random();

            //Console.WriteLine($"1-е случайное число {rand.Next(-8, 10)}");
            //Console.WriteLine($"2-е случайное число {rand.Next(-8, 10)}");
            //Console.WriteLine($"3-е случайное число {rand.Next(-8, 10)}");
            //Console.WriteLine($"4-е случайное число {rand.Next(-8, 10)}");
            //Console.WriteLine($"5-е случайное число {rand.Next(-8, 10)}");

            //Console.WriteLine("\nВведите число: ");
            //int value = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{value}^2 = {value * value}"); value++;
            //Console.WriteLine($"{value}^2 = {value * value}"); value++;
            //Console.WriteLine($"{value}^2 = {value * value}"); value++;
            //Console.WriteLine($"{value}^2 = {value * value}"); value++;
            //Console.WriteLine($"{value}^2 = {value * value}"); value++;

            //Console.ReadKey();

            //Console.WriteLine("n\Введите  numerator: ");
            //double numerator = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("n\Введите  denominator: ");
            //double denominator = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nИсходная дробь: {numerator}/{denominator}");

            //double a = numerator, b = denominator;

            //if (a != b) if (a > b) a = a - b; else b = b - a;


            //int value;
            //int i;
            //Console.WriteLine("Введите число:");
            //value = Convert.ToInt32(Console.ReadLine());

            //while (true)
            //{
            //    i = 2;
            //    i <= value;
            //    i++;
            //    if (value % i == 0)
            //    {
            //        Console.WriteLine("${value} Число не является простым!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("${value} Число простое!");
            //    }

            //    Console.ReadKey();


            }

        }
    }


