using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    internal class Program
    {



        static void Main(string[] args)


        {
            //Заголовок
            Console.WriteLine($"Справочник <<СОТРУДНИКИ>>");


            //Информация об опциях
            Console.WriteLine($"Введите <1> для ввода данных\nВведите <2> для просмотра справочника\n" +
                $"Введите <3> для просмотра сведений о конкретной записи\nВведите <4> для удаления конкретной записи" +
                $"\nВведите <5> для вывода списка сотрудников с определенным интервалом дат рождения\n" +
                $"Введите <6> для изменения конкретного сотрудника");
            //Приглашение ко вводу
            Console.Write("Сделайте выбор:");

            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {

                var worker = new Worker();
                Repo.AddWorker(worker);


            }
            else if (userChoice == "2")
            {

                if (!File.Exists(Repo.path))
                {
                    Console.WriteLine("ФАЙЛ СПРАВОЧНИКА ОТСУТСТВУЕТ!!!\nПопробуйте еще раз!\n" +
                        "При повтороном вызове программы выберите <1> для ввода данных!");

                }

                else
                {
                    Repo.GetAllWorkers(); ;
                }
            }
            else if (userChoice == "3")
            {
                Console.Write($"Введите ID записи, которую хотите просмотреть: ");

                string line = Console.ReadLine();


                bool isNumber = int.TryParse(line, out int userNumber);
                if (line == string.Empty)
                {
                    Repo.Error();
                }

                if (isNumber)
                {
                    Repo.GetWorkerById(int.Parse(line));
                }

                else
                {
                    Console.WriteLine($"Введите числовое значение!!!");
                }

            }

            else if (userChoice == "4")
            {

                Console.Write($"Введите номер записи, которую ходите удалить:");

                string line = Console.ReadLine();
                bool isNumber = int.TryParse(line, out int userNumber);



                if (line == string.Empty)
                {
                    Repo.Error();
                }

                if (isNumber)
                {
                    int userInput = Int32.Parse(line);
                    Repo.DeleteWorker(userInput);
                }
                else
                {
                    Console.WriteLine($"Введите числовое значение!!!");
                }

            }

            else if (userChoice == "5")
            {
                Console.Write($"Введите начальную дату рождения в формате dd.mm.yyyy: ");
                string marker1 = Console.ReadLine();

                Console.Write($"Введите конечную дату рождения в формате dd.mm.yyyy: ");
                string marker2 = Console.ReadLine();

                if (string.IsNullOrEmpty(marker2) || string.IsNullOrEmpty(marker2))
                {
                    Repo.Error();

                }
                else if (!string.IsNullOrEmpty(marker1) && !string.IsNullOrEmpty(marker2))

                {
                    DateTime startDateOfBirth = DateTime.Parse(marker1);
                    DateTime endDateOfBirth = DateTime.Parse(marker2);
                    Repo.GetWorkersBetweenTwoDates(startDateOfBirth, endDateOfBirth);
                }


            }

            else if (userChoice == "6")
            {
                Console.Write($"Введите номер записи, которую ходите изменить:");

                string line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    

                    bool isNumber = int.TryParse(line, out int userNumber);
                    if (line == string.Empty)
                    {
                        Repo.Error();
                    }

                    if (isNumber)
                    {
                        int userInput = Int32.Parse(line.ToString());
                        Repo.ChangeWorker(userInput);
                    }
                    else
                    {
                        Console.WriteLine($"Введите числовое значение!!!");
                    }
                }
                else
                {
                    Console.WriteLine($"Введите значение!!!");
                }

            }
            Console.ReadKey();
        }

    }
}