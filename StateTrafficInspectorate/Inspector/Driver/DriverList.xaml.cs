using System;
using System.Collections.Generic;
using System.Data;
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
namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для DriverList.xaml
    /// </summary>
    public partial class DriverList : Window
    {
        DataTable TableDriver = new DataTable();
        public DriverList()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                TableDriver = DriverLogic.GetListDrivers();
                ListDriver.ItemsSource = TableDriver.DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspectorMain = new InspectorMainWindow();
            inspectorMain.Show();
            this.Close();
        }

        private void NewDriver_Click(object sender, RoutedEventArgs e)
        {
            AddDriverWindow addDriver = new AddDriverWindow();
            addDriver.Show();
            this.Close();
        }

        private void ListDriver_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ListDriver.SelectedCells.Count() > 0)
                {
                    DriverLogic.CurrentDriver(TableDriver.Rows[ListDriver.SelectedIndex].ItemArray[2].ToString());

                    CurrentDriver currentDriver = new CurrentDriver();
                    currentDriver.Show();
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void NameDriver_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            TableDriver = DriverLogic.GetFilterListDrivers(NameDriver.Text);
            ListDriver.ItemsSource = TableDriver.DefaultView;
        }

        private void ListDriver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
