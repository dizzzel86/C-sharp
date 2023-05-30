using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine($"Случайная матрица!");

            Console.Write($"Введите требуемое количество строк: ");
            int stringsInMatrix = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите требуемое количество столбцов: ");
            int columnsInMatrix = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[stringsInMatrix, columnsInMatrix];

            int sumOfMatrixValues = 0;
            
            Console.WriteLine($"\n\nВаша матрица: ");
            for (int str = 0; str < stringsInMatrix; str++)
            {

                for (int col = 0; col < columnsInMatrix; col++)
                {

                    matrix[str, col] = random.Next(0, 100);
                    Console.Write($"{matrix[str, col],2}  ");
                    sumOfMatrixValues += matrix[str, col];

                }

                Console.WriteLine();

            }
            Console.WriteLine($"Сумма элементов масиива: {sumOfMatrixValues}!");

            Console.ReadKey();




        }






    }
}

