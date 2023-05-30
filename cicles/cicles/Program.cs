using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цикл while
            int value;
            Console.Write("Введите число: ");
            value = Convert.ToInt32(Console.ReadLine());

            while (value > 1)
            {
                if (value % value != 0)
                    {
                    Console.WriteLine("$Значение {value}");
                }

            }

           

        }
    }
}
