using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    struct Worker
    {
        public int ID { get; set; }
        public DateTime NowDateTime { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        //public Worker(int id, DateTime dateTime, string fullName, int age, string height, string dateOfBirth, string placeOfBirth)
        //{
        //    this.ID = id;
        //    this.DateTime = dateTime;
        //    this.FullName = fullName;
        //    this.Age = age;
        //    this.Height = height;
        //    this.DateOfBirth = dateOfBirth;
        //    this.PlaceOfBirth = placeOfBirth;
        //}



        public static string[] SplitString(string inputText)
        {
            string userInput = inputText;
            string[] splitUserInput = userInput.Split('\t');


            for (int i = 0; i < splitUserInput.Length; i++)
            {
                string[] str = splitUserInput;


            }
            return splitUserInput;

        }

        public static string[] PrintString(string inputText)
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

        public static string Print(string inputText)
        {
            string print = inputText;
            using (StreamReader sr = new StreamReader(Repo.path, Encoding.Unicode))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Worker.SplitString($"{line}");
                    Worker.PrintString(line);
                    Console.WriteLine();
                }
            }

            return print;

            //    {ID,15} {DateTime,15} {FullName,15} {Age,15} " +
            //$"{Height,15} {DateOfBirth,15} {PlaceOfBirth,15}";
        }


        public static string Extract(string input, int index)
        {
            if (string.IsNullOrEmpty(input) || input.Length < index)
            {
                return input;
            };

            return input.Substring(0, index);
        }

        public string  WorkerString()
        {

            string workerString =  $"{ID}\t{NowDateTime}\t{FullName}\t{Age}\t{Height}\t{DateOfBirth}\t{PlaceOfBirth}\t"; 
            return  workerString;
        }

    }
}
