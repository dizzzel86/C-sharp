using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Chentsov D.A.";
            sbyte age = 36;
            string eMail = "d.chentsov@my.com";
            double programmingPoints = 3.5;
            double mathPoints = 9;
            double phisxPoints = 4;

            string pattern = "ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы за программирование: {3} \nБаллы за матиматику {4} \nБаллы за физику: {5}";
            Console.WriteLine(pattern,
                fullName,
                age,
                eMail,
                programmingPoints,
                mathPoints,
                phisxPoints);

            Console.ReadKey();

            Console.WriteLine();

            double sum = programmingPoints + mathPoints + phisxPoints;
            double average = ((programmingPoints + mathPoints + phisxPoints) / 3);

            string newPattern = "Сумма всех баллов: {0} \nСредний балл: {1}";
            Console.WriteLine(newPattern,
                sum,
                average);
            Console.ReadKey();
        }
    }
}
