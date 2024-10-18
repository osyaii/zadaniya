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

namespace lata
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

        private void backColor_Click(object sender, RoutedEventArgs e)
        {
            griid.Background = Brushes.AliceBlue;
           
        }

        private void devInfo_Click(object sender, RoutedEventArgs e)
        {
            
            string messageBoxText = "Разработчик - Злата Игоревна";
            string caption = "Информация о разработчике";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

        private void backColor_MouseEnter(object sender, MouseEventArgs e)
        {
            statusLeft.Text = "Поменять цвет";
        }

        private void devInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            statusLeft.Text = "Информация о разработчике";
        }
    }

}
