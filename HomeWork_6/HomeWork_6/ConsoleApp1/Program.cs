using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Program
    {
        static string[] SplitString(string inputText)
        {
            string userInput = inputText;
            string[] splitUserInput = userInput.Split('\t');


            for (int i = 0; i < splitUserInput.Length; i++)
            {
                string[] str = splitUserInput;


            }
            return splitUserInput;

        }

        static string[] PrintString(string inputText)
        {
            string userInput = inputText;
            string[] printString = userInput.Split('\t');

            for (int i = 0; i <
                printString.Length - 1; i++)
            {
                Console.Write($"{printString[i]} # ");
            }
            return printString;
        }
        static void Main(string[] args)
        {


            Console.WriteLine($"Справочник <<СОТРУДНИКИ>>");

            Console.WriteLine("Сделайте выбор:");
            string currentFile = @"workers.csv";

            Console.WriteLine($"Введите <1> для ввода данных\nВведите <2> для просмотра справочника");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                using (StreamWriter sw = new StreamWriter("workers.csv", true, Encoding.Unicode))
                {
                    char key = 'д';

                    do
                    {
                        string userInput = string.Empty;
                        Console.Write("Введите ID: ");
                        userInput += $"{Console.ReadLine()}\t";

                        string time = DateTime.Now.ToShortTimeString();
                        Console.WriteLine($"Время записи {time}");
                        userInput += $"{time}\t";

                        Console.Write("Введите ФИО: ");
                        userInput += $"{Console.ReadLine()}\t";

                        Console.Write("Введите Возраст: ");
                        userInput += $"{Console.ReadLine()}\t";

                        Console.Write("Введите Рост: ");
                        userInput += $"{Console.ReadLine()}\t";
                                                
                        Console.Write("Введите Дату рождения: ");
                        userInput += $"{Console.ReadLine()}\t";

                        Console.Write("Введите Место рождения: ");
                        userInput += $"{Console.ReadLine()}\t";
                        sw.WriteLine(userInput);
                        Console.Write("Продолжить?\nВведите <д> - ДА / <н> - НЕТ");
                        key = Console.ReadKey(true).KeyChar;
                        Console.WriteLine();
                    }
                    while (char.ToLower(key) == 'д');
                }
            }

            else if (userChoice == "2")
            {

                if (!File.Exists(currentFile))
                {
                    Console.WriteLine("ФАЙЛ СПРАВОЧНИКА ОТСУТСТВУЕТ!!!\nПопробуйте еще раз!\n" +
                        "При повтороном вызове программы выберите <1> для ввода данных!");

                }

                else
                {
                    using (StreamReader sr = new StreamReader("workers.csv", Encoding.Unicode))
                    {
                        string line;
                        
                        while ((line = sr.ReadLine()) != null)
                        {
                            SplitString($"{line}");
                            PrintString($"{line}");
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Введено некорректное значение!");
            }

            Console.ReadKey();
        }
    }
}









