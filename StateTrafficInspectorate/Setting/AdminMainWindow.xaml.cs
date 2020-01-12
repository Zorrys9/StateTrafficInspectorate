using Logic.LogicsModel;
using Microsoft.Data.ConnectionUI;
using System;
using System.Configuration;
using System.Windows;

namespace StateTrafficInspectorate.Setting
{
    /// <summary>
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void ChangeLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminLogic.ChangeLoginAdmin(CurrentLogin.Text, NewLogin.Text);
                MessageBox.Show("Логин успешно изменен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AdminLogic.ChangePasswordAdmin(CurrentPassword.Password, NewPassword.Password);
                MessageBox.Show("Пароль успешно изменен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void DataBaseChange_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MessageBoxResult resultDialog = MessageBox.Show("После изменения параметров БД приложение будет перезапущено, Вы уверены, что хотите продолжить?", "Подтверждение действий", MessageBoxButton.YesNo);
                if(resultDialog == MessageBoxResult.Yes)
                {


                    DataConnectionDialog dcd = new DataConnectionDialog();
                    DataSource.AddStandardDataSources(dcd);
                    dcd.SelectedDataSource = DataSource.SqlDataSource;
                    dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
                    DataConnectionDialog.Show(dcd);
                    Logic.OtherLogic.ChangeDataBaseLogic.Change(dcd.ConnectionString);



                    Application.Current.Shutdown();
                    System.Windows.Forms.Application.Restart();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            DataBaseInfo.Text = connectionStringsSection.ConnectionStrings["GIBDD"].ConnectionString;
        }
    }
}
