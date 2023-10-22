using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2013.Word;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DocumentFormat.OpenXml.Spreadsheet;

namespace HomeWork10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Установление доступа к полям ввода
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ///<summary>
            ///Если в чекбоксе выбран консультант
            ///</summary>

            if (myComboBox.SelectedIndex == 1)
            {
                Clear();
                Consultant consultant = new Consultant();
                changeSurname.IsEnabled = false;
                changeSurname.Text = consultant.AccessDenied();
                changeName.IsEnabled = false;
                changeName.Text = consultant.AccessDenied();
                changePatronymic.IsEnabled = false;
                changePatronymic.Text = consultant.AccessDenied();
                changePassportDetails.IsEnabled = false;
                changePassportDetails.Text = consultant.AccessDenied();
            }

            ///<summary>
            ///Если в чекбоксе выбран Манагер
            ///</summary>
            if (myComboBox.SelectedIndex == 0)
            {
                Clear();
                changeSurname.IsEnabled = true;
                changeSurname.Text = "";
                changeName.IsEnabled = true;
                changeName.Text = "";
                changePatronymic.IsEnabled = true;
                changePatronymic.Text = "";
                changePassportDetails.IsEnabled = true;
                changePassportDetails.Text = "";
            }
        }

        /// <summary>
        /// Изменение данных клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Если выбран Manager
            if (myComboBox.SelectedIndex == 0)
            {
                Clear();
                User user1 = new User();
                User user = new User();
                //Получение данных о пользователе из файла
                user = user.GetUserInfo(user);
                //создаем пользователя для сравнения
                string changeInfoLog = "";

                user1.Surname = GetChangeSurName();
                if (user1.Surname != user.Surname && !string.IsNullOrWhiteSpace(user1.Surname))
                {
                    changeInfoLog = ShowCompareUserSurnameInfo(user.Surname);

                }
                else
                    user1.Surname = user.Surname;

                user1.Name = GetChangeName();
                if (user1.Name != user.Name && !string.IsNullOrWhiteSpace(user1.Name))
                {
                    changeInfoLog += ShowCompareUserNameInfo(user.Name);

                }
                else
                    user1.Name = user.Name;

                user1.Patronymic = GetChangePatronymic();
                if (user1.Patronymic != user.Patronymic && !string.IsNullOrWhiteSpace(user1.Patronymic))
                {
                    changeInfoLog += ShowCompareUserPatronymicInfo(user.Patronymic);

                }
                else
                    user1.Patronymic = user.Patronymic;

                user1.PhoneNumber = GetChangePhoneNumber();
                if (user1.PhoneNumber != user.PhoneNumber && !string.IsNullOrWhiteSpace(user1.PhoneNumber))
                {
                    changeInfoLog += ShowCompareUserPhonenumberInfo(user.PhoneNumber);
                }
                else
                    user1.PhoneNumber = user.PhoneNumber;

                user1.PassportDetails = GetChangePassportDetails();
                if (user1.PassportDetails != user.PassportDetails && !string.IsNullOrWhiteSpace(user1.PassportDetails))
                {
                    changeInfoLog += ShowCompareUserPassportdetailsInfo(user.PassportDetails);
                }
                else
                    user1.PassportDetails = user.PassportDetails;

                changeLogWindow.ItemsSource = changeInfoLog.Split('\n');
                string userJson = JsonConvert.SerializeObject(user1);
                File.WriteAllText(user1.Path(), userJson);
                ClearChangeUserInfo();
            }

            //Если выбран Consultant
            if (myComboBox.SelectedIndex == 1)
            {
                //Очищаем поля
                Clear();
                User user = new User();
                Consultant consultant = new Consultant();
                
                string changeInfoLog = "";
                user = user.GetConsultantInfo(user);
                User user1 = new User();

                string value = GetChangePhoneNumber();
                //Проверяем введено ли значение
                if (!String.IsNullOrWhiteSpace(value))
                {
                    //Если введено - записываем значение в телефонный номер
                    user1.PhoneNumber = user.PhoneNumber;
                    user.PhoneNumber = value;
                    //Добавляем дату изменения
                    user.DateOfChangeUser = DateTime.Now;
                   // user1.CompareUserInfo(user);
                    string userJson = JsonConvert.SerializeObject(user);
                    File.WriteAllText(user.Path(), userJson);
                    MessageBox.Show("Номер телефона успешно изменен!");
                    changeInfoLog += ShowCompareUserPhonenumberInfo(user1.PhoneNumber);
                    changeLogWindow.ItemsSource = changeInfoLog.Split('\n');

                }

                else consultant.ErrorPhone();
               

            }
            if (myComboBox.SelectedIndex != 1 && myComboBox.SelectedIndex != 0)
            {
                 MessageBox.Show("Должность не выбрана!");
            }


        }



        /// <summary>
        /// Кнопка просмотра данных клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Если выбран manager
            if (myComboBox.SelectedIndex == 0)
            {
                Clear();
                var user = new User();
                user = user.GetManagerInfo(user);

                viewPassportDetails.Items.Add(user.PassportDetails);
                viewName.Items.Add(user.Name);
                viewPatronymic.Items.Add(user.Patronymic);
                viewSurname.Items.Add(user.Surname);
                viewPhoneNumber.Items.Add(user.PhoneNumber);
            }

            //Если выбран Consultant

            if (myComboBox.SelectedIndex == 1)
            {
                Clear();
                var user = new User();
                user = user.GetConsultantInfo(user);
                if (user.PassportDetails != String.Empty)
                {
                    viewPassportDetails.Items.Add("**** ******");
                }
                else viewPassportDetails.Items.Add("Данных нет");
                viewName.Items.Add(user.Name);
                viewPatronymic.Items.Add(user.Patronymic);
                viewSurname.Items.Add(user.Surname);
                viewPhoneNumber.Items.Add(user.PhoneNumber);
               

            }
            if (myComboBox.SelectedIndex != 1 && myComboBox.SelectedIndex != 0)
            {
                MessageBox.Show("Должность не выбрана!");
            }

        }

        //Очистка полей просмотра данных о клиенте
        public void Clear()
        {
            viewPassportDetails.Items.Clear();
            viewName.Items.Clear();
            viewPatronymic.Items.Clear();
            viewSurname.Items.Clear();
            viewPhoneNumber.Items.Clear();

        }

        //Очистка полей изменения данных клиента
        public void ClearChangeUserInfo()
        {
            changeSurname.Clear();
            changeName.Clear();
            changePatronymic.Clear();
            changePhoneNumber.Clear();
            changePatronymic.Clear();
        }



        public string GetChangeSurName()
        {
            string getChangeSurName = changeSurname.Text.ToString();
            if (string.IsNullOrWhiteSpace(getChangeSurName))
            {
                MessageBox.Show("В поле <Фамилия> не введено значение!");
            }
            return getChangeSurName;
        }

        public string GetChangeName()
        {
            string getChangeName = changeName.Text;
            if (string.IsNullOrWhiteSpace(getChangeName))
            {
                MessageBox.Show("В поле <Имя> не введено значение!");
            }
            return getChangeName;
        }

        public string GetChangePatronymic()
        {
            string getChangePatronymic = changePatronymic.Text;
            if (string.IsNullOrWhiteSpace(getChangePatronymic))
            {
                MessageBox.Show("В поле <Отчество> не введено значение!");
            }
            return getChangePatronymic;
        }


        public string GetChangePhoneNumber()
        {
            User user = new User();
            User user1 = user.GetUserInfo(user);

            string getChangePhoneNumber = null;
            if (!string.IsNullOrWhiteSpace(changePhoneNumber.Text))
            {
                getChangePhoneNumber = changePhoneNumber.Text;
                
            }
            if (string.IsNullOrWhiteSpace (getChangePhoneNumber))
            {
                MessageBox.Show("В поле <Телефон> не введено значение!");
            }
            return getChangePhoneNumber;

        }
        public string GetChangePassportDetails()
        {
            string getChangePassportDetails = changePassportDetails.Text;
            if (string.IsNullOrWhiteSpace(getChangePassportDetails))
            {
                MessageBox.Show("В поле <Паспорт> не введено значение!");
            }
            return getChangePassportDetails;
        }

        public string ShowCompareUserSurnameInfo(string userInfo)
        {
            string changeUserInfo = $"Фамилия изменена!\n" +
            $"Фамилия до изменения: {userInfo}\n" +
                    $"Время изменения записи: {DateTime.Now}\n" +
                    $"Изменение произвел Manager\n";
            return changeUserInfo;
        }
        public string ShowCompareUserNameInfo(string userInfo)
        {
            string changeUserInfo = $"Имя изменено!\n" +
            $"Имя до изменения: {userInfo}\n" +
                    $"Время изменения записи: {DateTime.Now}\n" +
                    $"Изменение произвел Manager\n";
            return changeUserInfo;
        }
        public string ShowCompareUserPatronymicInfo(string userInfo)
        {
            string changeUserInfo = $"Отчество изменено!\n" +
            $"Отчество до изменения: {userInfo}\n" +
                    $"Время изменения записи: {DateTime.Now}\n" +
                    $"Изменение произвел Manager\n";
            return changeUserInfo;
        }
        public string ShowCompareUserPhonenumberInfo(string userInfo)
        {
            string changeUserInfo = null;
            if (myComboBox.SelectedIndex == 0)
            {

                changeUserInfo = $"Номер телефона изменен!\n" +
                $"Номер телефона до изменения: {userInfo}\n" +
                        $"Время изменения записи: {DateTime.Now}\n" +
                        $"Изменение произвел Manager\n";
            }

            if (myComboBox.SelectedIndex == 1)
            {

                changeUserInfo = $"Номер телефона изменен!\n" +
                 $"Номер телефона до изменения: {userInfo}\n" +
                         $"Время изменения записи: {DateTime.Now}\n" +
                         $"Изменение произвел Consultant\n";
            }
            return changeUserInfo;

        }
        public string ShowCompareUserPassportdetailsInfo(string userInfo)
        {
            string changeUserInfo = $"Паспортные данные изменены!\n" +
                $"Паспортные данные до изменения: {userInfo}\n" +
                        $"Время изменения записи: {DateTime.Now}\n" +
                        $"Изменение произвел Manager\n";

            return changeUserInfo;
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




    }

}



