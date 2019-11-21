using Microsoft.Win32;
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
using System.IO;
using Logic.OtherLogic;

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для AddDriverWindow.xaml
    /// </summary>
    public partial class AddDriverWindow : Window
    {
        public AddDriverWindow()
        {new BitmapImage();
            InitializeComponent();
        }


        private void AddDriver_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DriverModel newDriver = new DriverModel()
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Patronymic = Patronymic.Text,
                    SerialPasp = PaspSeries.Text,
                    NumberPasp = PaspNumber.Text,
                    DateBirth = DateBirth.SelectedDate.Value,
                    FullAddress = Address.Text,
                    AddressLifeCity = CityLife.Text,
                    FullAddressLife = AddressLife.Text,
                    AddressCity = City.Text,
                    Telephone = "+7" + Phone.Text,
                    DrivingExperience = int.Parse(Expirience.Text),
                    PostCode = int.Parse(PostCode.Text),
                    Company = Company.Text,
                    JobName = JobName.Text,
                    Email = Email.Text,
                    Photo = ImageLogic.ByteFromImage(ImageURL.Text)
                };

                DriverLogic.AddDriver(newDriver);

                MessageBox.Show("Водитель успешно добавлен!");

                DriverList driverList = new DriverList();
                driverList.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Изображение |*.jpg;*.jpeg;*.png;*.bmp";
            if(FileDialog.ShowDialog() == true)
            {
                ImageURL.Text = FileDialog.FileName;
            }
        }
    }
}
