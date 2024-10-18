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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            inkcanvas.DefaultDrawingAttributes.Color = Colors.Black;
            inkcanvas.DefaultDrawingAttributes.Height = 1;
            inkcanvas.DefaultDrawingAttributes.Width = 1;

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

        private void blackkey_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void redkey_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void bluekey_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void greenkey_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;

            inkcanvas.DefaultDrawingAttributes.Width = slider.Value;
            inkcanvas.DefaultDrawingAttributes.Height = slider.Value;
        }
        void eraseByPointEditingMode_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void eraserButton_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ink_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }

}
