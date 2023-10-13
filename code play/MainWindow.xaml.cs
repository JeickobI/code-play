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

namespace code_play
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

        private void play_Click(object sender, RoutedEventArgs e)
        {
            Play objSettings = new Play();
            this.Visibility = Visibility.Collapsed;
            objSettings.Show();

        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            Window1 objSettings = new Window1();
            this.Visibility = Visibility.Collapsed;
            objSettings.Show();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
