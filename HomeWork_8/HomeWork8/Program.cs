using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем LIST
            List<int> list = new List<int>();
            //Random
            Random random = new Random();
            //Заполняем LIST рандомом
            for (int i = 0; i < 100; i++) 
            { 
                list.Add(random.Next(0,101));
            }
            
            //выводим числа от 25 до 50
            for(int y = 0; y < list.Count; y++)
            {
                if (list[y] > 25 && list[y] < 50)
                Console.WriteLine(list[y]);
                
            }
            Console.WriteLine($"Всего чисел в листе: {list.Count}"); 

            Console.ReadLine();
            
        }
    }
}
