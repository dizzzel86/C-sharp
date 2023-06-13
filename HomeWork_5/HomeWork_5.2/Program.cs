using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork_5._2
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

        static string[] ReverseString(string inputText)
        {
            string userInput = inputText;
            string[] reverseUserInput = userInput.Split(' ');
            
            for (int i = reverseUserInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(reverseUserInput[i]);
            }
            return reverseUserInput;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите текст: ");
            string userInputText = Console.ReadLine();
            SplitString(userInputText);
            ReverseString(userInputText);

            Console.ReadKey();



        }
    }
}
