using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonTest
{
    class Person
    {
        public string Surname {  get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportDetails { get; set; }

        public Person() { }

        private Person (string surname, string name, string patronymic, string phoneNumber, string passportDetails)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.PassportDetails = passportDetails;
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine($"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}, Телефон: {PhoneNumber}, Паспорт: {PassportDetails}");
        }

    }
}
