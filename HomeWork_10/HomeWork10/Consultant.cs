using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Xml;

namespace HomeWork10
{

    public class Consultant : User
    {

        public string UserSurname;
        public string UserName;
        public string UserPatronymic;
        public string UserPhoneNumber;
        public string UserPassportDetails;

        private Consultant(string surname, string name, string patronymic, string phoneNumber, string passportDetails)
        {

            this.UserSurname = surname;
            this.UserName = name;
            this.UserPatronymic = patronymic;
            this.UserPhoneNumber = phoneNumber;
            this.UserPassportDetails = passportDetails;
        }

        public Consultant() { }
        public void GetSurName()
        {

            User user = this;
            user.GetConsultantInfo(user);


        }
        public string GetName()
        {
            return UserName;
        }
        public string GetPatronymic()
        {
            return UserPatronymic;
        }

        public string GetPhoneNumber()
        {
            return UserPhoneNumber;
        }
        public string GetPassportDetails()
        {
            User user = this;
            user.GetConsultantInfo(user);
            return UserPassportDetails;
        }


        public string ChangePhone(string phone)
        {
            MainWindow window = new MainWindow();
            if (phone == string.Empty)
            {
                ErrorPhone();
            }
            else
            {
                PhoneNumber = phone;
            }

            return PhoneNumber;
        }

        //Сообщение если при изменении номера телефона не введено ничего
        public void ErrorPhone()
        {
            MessageBox.Show("Введите корректный номер телефона!!!");
        }

        public string AccessDenied()
        {
            string accessMessage = "Недостаточно прав!";
            return accessMessage;
        }



    }
}
