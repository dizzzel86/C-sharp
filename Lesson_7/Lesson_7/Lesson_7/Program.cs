using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_7
{
    /// <summary>
    /// Структура, описывающая данные по месяцам
    /// </summary>
    struct MonthlyReport
    {
        /// <summary>
        /// Название месяца
        /// </summary>
        public string Month;

        /// <summary>
        /// Доход
        /// </summary>
        public int Income;

        /// <summary>
        /// Расход
        /// </summary>
        public int consumption;

        /// <summary>
        /// Прибыль
        /// </summary>
        public int arrived;


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Lesson 7.1
            ///
            //int[] income = new int[12];
            //int[] consumption = new int[12];
            //int[] arrived = new int[12];

            //MonthlyReport january = new MonthlyReport();

            //january.Month = "Январь";
            //january.Income = 10_000;
            //january.consumption = 3_000;
            //january.arrived = january.Income - january.consumption;

            ////Январь доход: 10000, расход: 3000, прибыль: 7000
            //Console.WriteLine("{0}: Доход: {1} Расход: {2} Прибыль: {3}",
            //    january.Month,
            //    january.Income,
            //    january.consumption,
            //    january.arrived);

            //Console.ReadKey();

            //Worker worker = new Worker();

            //worker.Position = "Admin";
            //worker.FirstName = "Ivan";
            //worker.LastName = "Ivanov";
            //worker.Salary = 100_000;
            //worker.DateOfBirth = new DateTime(1980, 1, 2);
            //Console.WriteLine("Должность: {0}: Имя: {1} Фамилия: {2} ЗП: {3} Дата рождения: {4}",
            //    worker.Position,
            //    worker.FirstName,
            //    worker.LastName,
            //    worker.Salary,
            //    worker.DateOfBirth);

            //Console.ReadKey();

            ///<summary>
            ///Lesson 7.3.
            /// </summary>


            //Worker w = new Worker("Прогер", 1111, "Иван", "Иванов", new DateTime(1980, 1, 2));

            //w = new Worker("Иван IV");
            //Console.WriteLine(w.Print());

            //Console.ReadKey();

            //Account1 account1 = new Account1("Admin", "qwerty");
            //Console.WriteLine(account1.Password);
            //Console.ReadKey();

            //Account2 account2 = new Account2("Admin", "qwerty");
            ////Console.WriteLine(account2.Password);
            //account2.SetPassword("password");
            //Console.ReadKey();

            //Cat4 cat4 = new Cat4();
            //cat4.Name = "Bars";
            //cat4.EyeColor = "Green";
            //cat4.EyeColor = "Blue";

            ///<summary>
            ///Lesson 7.5.
            /// </summary>
            /// 

            //Repo db1 = new Repo(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5")
            //    );

            //Console.WriteLine(db1.Workers[0].Print);


            //Repo2 db2 = new Repo2(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5")
            //    );

            //Console.WriteLine(db2[0].Print);
            //Console.ReadKey();

            //Repo3 db3 = new Repo3(
            //    new Worker("Должность_1", 10000, "Имя_1"),
            //    new Worker("Должность_2", 10000, "Имя_2"),
            //    new Worker("Должность_3", 10000, "Имя_3"),
            //    new Worker("Должность_4", 10000, "Имя_4"),
            //    new Worker("Должность_5", 10000, "Имя_5")
            //    );

            //Console.WriteLine(db3[0]);
            //Console.ReadKey();

            Repo4 db4 = new Repo4(
               new Worker("Должность_1", 10000, "Имя_11111"),
               new Worker("Должность_2", 10000, "Имя_2"),
               new Worker("Должность_3", 10000, "Имя_3"),
               new Worker("Должность_4", 10000, "Имя_4"),
               new Worker("Должность_5", 10000, "Имя_5")
               );

            Console.WriteLine(db4[0]);


            Console.WriteLine(db4["+"]);
            Console.ReadKey();
        }
    }
}
