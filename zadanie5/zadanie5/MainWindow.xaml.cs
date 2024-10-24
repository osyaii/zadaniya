using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
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

namespace zadanie5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            slidw.Minimum = 100;
            slidw.Maximum = 1500;
            
        }

        private void butt_Click(object sender, RoutedEventArgs e)
        {

            

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                string fileName = openFileDialog1.FileName;

                pic.Source = new BitmapImage(new Uri(fileName));
                
            }
            
        }

     
        private void Slider_width(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            pic.Width = slidw.Value;
        }
    }
}
