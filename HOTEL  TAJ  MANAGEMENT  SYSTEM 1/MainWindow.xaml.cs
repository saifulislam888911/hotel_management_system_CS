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
using MySql.Data.MySqlClient;



namespace HOTEL__TAJ__MANAGEMENT__SYSTEM_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, RoutedEventArgs e)
        {
            DBConnection();

            MessageBox.Show(" Authority Permission to Use Only ");

            this.Hide();
            EMPLOYEE window = new EMPLOYEE();
            window.Show();

        }

        private void DBConnection()
        {
            string ConnectString = "datasource = localhost; port = 3306 ; username = root ; password= ; database = 'hotel' ";

            MySqlConnection DBConnect = new MySqlConnection(ConnectString);

            try
            {
                DBConnect.Open();
                MessageBox.Show(" Okay, you are connected ");

            }

            catch( Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
    }
}
