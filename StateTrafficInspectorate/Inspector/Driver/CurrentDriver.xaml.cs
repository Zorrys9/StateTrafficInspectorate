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
using Logic.Models;
using Logic.OtherLogic;
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
            DriverList driver = new DriverList();
            driver.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DriverModel driver = DriverLogic.GetDriver();
            ImageDriver.Source = ImageLogic.ImageFromByte(driver.Photo);
        }
    }
}
