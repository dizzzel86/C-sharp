using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._3
{
    internal class Program
    {
        /// <summary> 
        /// Метод, заполняющий массив Col
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Fill(int[] Col)
        {
            Random rand = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = rand.Next(100);
            }
        }

        /// <summary>
        /// Метод, заполняющий первых Countэлементов массив Col
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Fill(int[] Col, int Count)
        {
            Random rnd = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = rnd.Next(100);
            }
        }

        /// <summary>
        /// Метод, заполняющий элементы массива Col числами из диапазона BottomRange - UpperRange
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Fill(int[] Col, int BottomRange, int UpperRange)
        {
            Random random = new Random();
            for (int i = 0; i < Col.Length; i++)
            {
                Col[i] = random.Next(BottomRange, UpperRange);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
        {
            Random random = new Random();
            for (int i = 0; i < Count; i++)
            {
                Col[i] = random.Next(BottomRange, UpperRange);
            }
        }
        /// <summary>
        /// Метод Print хрень какая-то
        /// </summary>
        /// <param name="Text"></param>
        static void Print(int[] Col)
        {
            Console.Write("____" + Col);
        }

        static int Sum(int Factor, params int[] Args)
        {
            int result = 0;

            foreach (var e in Args)
            {
                result += e;
            }
            return result * Factor;
        }

        /// <summary>
        /// перегрузка методов Sum
        /// </summary>
        /// <param name="Factor"></param>
        /// <param name="Msg"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(int Factor, string Msg, params int[] Args) { return 0; }
        static int Sum(double Factor, string Msg, params int[] Args) { return 0; }
        static int Sum(double Factor, string Msg, params double[] Args) { return 0; }




        static void Main(string[] args)
        {
            int[] arr = new int[20];

            Fill(arr, 10); //static void Fill(int[] Col, int Count)
            Print(arr);
            Console.ReadKey();

            Fill(arr); //static void Fill(int[] Col)
            Print(arr);
            Console.ReadKey();

            Fill(arr, -10, 0); // static void Fill(int[] Col, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();


            Fill(arr, 10, 1, 30); // static void Fill(int[] Col, int Count, int BottomRange, int UpperRange)
            Print(arr);
            Console.ReadKey();

            var res = Sum(1);
            res = Sum(1, 9);
            res = Sum(1, 9, 9);
            res = Sum(1, 9, 9, 0);
            res = Sum(1, 9, 9, 0, 2);
            res = Sum(1, 9, 9, 0, 2, 8);

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            Console.WriteLine(res);

            res = Sum(13, new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            Console.WriteLine(res);

            res = Sum(8, new int[] { 2, 8, 0, 9 });
            Console.WriteLine(res);

            res = Sum(5, new int[] { 2, 8 });
            Console.WriteLine(res);

            res = Sum(3, new int[] { 2, });
            Console.WriteLine(res);
        }
    }
}
