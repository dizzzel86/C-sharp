using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWrite_WriteLine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Hello, ");			//Метод вывода текста в одну строку
			Console.Write("World");
			Console.Write("!!!");

			Console.ReadKey();
			
			//Вывод текста
			//Каждый метод выводит текст с новой строки
			Console.WriteLine();				 //Без добавления этой строки идет вывод без следующей строки
			Console.WriteLine("Hello, ");		 //Так и должно быть?
			Console.WriteLine("World");
			Console.WriteLine("!!!");

			Console.ReadKey();


		}
	}
}
