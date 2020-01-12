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
using Logic.Models;
using Logic.LogicsModel;

namespace StateTrafficInspectorate.Setting
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                UserModel admin = new UserModel();
                admin.Login = Login.Text;
                admin.Password = Password.Password;

                AdminLogic.AuthorizationAdmin(admin);
                MessageBox.Show("Авторизация прошла успешно!");

                AdminMainWindow adminMain = new AdminMainWindow();
                adminMain.Show();
                this.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
