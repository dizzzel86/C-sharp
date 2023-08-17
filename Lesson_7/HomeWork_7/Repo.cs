using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls.Adapters;

namespace HomeWork_7
{
    class Repo
    {
        public static string path = @"workers.csv";

        //Функция добавления сотрудника
        public static void AddWorker(Worker worker)
        {
            //считываем файл в строки
            List<string> addWorkerStrings = new List<string>(File.ReadAllLines(Repo.path));
            //делаем цикл проверки id на уникальность
            //Запрашиваем число
            Console.Write($"Введите ID:");
            //Присваеваем введенное число переменной uniqueId
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int userNumber);
            if (isNumber)
            {
                int uniqueId = userNumber;
                //устанавливаем флаг уникальности
                bool contains = false;
                //запускаем цикл проверки на предмет совпадения id
                for (int i = 0; i < addWorkerStrings.Count; i++)
                {
                    //выделяем строку
                    string subStr = addWorkerStrings[i];
                    //выделяем первый симовл через подстроку, приводя к числу
                    int subSubStr = Int32.Parse(subStr[0].ToString());
                    //делаем проверку > если введенное значение id содержится в первом символе строки
                    if (subSubStr == uniqueId)
                    {
                        Repo.ErrorUniqueId();
                        contains = true;
                        break;
                    }
                }
                if (contains == false)
                {
                    Console.Write($"Введите ФИО: ");
                    string fullName = Console.ReadLine();
                    Console.Write($"Введите возраст: ");
                    int age = Int32.Parse(Console.ReadLine());
                    Console.Write($"Введите рост: ");
                    string height = Console.ReadLine();
                    Console.Write($"Введите дату рождения: ");
                    string dateOfBirth = Console.ReadLine();
                    Console.Write($"Введите место рождения: ");
                    string placeOfBirth = Console.ReadLine();
                    worker = new Worker
                    {
                        ID = uniqueId,
                        NowDateTime = DateTime.Now,
                        FullName = fullName,
                        Age = age,
                        Height = height,
                        DateOfBirth = dateOfBirth,
                        PlaceOfBirth = placeOfBirth
                    };
                    string addNewWorkerString = worker.WorkerString();
                    addWorkerStrings.Add(addNewWorkerString);
                    File.WriteAllLines(Repo.path, addWorkerStrings, Encoding.Unicode);

                }
            }
            else
            {
                Console.WriteLine($"Введите числовое значение, которе будет больше 0!!!");
            }

        }

        //Чтение файла и вывод информации 
        public static Worker[] GetAllWorkers()
        {
            Worker[] getAllWorkers = null;
            using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Worker.SplitString($"{line}");
                    Worker.PrintString(line);
                    Console.WriteLine();
                }
            }

            return getAllWorkers;

        }

        // Функция удаления строки из файла
        public static void DeleteWorker(int id)
        {
            List<string> fileStrings = new List<string>(File.ReadAllLines(path));
            bool contains = true;

            if (contains)
            {

                for (int i = 0; i < fileStrings.Count; i++)
                {
                    string line = fileStrings[i];
                    int firstItem = Int32.Parse(line[0].ToString());
                    if (firstItem == id)
                    {
                        fileStrings.Remove(line);
                        Console.WriteLine($"Запись <{line}> успешно удалена!");
                        File.WriteAllLines(path, fileStrings, Encoding.Unicode);
                        break;
                    }
                    else
                    {
                        contains = false;
                    }

                }

                if (!contains)
                {
                    Repo.ContainsError();
                }
            }

        }

        //Функция вывода информация о конкретном сотруднике
        public static void GetWorkerById(int id)
        {
            //устанавливаем флаг на наличие id
            bool contains = true;
            //считываем все строки из файла в LIST
            List<string> getWorkerStrings = new List<string>(File.ReadAllLines(Repo.path));
            //проходим циклом по строкам
            if (contains)
            {

                for (int i = 0; i < getWorkerStrings.Count; i++)
                {
                    //присваиваем строку в переменную
                    string line = getWorkerStrings[i];
                    //выделяем первый символ строки
                    int index = Int32.Parse(line[0].ToString());
                    //сравниваем если первый символ не совпадает с входным параметром
                    if (index == id)
                    {
                        Console.WriteLine($"{line}");
                        contains = true;
                        break;

                    }
                    else contains = false;

                }
                //если флаг не поменялся, значит id есть в файле, делаем проверку
               
                //если флаг поменялся на проверке наличия - выводим ошибку, что такого пользователя нет
                if (!contains)
                {
                    ContainsError();
                }
            }
        }


        //показываем ошибку ввода значения
        public static void Error()
        {
            Console.WriteLine($"Введено некорректное значение! Попробуйте еще раз!");
        }

        //показываем ошибку "Неуникальный ID"
        public static void ErrorUniqueId()
        {
            Console.WriteLine($"Данный ID уже занят, попробуйте еще раз!");
        }

        //Метод вывода сотрудников между дат роддения
        public static Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker[] getWorkersBetweenTwoDates = null;
            List<string> fileStrings = new List<string>(File.ReadAllLines(path));
            bool contains = false;

            for (int i = 0; i < fileStrings.Count; i++)
            {

                string line = fileStrings[i];
                DateTime date = DateTime.Parse(line.Split('\t')[5]);
                if (date >= dateFrom && date <= dateTo)
                {
                    Console.WriteLine(line);
                    contains = true;
                    break;
                }
            }
            if (!contains)
            {
                ContainsError();
            }
            return getWorkersBetweenTwoDates;
        }

        public static void ChangeWorker(int id)
        {
            List<string> fileStrings = new List<string>(File.ReadAllLines(path));
            bool contains = true;

            if (contains)
            {
                for (int i = 0; i < fileStrings.Count; i++)
                {

                    string line = fileStrings[i];
                    int index = Int32.Parse(line[0].ToString());
                   
                    if (index == id)
                    {
                        Console.Write($"Введите ФИО: ");
                        string fullName = Console.ReadLine();
                        Console.Write($"Введите возраст: ");
                        int age = Int32.Parse(Console.ReadLine());
                        Console.Write($"Введите рост: ");
                        string height = Console.ReadLine();
                        Console.Write($"Введите дату рождения: ");
                        string dateOfBirth = Console.ReadLine();
                        Console.Write($"Введите место рождения: ");
                        string placeOfBirth = Console.ReadLine();
                        Worker worker = new Worker
                        {
                            ID = id,
                            NowDateTime = DateTime.Now,
                            FullName = fullName,
                            Age = age,
                            Height = height,
                            DateOfBirth = dateOfBirth,
                            PlaceOfBirth = placeOfBirth
                        };
                        fileStrings.Remove(line);
                        line = worker.WorkerString();

                        fileStrings.Add(line);
                        Console.WriteLine($"Запись <{id}> успешно изменена на {line}!");
                        File.WriteAllLines(path, fileStrings, Encoding.Unicode);
                        contains = true;
                        break;
                    }
                   else
                    {
                        contains = false;
                    }
                }
                                
                if (!contains)
                {
                    ContainsError();
                }
            }



        }
        public static void ContainsError()
        {
            Console.WriteLine($"Указанный пользователь в файле отсутствует! Попробуйте еще раз!");
        }


    }
}
