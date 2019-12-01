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
using Logic.LogicsModel;
using Logic.ViewModels;
using Logic.Models;
using Logic.OtherLogic;
using Microsoft.Win32;
using System.IO;
using Logic;

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для CurrentDriver.xaml
    /// </summary>
    public partial class CurrentDriver : Window
    {
        public CurrentDriver()
        {
            InitializeComponent();
        }

        public DriverModel Currentdriver = new DriverModel();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DriverList driver = new DriverList();
            driver.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                PhotoURL.Text = "";
                DriverViewModel driver = DriverLogic.GetCurrentDriver();
                Currentdriver.Photo = driver.Photo;
                if(driver.Photo != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult message = MessageBox.Show("Вы уверены, что хотите удалить данного пользователя?", "Удаление водителя", MessageBoxButton.YesNo);
                if(message == MessageBoxResult.Yes)
                {
                    DriverLogic.DeleteDriver();
                    MessageBox.Show("Водитель успешно удален!");
                    DriverList driverList = new DriverList();
                    driverList.Show();
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeDriver_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Name.Text.Where(nam => nam == ' ').Count() == 2)
                {
                    string[] NameArray = new string[2];
                    NameArray = Name.Text.Split(' ');

                    DriverModel driver = new DriverModel
                    {
                        FirstName = NameArray[0],
                        LastName = NameArray[1],
                        Patronymic = NameArray[2],
                        Telephone = Phone.Text,
                        Email = Mail.Text,
                        SerialPasp = Passport.Text.Substring(0, 4),
                        NumberPasp = Passport.Text.Substring(4, 6),
                        DateBirth = DateBirth.SelectedDate.Value,
                        DrivingExperience = int.Parse(Expirience.Text),
                        FullAddressLife = AddressLife.Text,
                        FullAddress = Address.Text,
                        PostCode = int.Parse(PostCode.Text),
                        Company = Company.Text,
                        JobName = JobName.Text,
                    };
                    if (PhotoURL.Text != "")
                        driver.Photo = File.ReadAllBytes(PhotoURL.Text);
                    else driver.Photo = Currentdriver.Photo;
                    DriverLogic.ChangeDriver(driver);

                    MessageBox.Show("Водитель успешно изменен!");

                    DriverList driverList = new DriverList();
                    driverList.Show();
                    this.Close();
                }
                else throw new Exception("ФИО введен не верно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            ChangeStatus status = new ChangeStatus();
            status.Show();
        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog
                {
                    Filter = "Изображение |*.jpg;*.png;*.jpeg;*.bmp"
                };
                if (file.ShowDialog() == true)
                {

                    PhotoURL.Text = file.FileName;
                    ImageDriver.Source = ImageLogic.ImageFromByte(File.ReadAllBytes(file.FileName));

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            DriverLogic.ClearCurrentDriver();
        }

        private void ExitAccount_Click(object sender, RoutedEventArgs e)
        {
            SecurityContext.IdUser = 0;
            AuthorizationInspector authorization = new AuthorizationInspector();
            authorization.Show();
            this.Close();
        }
        private void TransportList_Click(object sender, RoutedEventArgs e)
        {
            Transport.TransportCurrentDriver transportCurrent = new Transport.TransportCurrentDriver();
            transportCurrent.Show();
        }

        private void FineList_Click(object sender, RoutedEventArgs e)
        {
            FineCurrentDriver fineCurrent = new FineCurrentDriver();
            fineCurrent.Show();
        }

        private void License_Click(object sender, RoutedEventArgs e)
        {
            LicenseCurrentDriver license = new LicenseCurrentDriver();
            license.Show();
        }
    }
}
