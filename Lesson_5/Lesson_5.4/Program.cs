using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_5._4
{
    internal class Program
    {
        /// <summary>
        /// Рекурсия
        /// </summary>
        static void Infinity()
        {
            Console.Write("0_o ");
            //Thread.Sleep(100);
            Infinity();
        }

        static void NotInfinity(int Count)
        {
            Console.Write("0_o ");
            Thread.Sleep(100);
            Count = Count - 1;
            if (Count > 0) //Базовый случай/случай выхода
            {
                NotInfinity(Count);
            }

        }
        /// <summary>
        /// Рекурсия
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int Fib(int N)
        {
            return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);
        }

        /// <summary>
        /// Цикл
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int Fibonacci(int N)
        {
            int a1 = 1;
            int a2 = 1;
            int t = a2;

            for (int i = 2; i < N; i++)
            {
                t = a1 + a2;
                a1 = a2;
                a2 = t;
            }

            return t;
        }

        /// <summary>
        /// рекурсия
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static string Numbers(int N)
        {
            return N < 10 ? N.ToString() : $"{Numbers(N / 10)} {N % 10}";
        }

        static void Main(string[] args)
        {
            //Infinity();

            NotInfinity(2);
            Console.ReadKey();
        }
    }
}
