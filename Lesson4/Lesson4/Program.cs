
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] x;

            //x = new int[3];

            //x[0] = 1;
            //x[1] = 2;
            //x[2] = 3;

            //double[] array = new double[5];

            //array[0] = 3;
            //array[1] = 5;
            //array[2] = 8;
            //array[3] = 13;
            //array[4] = 21;


            //int[] birthdayCollection = new int[8] {2, 8, 0, 9, 1, 9, 9, 0 };
            //int[] newYearCollection = new int[] { 31, 12, 2319 };
            //string[] dateCollection = { "01", "01", "1771" };

            //Console.WriteLine("Сформировать масси из N случайных чисел от -5 до 5");

            //Console.WriteLine("Введите n: ");
            //int n = int.Parse(Console.ReadLine());

            //Random random = new Random();

            //int[] numbs = new int[n];

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(-5, 6);
            //    Console.Write(numbs[i]);
            //}

            //Console.ReadKey();

            //Console.WriteLine("Сформировать масси из N случайных чисел. Подсчитать количество четных чисел");
            //Random random = new Random();

            //Console.WriteLine("Введите n: ");
            //int n = int.Parse(Console.ReadLine());

            //var numbs = new int[n];



            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(10);
            //}

            //int evenElement = 0;

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    if (numbs[i] % 2 == 0) evenElement++;
            //}

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write(numbs[i]  + " ");
            //}

            //Console.WriteLine($"\n Чётных чисел: " + evenElement);

            //Console.ReadKey();


            //Console.WriteLine("В массиве из 10 чисел вычислить сколько раз встречается ввденное число");

            //int[] numbs = new int[10];
            //Random random = new Random();

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(10);
            //    Console.Write(numbs[i] + " ");
            //}

            //Console.Write("Какое число ищем?: ");
            //int n = int.Parse(Console.ReadLine());

            //int find = 0;

            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    if (numbs[i] == n) find++;
            //}

            //Console.WriteLine($"\nЭлемент '{n}' найден: {find} раз.");

            //Console.ReadKey();


            Console.WriteLine("Массив из N элементов состоит из нуелй и единиц.\nПоставить нули в начало, а единицы - в конец.");

            Console.WriteLine("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbs = new int[n];
            Random rand = new Random();

            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rand.Next(0, 2);
                Console.Write(numbs[i] + " ");
            }

            int head = 0;
            int tail = numbs.Length - 1;

            bool flag = true;

            while (head < tail)
            {
                if (flag)
                {
                    if (numbs[head] == 1) { flag = false; }
                    else { head++; }
                }
                else
                {
                    if (numbs[tail] == 0) { flag = true; }
                    else { tail--; };
                }

                if (numbs[head] == 1 && numbs[tail] == 0)
                {
                    int temp = numbs[head];
                    numbs[head] = numbs[tail];
                    numbs[tail] = temp;

                    head++;
                    tail--; 
                }
            }

            Console.Write("Получившийся массив: ");

            for (int i = 0;i < numbs.Length;i++)
            {
                Console.Write(numbs[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
