using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] matrix3D = new int[3, 4, 5];

            //Console.WriteLine($"matrix3D.rank = {matrix3D.Rank}");

            //Console.WriteLine($"matrix3D.GetLength(0) {matrix3D.GetLength(0)}");
            //Console.WriteLine($"matrix3D.GetLength(1) {matrix3D.GetLength(1)}");
            //Console.WriteLine($"matrix3D.GetLength(2) {matrix3D.GetLength(2)}");
            
            //Console.ReadKey();

            Random random = new Random();

            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = random.Next(10);
                        Console.Write($"{matrix3D[i, j, k]} ");

                    }
                }
                Console.ReadKey();
            }

            
        }
    }
}
