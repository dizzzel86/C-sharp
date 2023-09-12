using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int>();
            char key = 'н';
            Console.WriteLine($"Проверка ввода дубликатов");

            bool repeat = true;
            while (repeat)
            {
                Console.Write($"Введите число: ");
                string value = Console.ReadLine();
                bool isNumber = Int32.TryParse(value, out int result);
                if (!string.IsNullOrEmpty(value))
                {
                    if (isNumber)
                    {
                        if (!nums.Contains(result))
                        {
                            nums.Add(result);
                        }
                        else
                        {
                            Console.WriteLine($"Введенное число уже вводилось ранее, попробуйте еще раз!!!");
                        }
                    }
                    else { Console.WriteLine($"Введите числовое значение"); }
                }
                else
                {
                    Console.WriteLine($"Вы не ввели какое-либо значение!!!");
                }
                Console.WriteLine("Продолжить?\nВведите <д> - ДА / <н> - НЕТ");
                key = Console.ReadKey(true).KeyChar;
                if (char.ToLower(key) == 'н') repeat = false;
            }

            Console.WriteLine($"Введенная Вами последовательность:");
            foreach (int i in nums)
            {
                Console.WriteLine($"{i}"); 
            }
            Console.ReadKey();


        }
    }
}
