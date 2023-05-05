using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Программа подсчета суммы карт в игре "21"
            Console.WriteLine("\nПрограмма подсчета суммы карт в игре 21");
            Console.WriteLine("\nОбозначение карт: \nВалет = J\nДама = Q\nКороль = K\nТуз - T");

            Console.WriteLine("\n Введите количество карт:");
            int numberOfCards = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.WriteLine("\nВведите номинал карты:");
                string cardsValue = Console.ReadLine();

                switch (cardsValue)
                {
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 11;
                        break;
                    default:
                        Console.WriteLine($"Ведите корректный номинал карт 2-10, J, Q, K, T");
                        break;

                }
            }

            if (sum < 21)
            {
                Console.WriteLine($"Сумма карт на руках: " + sum);


            }
            else if (sum == 21)
            {
                Console.WriteLine($"Поздравляем! Сумма карт на руках: " + sum);
            }
            else
            {
                Console.WriteLine($"Перебор! Сумма карт на руках: " + sum);
            }
            Console.ReadLine();
            
        }
    }
}
