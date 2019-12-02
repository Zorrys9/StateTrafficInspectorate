using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Logic.LogicsModel;
using Logic.Models;
using Logic.ViewModels;
using Logic.OtherLogic;

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для LicenseCurrentDriver.xaml
    /// </summary>
    public partial class LicenseCurrentDriver : Window
    {
        public LicenseCurrentDriver()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG формат|* .png";
                save.Title = "Сохранение файла";
                save.ShowDialog();


                var rtb = new RenderTargetBitmap((int)LicenseImage.Width, (int)LicenseImage.Height, 96d, 96d, PixelFormats.Pbgra32);

                LicenseImage.Measure(new Size((int)LicenseImage.Width, (int)LicenseImage.Height));
                LicenseImage.Arrange(new Rect(new Size((int)LicenseImage.Width, (int)LicenseImage.Height)));
                rtb.Render(LicenseImage);

                PngBitmapEncoder BufferSave = new PngBitmapEncoder();
                BufferSave.Frames.Add((BitmapFrame.Create(rtb)));
                using (var fs = File.OpenWrite(save.FileName))
                {
                    BufferSave.Save(fs);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                LicenseViewModel driver = LogicLicense.GetLicenseModel();
                FirstName.Content = driver.FirstName;
                LastNamePatr.Content = driver.LastNamePatr;
                DateBirth.Content = driver.DateBirth;
                AddressLife.Content = driver.AddressLife;
                Address.Content = driver.Address;
                DateLicense.Content = driver.DateLicense;
                DateExpire.Content = driver.DateExpire;
                LicenseSeriesNumber.Content = driver.SeriesNumberLicense;
                Category.Content = driver.Category;
                DriverImage.Source = ImageLogic.ImageFromByte(driver.Photo);
                FirstNameTranslyte.Content = StringType.Translyte(driver.FirstName);
                LastNamePatrTranslyte.Content = StringType.Translyte(driver.LastNamePatr);
                AddressLifeTranslyte.Content = StringType.Translyte(driver.AddressLife);
                AddressTranslyte.Content = StringType.Translyte(driver.Address);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          

        }
    }
}
