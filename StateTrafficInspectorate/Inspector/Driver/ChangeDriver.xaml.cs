using Logic.LogicsModel;
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

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для ChangeDriver.xaml
    /// </summary>
    public partial class ChangeDriver : Window
    {
        public ChangeDriver()
        {
            InitializeComponent();
        }
        DataTable dtDriver = new DataTable();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void VIN_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(VIN.Text.Length == 17)
            {
                Logic.SecurityContext.CurrentTransport = LogicTransport.GetIdByVIN(VIN.Text);
                CurrentDriverList.ItemsSource = DriverLogic.GetListDrivers().DefaultView;
                Change.IsEnabled = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtDriver = DriverLogic.GetListDrivers();
            NextDriverList.ItemsSource = dtDriver.DefaultView;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if(NextDriverList.SelectedCells.Count > 0)
            {
                LogicTransport.ChangeDriver(dtDriver.Rows[NextDriverList.SelectedIndex].ItemArray[2].ToString());
                MessageBox.Show("Смена владельца прошла успешно!");
                Logic.SecurityContext.CurrentTransport = 0;

                InspectorMainWindow inspector = new InspectorMainWindow();
                inspector.Show();
                this.Close();
            }
        }
    }
}
