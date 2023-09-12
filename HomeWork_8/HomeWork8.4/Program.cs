using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeWork8._4
{
    public class Human
    {
        public string FullName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string MobilePhone { get; set; }
        public string FlatPhone { get; set; }

    }

    internal class Program
    {



        static void Main(string[] args)
        {
            //Записная книжка XElement
            
            string path = @"list.xml";

            
            Console.WriteLine($"Записная книжка");
            XElement adressBook = new XElement("Adress_Book");
            XElement adress = new XElement("Adress");
            XElement fullName = new XElement("Full_Name");
            XElement street = new XElement("Street");
            XElement houseNumber = new XElement("House_Number");
            XElement flatNumber = new XElement("Flat_Number");
            XElement phones = new XElement("Phones");
            XElement mobilePhone = new XElement("Mobile_Phone");
            XElement flatPhone = new XElement("Flat_Phone");

            
                Console.Write($"Введите ФИО: ");
                fullName.Add(Console.ReadLine());
                Console.Write("Введите название улицы: ");
                street.Add(Console.ReadLine());
                Console.Write("Введите номер дома: ");
                houseNumber.Add(Console.ReadLine());
                Console.Write("Введте номер квартиры: ");
                flatNumber.Add(Console.ReadLine());
                Console.Write("Введите номер мобильного телефона: ");
                mobilePhone.Add(Console.ReadLine());
                Console.Write("Введите номер домашнего телефона: ");
                flatPhone.Add(Console.ReadLine());

                adress.Add(fullName, street, houseNumber, flatNumber);
                phones.Add(mobilePhone, flatPhone);

                adressBook.Add(adress, phones);

                adressBook.Save(path);

              

            Console.ReadKey();
        }
    }
}
