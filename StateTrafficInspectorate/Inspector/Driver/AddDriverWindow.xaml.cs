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
using Logic;
using Logic.Enums;

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для AddDriverWindow.xaml
    /// </summary>
    public partial class AddDriverWindow : System.Windows.Window
    {
        public AddDriverWindow()
        {
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
                    FullAddressLife = CityLife.Text + " " + AddressLife.Text,
                    FullAddress = City.Text + " " + AddressLife.Text,
                    Telephone = Phone.Text,
                    DrivingExperience = int.Parse(Expirience.Text),
                    PostCode = int.Parse(PostCode.Text),
                    Company = Company.Text,
                    JobName = JobName.Text,
                    Email = Email.Text
                    
                };
                if(ImageURL.Text == "")
                {
                    newDriver.Photo = null;
                }
                else
                {
                    newDriver.Photo = ImageLogic.ByteFromImage(ImageURL.Text);
                }
                DriverLogic.AddDriver(newDriver);

                MessageBox.Show("Водитель успешно добавлен!");

                switch (SecurityContext.CurrentWindow)
                {
                    case Logic.Enums.EnumWindow.AddLicense:
                        this.Close();
                        break;
                    case Logic.Enums.EnumWindow.AddTransport:
                        this.Close();
                        break;
                    case Logic.Enums.EnumWindow.DriverList:
                        DriverList driverList = new DriverList();
                        driverList.Show();
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                OpenFileDialog FileDialog = new OpenFileDialog
                {
                    Filter = "Изображение |*.jpg;*.jpeg;*.png;*.bmp"
                };
                if (FileDialog.ShowDialog() == true)
                {
                    ImageURL.Text = FileDialog.FileName;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            switch(SecurityContext.CurrentWindow)
            {
                case Logic.Enums.EnumWindow.AddLicense:
                    this.Close();
                    break;
                case Logic.Enums.EnumWindow.AddTransport:
                    this.Close();
                    break;
                case Logic.Enums.EnumWindow.DriverList:
                    DriverList driverList = new DriverList();
                    driverList.Show();
                    this.Close();
                    break;
            }

        }
    }
}
