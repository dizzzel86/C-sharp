using Newtonsoft.Json;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Diagnostics;
using DocumentFormat.OpenXml.Spreadsheet;

namespace HomeWork10
{
    public class User
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string PhoneNumber;
        public string PassportDetails;
        public DateTime DateOfChangeUser;

        private User(string surname, string name, string patronymic, string phoneNumber, string passportDetails, DateTime dateOfChangeUser)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.PassportDetails = passportDetails;
            this.DateOfChangeUser = dateOfChangeUser;
        }

        public User() { }



        string path = @"Client.json";

        public string Path()
        {
            return path;
        }

        //Получение сведений о пользователе из Файла
        public User GetUserInfo(User user)
        {

            User user1 = new User();
            user1 = JsonConvert.DeserializeObject<User>(File.ReadAllText(path));
            return user1;

        }

        //Запись сведений о пользователе
        public User SetUserInfo(User user)
        {

            User user1 = new User();
           
            user1.Surname = SetUserSurName();
            user1.Name = SetUserName();
            user1.Patronymic = SetUserPatronymic();
            user1.PhoneNumber = SetUserPhoneNumber();
            user1.PassportDetails = SetUserPassportDetails();
            user1.DateOfChangeUser = DateTime.Now;
           
            return user1;
        }

        //Получение информации о пользователе Менеджером
        public User GetManagerInfo(User user)
        {
            User user1 = new User();
            user1 = JsonConvert.DeserializeObject<User>(File.ReadAllText(path));
            return user1;

        }
        //Получение информации о пользователе Консультантом
        public User GetConsultantInfo(User user)
        {
            User user1 = new User();
            user1 = JsonConvert.DeserializeObject<User>(File.ReadAllText(path));

            return user1;

        }

        //Изменение Фамилии
        private string SetUserSurName()
        {

            var mainWindow = new MainWindow();
            string surName = mainWindow.GetChangeSurName();
            return surName;
        }

        //Изменение Имени
        private string SetUserName()
        {

            var mainWindow = new MainWindow();
            string name = mainWindow.GetChangeName();
            return name;
        }

        //Изменение Отчества
        private string SetUserPatronymic()
        {

            var mainWindow = new MainWindow();
            string patronymic = mainWindow.GetChangePatronymic();
            return patronymic;
        }

        //Изменение Номера телефона

        private string SetUserPhoneNumber()
        {
            var mainWindow = new MainWindow();
            string phoneNumber = mainWindow.GetChangePhoneNumber();
            return phoneNumber;
        }

        //Изменение Паспортных данных

        private string SetUserPassportDetails()
        {
            var mainWindow = new MainWindow();
            string passportDetails = mainWindow.GetChangePassportDetails();
            return passportDetails;
        }

        public void CompareUserInfo(User user1)
        {
            MainWindow mainWindow = new MainWindow();
            User user = new User();
            user = GetUserInfo(user);
            //Если поле "Фамилия" отличается от размещенной в файле и оно не пустое записываем лог
            if (user.Surname != user1.Surname && string.IsNullOrEmpty(user1.Surname))
            {
                mainWindow.ShowCompareUserNameInfo(user1.Surname);
            }
            //Если поле "Имя" отличается от размещенного в файле и оно не пустое записываем лог
            if (user.Name != user1.Name && string.IsNullOrEmpty(user1.Name))
            {
                mainWindow.ShowCompareUserNameInfo(user1.Name);             
            }
            //Если поле "Отчество" отличается от размещенного в файле и оно не пустое записываем лог
            if (user.Patronymic != user1.Patronymic && string.IsNullOrEmpty(user1.Patronymic))
            {
                mainWindow.ShowCompareUserPatronymicInfo(user1.Patronymic);
            }
            //Если поле "Номер телефона" отличается от размещенного в файле и оно не пустое записываем лог
            if (user.PhoneNumber != user1.PhoneNumber && string.IsNullOrEmpty(user1.PhoneNumber))
            {
                mainWindow.ShowCompareUserPhonenumberInfo(user1.PhoneNumber);
               
            }
            //Если поле "Паспорт" отличается от размещенного в файле и оно не пустое записываем лог
            if (user.PassportDetails != user1.PassportDetails && string.IsNullOrEmpty(user1.PassportDetails))
            {
                mainWindow.ShowCompareUserPatronymicInfo(user1.PassportDetails);
            }
            //Если ни одно из условий не выполнено возвращаем данные из файла
            else user1 = user;

        }

        




    }
}
