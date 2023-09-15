using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace HomeWork9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string userInput;



        public MainWindow()
        {
            InitializeComponent();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {




        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)


        {

            var textBox = sender as TextBox;


        }

        private void splitButton_Click(object sender, RoutedEventArgs e)
        {

            splitResult.ItemsSource = splitInput.Text.Split(' ');
            
        }

        private void invertButton_Click(object sender, RoutedEventArgs e)
        {
            string words = invertInput.Text;
            string invertWord = Repo.InvertString(words);
            invertResult.Content = invertWord;
        }
    }
}
