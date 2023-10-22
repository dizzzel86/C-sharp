using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Client.json";
            Person person = new Person();
            if (File.Exists(path))
            {
                person = JsonConvert.DeserializeObject<Person>(File.ReadAllText(path));
                person.PrintPerson(person);
            }
            else
            {
                new Person();
                bool boolean = true;

                while (boolean)
                {
                    Console.Write($"Введите Фамилию: ");
                    person.Surname = Console.ReadLine();
                    Console.Write($"Введите Имя: ");
                    person.Name = Console.ReadLine();
                    Console.Write($"Введите Отчество: ");
                    person.Patronymic = Console.ReadLine();
                    Console.Write($"Введите номер телефона: ");
                    person.PhoneNumber = Console.ReadLine();
                    Console.Write($"Введите Серию и номер паспорта: ");
                    person.PassportDetails = Console.ReadLine();

                    File.WriteAllText(path, JsonConvert.SerializeObject(person));
                    boolean = false;

                }
            }




            Console.ReadKey();



        }
    }
}
