using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Program
    {
        static string[] SplitString(string inputText)
        {
            string userInput = inputText;
            string[] splitUserInput = userInput.Split(' ');


            for (int i = 0; i < splitUserInput.Length; i++)
            {
                string[] str = splitUserInput;
                

            }
            return splitUserInput;

        }

        static void Print(string text)
        {
            string[] str = SplitString(text);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
                    
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите текст: ");
            string str = Console.ReadLine();

            SplitString(str);
            Print(str);

            Console.ReadKey();
        }
    }
}
