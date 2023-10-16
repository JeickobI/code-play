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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace code_play
{
    public partial class Play : Window
    {
        public Play()
        {
            InitializeComponent();
        }

        private void vihod1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void lideri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лидеры: \n");
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            string directoty = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = System.IO.Path.GetDirectoryName(directoty);
            string currentPath = $"{path}\\Database1.mdf";

            if (playgame.Text.Length != 0 && parol.Text.Length != 0 && ID.Text.Length != 0)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + currentPath + ";Integrated Security=True";
                string sqlExpression = $"insert into polz values ('{Convert.ToInt32(ID.Text)}','{playgame.Text}','{parol.Text}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            object log = reader.GetValue(0);
                            object pas = reader.GetValue(1);
                            object id = reader.GetValue(2);
                        }
                    }
                    reader.Close();
                }
            }
        }

        private void play1_Click(object sender, RoutedEventArgs e)
        {
            Game objSettings = new Game();
            this.Visibility = Visibility.Collapsed;
            objSettings.Show();
        }

        private void nazad1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objSettings = new MainWindow();
            this.Visibility = Visibility.Collapsed;
            objSettings.Show();
        }
    }
}