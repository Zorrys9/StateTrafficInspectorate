using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
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
using IdentityModel.Client;
using Microsoft.Win32;
using StateTrafficInspectorate.Inspector;
using StateTrafficInspectorate.UnRegisteredUser;

namespace StateTrafficInspectorate
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


        private void InspectorGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AuthorizationInspector inspector = new AuthorizationInspector();
                inspector.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckDriver_Click(object sender, RoutedEventArgs e)
        {
            CheckDriver driver = new CheckDriver();
            driver.Show();
            this.Close();
        }

        private void CheckFin_Click(object sender, RoutedEventArgs e)
        {
            CheckFine Fine = new CheckFine();
            Fine.Show();
            this.Close();
        }

        private void CheckLicenseDriver_Click(object sender, RoutedEventArgs e)
        {
            CheckLicenseDriver License = new CheckLicenseDriver();
            License.Show();
            this.Close();
        }

        private void CheckTransport_Click(object sender, RoutedEventArgs e)
        {
            CheckTransport Transport = new CheckTransport();
            Transport.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Setting.Authorization authorization = new Setting.Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
