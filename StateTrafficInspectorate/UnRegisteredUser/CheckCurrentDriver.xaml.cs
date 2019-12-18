using Logic.LogicsModel;
using Logic.OtherLogic;
using Logic.ViewModels;
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

namespace StateTrafficInspectorate.UnRegisteredUser
{
    /// <summary>
    /// Логика взаимодействия для CheckCurrentDriver.xaml
    /// </summary>
    public partial class CheckCurrentDriver : Window
    {
        public CheckCurrentDriver()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CheckDriver checkDriver = new CheckDriver();
            checkDriver.Show();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DriverViewModel driver = DriverLogic.GetCurrentDriver();
                if (driver.Photo != null)
                {
                    borderImage.BorderBrush = Brushes.White;
                    ImageDriver.Source = ImageLogic.ImageFromByte(driver.Photo);
                }

                Name.Text = driver.Name;
                Phone.Text = driver.Telephone;
                Mail.Text = driver.Email;
                Passport.Text = driver.Passport;
                DateBirth.SelectedDate = driver.DateBirth;
                Address.Text = driver.FullAddress;
                AddressLife.Text = driver.AddressLife;
                PostCode.Text = driver.PostCode.ToString();
                Company.Text = driver.Company;
                JobName.Text = driver.JobName;
                Expirience.Text = driver.DrivingExperience.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
