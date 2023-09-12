using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string path = @"dict.csv";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            Console.WriteLine($"Телефонная книга");
            Console.WriteLine($"Введите <1> для добавления записи.\n" +
                $"Введите <2> для просмотра телефонной книги.\n" +
                $"Введите <3> для просмотра записи по номеру телефона.");
            string userChoice = Console.ReadLine();
            if (!string.IsNullOrEmpty(userChoice))
            {
                if (userChoice == "1")
                {
                    StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode);

                    while (true)
                    {
                        Console.Write($"Введите номер телефона:");
                        string phoneNumber = Console.ReadLine();

                        if (!string.IsNullOrEmpty(phoneNumber))
                        {
                            Console.Write($"Введите ФИО: ");
                            string fullName = Console.ReadLine();
                            if (!string.IsNullOrEmpty(fullName))
                            {
                                dic.Add(phoneNumber, fullName);
                            }
                            else
                            {
                                Console.WriteLine($"Введите значение!!!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Введите значение!!!");
                            foreach (KeyValuePair<string, string> pair in dic)
                            {
                                sw.WriteLine(pair);
                            }
                            sw.Close();
                            break;
                        }
                    }
                }
                if (userChoice == "2")
                {
                    string[] lines = File.ReadAllLines(path);
                    Dictionary<string, string> phoneBook = new Dictionary<string, string>();


                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        string line_1 = line.Split(',')[0];
                        string subLine_1 = line_1.Substring(1);
                        string line_2 = line.Split(',')[1];
                        string subLine_2 = line_2.Substring(1, line_2.Length - 2);

                        phoneBook.Add(subLine_1, subLine_2);
                    }

                    foreach (KeyValuePair<string, string> pair in phoneBook)
                    {
                        Console.WriteLine(pair);
                    }
                }

                if (userChoice == "3")
                {
                    string[] lines = File.ReadAllLines(path);
                    Console.WriteLine($"Введите номер телефона для поиска: ");
                    string userInput = Console.ReadLine();
                    bool flag = false;



                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        string line_1 = line.Split(',')[0];
                        string subLine_1 = line_1.Substring(1);
                        if (userInput == subLine_1)
                        {
                            Console.WriteLine($"В телефонной книге присутствует следующая запись: {line}");
                            flag = true;
                            break;
                        }


                    }
                    if (!flag)
                    {
                        Console.WriteLine($"Пользователя с данным номером телефона в Телефонной книге нет!");
                    }


                }
            }
            else
            {
                Console.WriteLine($"Введите значение!!!");
            }
            Console.ReadKey();
        }
    }
}
