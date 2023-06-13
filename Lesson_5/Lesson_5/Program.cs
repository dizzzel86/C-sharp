using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        
        static void Delay()
        {
            Console.ReadKey();
        }

        static public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Print(string Text)
        {
            Console.WriteLine(Text);
        } 

        static void Main(string[] args)
        {
            HelloWorld();

            Print("Привет как дела?");
            
            Delay();

            //Есть 2 массива, содержащие не менее 10 и не более 20 элементов.
            //Организовать заполнение и вывод на экран каждого из них
            //Найти максимальный и минимальный элементы в каждом массиве

            //Random rand = new Random();

            //int N = rand.Next(10, 20);

            //int[] mas1 = new int[N];
            //int[] mas2 = new int[N];

            //for (int i = 0; i < mas1.Length; i++)
            //{
            //    mas1[i] = rand.Next(20);
            //    mas2[i] = rand.Next(20);

            //}

            ////Поиск

            //int maxMas1 = mas1[0];
            //int minMas1 = mas1[0];
            //int maxMas2 = mas2[0];
            //int minMas2 = mas2[0];

            //for (int i = 0; i < mas1.Length;i++)
            //{
            //    if (mas1[i] > maxMas1) maxMas1 = mas1[i];
            //    if (mas1[i] < minMas1) minMas1 = mas1[i];

            //    if (mas2[i] > maxMas2) maxMas2 = mas2[i];
            //    if (mas2[i] < minMas2) minMas2 = mas2[i];

            //}

            //Console.WriteLine("mas1");

            //for (int i = 0;i < mas1.Length;i++)
            //{
            //    Console.Write($"{mas1[i],3}");
            //}

            //Console.WriteLine($"\nmaxMas1 = {maxMas1}");
            //Console.WriteLine($"\nminMas1 = {minMas1}");

            //Console.WriteLine("mas2");

            //for (int i = 0; i < mas2.Length; i++)
            //{
            //    Console.Write($"{mas2[i],3}");
            //}
            //Console.WriteLine($"\nmaxMas2 = {maxMas2}");
            //Console.WriteLine($"\nminMas2 = {minMas2}");

            //Console.ReadKey();

            //Random rand = new Random();
            //нерабочий кусок описывающий логику
            //int N = rand.Next(10, 20);
            //int M = rand.Next(10, 20);

            //int[] arr = new int[N];
            //int[] brr = new int[M];

            //Fill(arr);
            //Print(arr);

            //Fill(brr);
            //Fill(brr, N);
            //Fill(brr, N, 10, 20);

            //Print(brr);

            //int maxArr = Max(arr);
            //int maxBrr = MaxValue(brr);
            //int minArr = Min(arr);
            //int minBrr = Min(brr);

            

        }
    }
    
}
