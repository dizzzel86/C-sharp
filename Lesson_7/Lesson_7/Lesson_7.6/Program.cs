using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";

            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);

            rep.Add(new Worker("111", "111", "1111", 111, "111"));

            rep.PrintDbToConsole();

            Console.ReadKey();
        }
    }
}
