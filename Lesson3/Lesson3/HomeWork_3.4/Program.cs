using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.ОПРЕДЕЛЕНИЕ НАИМЕНЬШЕГО ЧИСЛА В ПОСЛЕДОВАТЕЛЬНОСТИ

            Console.Write("\nПрограмма определения наименьшего числа в последовательности");

            Console.Write("\n Введите длину последовательности:");
            int longOfValues = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[longOfValues];
            
            
            



            for (int i = 0; i < myArray.Length; i++)
            {
                               
                Console.Write($"\nВведите " + (i + 1) + " число: ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minValue = myArray[0];
            int maxValue = myArray[0];

            Console.WriteLine("\nВы ввели следующие значения: ");
            for (int i = 0; i < myArray.Length; i++)
            {

                Console.WriteLine($"\n{myArray[i]}");

                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                else
                {
                    maxValue = myArray[i];
                }
            }

            Console.WriteLine($"\nминимальное значение: " + minValue);
            Console.WriteLine($"\nмаксимальное значение: " + maxValue);
            Console.ReadKey();
        }
    }
}
