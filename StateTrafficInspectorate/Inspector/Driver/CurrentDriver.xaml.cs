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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DriverLogic.ClearCurrentDriver();
            DriverList driver = new DriverList();
            driver.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DriverViewModel driver = DriverLogic.GetCurrentDriver();

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
                DriverLogic.DeleteDriver();
                MessageBox.Show("Водитель успешно удален!");
                DriverList driverList = new DriverList();
                driverList.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeDriver_Click(object sender, RoutedEventArgs e)
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
                    SerialPasp = Passport.Text.Substring(0,4),
                    NumberPasp = Passport.Text.Substring(4,6),
                    DateBirth = DateBirth.SelectedDate.Value,
                    DrivingExperience = int.Parse(Expirience.Text),
                    FullAddressLife = AddressLife.Text,
                    FullAddress = Address.Text,
                    PostCode = int.Parse(PostCode.Text),
                    Company = Company.Text,
                    JobName = JobName.Text
                };
            }
            else throw new Exception("ФИО введен не верно!");
        }

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Изображение |*.jpg;*.png;*.jpeg;*.bmp";
            if (file.ShowDialog() == true)
            {

                PhotoURL.Text = file.FileName;
                ImageDriver.Source = File.WriteAllBytes(new Uri(file.FileName));

            }
        }
    }
}
