using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Программа определения является ли число простым
            Console.WriteLine("\nОпределение является ли число простым");

            int i = 2;
            int value;
            bool notSimpleValue = false;
            Console.WriteLine("Введите число:");
            value = Convert.ToInt32(Console.ReadLine());

            while (i <= value - 1)
            {

                if (value % i == 0)
                {
                    notSimpleValue = true;
                    break;
                }
                i++;
            }
            if (notSimpleValue == false)
            {
                Console.WriteLine("Число является простым!");
            }
            else
            {
                Console.WriteLine("Число не является простым!");
            }


            Console.ReadKey();
        }
    }
}
