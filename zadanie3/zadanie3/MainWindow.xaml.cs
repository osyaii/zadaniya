using System;
using System.Collections.Generic;
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

namespace zadanie3
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



        private void wrongName(object sender, RoutedEventArgs e)
        {

            string messageBoxText = "Введите имя используя нижние латинские символы";
            string caption = "Неправильное имя";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        private void fineName(object sender, RoutedEventArgs e)
        {

            string messageBoxText = "Правильное имя";
            string caption = "Правильное имя";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Input = nameField.Text;
            if (validInput(Input) == true)
            {
                fineName(sender, e);
            }
            else 
            {
                wrongName(sender, e);
            }
        }



        private bool validInput(string input) 
        {
            return !string.IsNullOrEmpty(input) && (System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-z]+"));
        }
    }
}
