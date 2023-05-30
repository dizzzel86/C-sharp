using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine($"Сложение матриц!");

            Console.Write($"Введите требуемое количество строк: ");
            int stringsInMatrix = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите требуемое количество столбцов: ");
            int columnsInMatrix = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[stringsInMatrix, columnsInMatrix];
            int sumOfMatrix1stValues = 0;

            Console.WriteLine($"\n\nВаша матрица: ");
            for (int str = 0; str < stringsInMatrix; str++)
            {
                for (int col = 0; col < columnsInMatrix; col++)
                {
                    matrix[str, col] = random.Next(0, 5);
                    Console.Write($"{matrix[str, col]}  ");
                    sumOfMatrix1stValues += matrix[str, col];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма первой матрицы: {sumOfMatrix1stValues}");

            int newStringsInMatrix = stringsInMatrix;
            int newColumnsInMatrix = columnsInMatrix;
            int[,] newMatrix = new int[newStringsInMatrix, newColumnsInMatrix];
            int sumOfMatrix2ndValues = 0;

            for (int newStr = 0; newStr < newStringsInMatrix; newStr++)
            {
                for (int newCol = 0; newCol < newColumnsInMatrix; newCol++)
                {
                    newMatrix[newStr, newCol] = random.Next(0, 5);
                    Console.Write($"{newMatrix[newStr, newCol]}  ");
                    sumOfMatrix2ndValues += newMatrix[newStr, newCol];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма второй матрицы: {sumOfMatrix2ndValues}");

            
            int row = stringsInMatrix;
            int coll = columnsInMatrix;
            int[,] result = new int[row, coll];
            int sumOfMatrix3rdValues = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    result[i, j] = matrix[i, j] + newMatrix[i, j];
                    Console.Write(result[i, j] + " ");
                    sumOfMatrix3rdValues += result[i, j];
                }

                Console.WriteLine();
            }
            Console.WriteLine($"Сумма итоговой матрицы: {sumOfMatrix3rdValues}");

            Console.ReadKey();
        }


    }
}

