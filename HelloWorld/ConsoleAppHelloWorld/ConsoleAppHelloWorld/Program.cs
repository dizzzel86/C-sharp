using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
/// <summary>
/// Главная составляющая единица приложения - класс
/// </summary>
	class Program
	{
	/// <summary>
	/// Код, который выполняется в первую очередь 
	/// </summary>
	/// <param name="args"> Параметры запуска</param>
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!"); //Вывод текста
											   //в консоль

			Console.ReadKey();                 //Ожидание от пользователя 
											   //нажатия какой-либо кнопки

	}
	}
}
