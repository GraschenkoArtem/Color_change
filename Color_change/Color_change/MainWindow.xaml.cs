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

namespace Color_change
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Reset_Button.Background = new SolidColorBrush(Color.FromRgb(R, G, B));
        }
        Byte R=0, G=0, B=0;

        private void Red_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            R = Convert.ToByte(Red_Slider.Value);
            Reset_Button.Background = new SolidColorBrush(Color.FromRgb(R, G, B));
            Red_Text.Text = Convert.ToString(Convert.ToUInt32(Red_Slider.Value));
            Red_Text1.Text = Convert.ToString(Red_Slider.Value);
        }

        private void Green_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G = Convert.ToByte(Green_Slider.Value);
            Reset_Button.Background = new SolidColorBrush(Color.FromRgb(R, G, B));
            Green_Text.Text = Convert.ToString(Convert.ToUInt32(Green_Slider.Value));
            Green_Text1.Text = Convert.ToString(Green_Slider.Value);
        }

        private void Blue_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B = Convert.ToByte(Blue_Slider.Value);
            Reset_Button.Background = new SolidColorBrush(Color.FromRgb(R, G, B));
            Blue_Text.Text = Convert.ToString(Convert.ToUInt32(Blue_Slider.Value));
            Blue_Text1.Text = Convert.ToString(Blue_Slider.Value);
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            R = 0;
            G = 0;
            B = 0;
            Red_Slider.Value = 0;
            Green_Slider.Value = 0;
            Blue_Slider.Value = 0;
            Reset_Button.Background = new SolidColorBrush(Color.FromRgb(R, G, B));
        }
    }
}
