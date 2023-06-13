using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms; // 5.2 13:00 - неверная инфа

namespace Lesson_5._2
{
    internal class Program
    {
        //1я группа методов
        //ничего не принимает, ничего не возвращает, но что-то делает
        //static void Pause()
        //{
        //    Console.ReadKey();
        //}

        ////Вывод на экран простого текста

        //static void Hi()
        //{
        //    Console.WriteLine("Привет!");
        //}

        ////Беспорядок в консоли

        //static void ApplauseAndOvations()
        //{
        //    Random rand = new Random();
        //    for (int i = 0; i < rand.Next(30,50); i++)
        //    {
        //        int posX = rand.Next(Console.WindowWidth-5);
        //        int posY = rand.Next(Console.WindowHeight - 1);
        //        Console.SetCursorPosition(posX, posY + 1);
        //        Console.Write(rand.Next(2) == 0 ? "Ура!" : "Ууу!") ;
        //    }
        //}

        //2я группа методов!
        //Принимает аргумент, выполняет действие
        //static void Pause(int Interval)
        //{
        //    //Интервал задержки в милисекундах
        //    Thread.Sleep(Interval * 1000);
        //}

        ////Вывод приветствия на экране

        //static void Hi(string Name)
        //{
        //    Random rand = new Random();

        //    string textHi = string.Empty;

        //    switch (rand.Next(5))
        //    {
        //        case 0: textHi = $"Привет, {Name}!"; break;
        //        case 1: textHi = $"Добрый день, {Name}!"; break;
        //        case 2: textHi = $"Приветствую тебя, {Name}!"; break;
        //        case 3: textHi = $"Рад тебя видеть, {Name}!"; break;
        //        default: textHi = $"Я ждал тебя, {Name}!"; break;

        //    }

        //    Console.WriteLine(textHi);
        //}

        //static void ApplauseAndOvations(string Text1, string Text2, int Count)
        //{
        //    Random rand = new Random();
        //    int max  = new int[] {Text1.Length, Text2.Length}.Max();

        //    for (int i = 0; i < Count; i++)
        //    {
        //        int posX = rand.Next(Console.WindowWidth - max);  //получение ширины консоли
        //        int posY = rand.Next(Console.WindowHeight);       //получение высоты коноли  
        //        Console.SetCursorPosition(posX, posY + 1);        //Установка курсора в случайную позицию на экране
        //        Console.Write(rand.Next(2) == 0 ? Text1 : Text2);//Вывод одного из радостных сообщений
        //    }
        //}

        //3я группа методов
        //выполняет действие
        //выводит результат работы

        //генерация строки из набора случайных символов
        //static string GetRandomString()
        //{
        //    return Guid.NewGuid().ToString();

        //    //2й вариант

        //    var result = Guid.NewGuid().ToString();
        //    return result;
        //}

        ////Возврат случайного приветствия

        //static string GetRandomHi() 
        //{
        //    Random rnd = new Random();

        //    string text = string.Empty;

        //    switch (rnd.Next(5))
        //    {
        //        case 0: text= $"Привет!"; break;
        //        case 1: text= $"Добрый день!"; break;
        //        case 2: text= $"Ку!"; break;
        //        case 3: text= $"Шалом!"; break;
        //        default: text= $"Салам!"; break;

        //    }
        //    return text;
        //Возврат полного пути к текущему приложению

        //static string GetPath()
        //{
        //    return Application.ExecutablePath;
        //}

        //4я группа методов
        //принимает аргументы > выполняет действие > выдает результат работы

        //генерация строки из строки случайных символов
        //private static string GetRandomString(int Count)
        //{
        //    return Guid.NewGuid().ToString().Substring(0, Count);
        //}

        ////Возврат полного пути к текущему приложению
        //private static string GetPath(bool FileName)
        //{
        //    return FileName ? Application.ExecutablePath : Application.StartupPath; // 17:00 не работает
        //}

        ////возврат максимума из 2х чисел
        //private static int Max(int Value1, int Value2)
        //{
        //    return Value1 > Value2 ? Value1 : Value2;
        //}

        ////массив чисел > возврат противоположных чисел

        //private static int[] Inverse(int[] Args)
        //{
        //    int[] t = new int[Args.Length];

        //    for (int i = 0; i < Args.Length; i++)
        //    {
        //        t[i] = -Args[i];
        //    }
        //    return t;
        //}

    }

     static void Main(string[] args)
    {
        //1й метод визуал
        //Hi();
        //ApplauseAndOvations();
        //Pause();


        //2й метод визуал

        //Hi("Илон"); // Вызов метода Hi
        //Hi("Балбес!!!");
        ////ApplauseAndOvations("Огого!", "Ёёёёёуууу!", 30); //Вызов метода ApplauseAndOvations
        //Pause(2);

        ////3й метод визуал

        //string res = GetRandomString(); Console.WriteLine(res);
        //res = GetRandomHi(); Console.WriteLine( res);
        ////res = GetPath(); Console.WriteLine(res);

        //Console.ReadKey();

        ///4й метод визуал
        ///

        //Console.WriteLine(GetRandomString(5));
        //Console.WriteLine(GetRandomString(10));
        //Console.WriteLine(GetRandomString(15));


        //Console.WriteLine(GetPath(true));
        //Console.WriteLine(GetPath(false));
        //Console.WriteLine();

        //int[] col = { 1, 3, 5, 7, 9 };

        //foreach (var e in col) Console.Write($"{e} ");
        //Console.WriteLine();
        //int[] inverseCol = Inverse(col);
        //foreach (var e in inverseCol) Console.WriteLine($"{e} ");



    }
}

