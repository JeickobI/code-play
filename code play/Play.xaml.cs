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

namespace code_play
{
    /// <summary>
    /// Логика взаимодействия для Play.xaml
    /// </summary>
    /// 
    class Programm
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["regBD"].ConnectionString;

        private static SqlConnection sqlConnection = null;

        static void Main(string[] args, SqlConnection sqlConnection)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command.ToLower().Equals("Выход"))
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }

                    if (sqlDataReader != null)
                    {
                        sqlDataReader.Close();
                    }

                    break;
                }               
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
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

        }
    }
}