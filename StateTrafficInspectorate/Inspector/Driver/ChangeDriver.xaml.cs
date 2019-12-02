using Logic.LogicsModel;
using Logic.OtherLogic;
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
            try
            {

                if (VIN.Text.Length == 17)
                {
                    if (LogicTransport.GetIdByVIN(VIN.Text) == 0)
                    {
                        Change.IsEnabled = false;
                        MessageBoxResult message = MessageBox.Show("Транспорта с таким VIN кодом не существует, желаете добавить новый транспорт?", "Транспорт не найден", MessageBoxButton.YesNo);
                        if (message == MessageBoxResult.Yes)
                        {
                            Transport.AddTransport addTransport = new Transport.AddTransport();
                            LogicWindow.FromChangeDriver();
                            addTransport.Show();
                        }
                    }
                    else
                    {
                        Change.IsEnabled = true;
                        Logic.SecurityContext.CurrentTransport = LogicTransport.GetIdByVIN(VIN.Text);
                        CurrentDriverList.ItemsSource = DriverLogic.GetListDrivers().DefaultView;

                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtDriver = DriverLogic.GetListDrivers();
            NextDriverList.ItemsSource = dtDriver.DefaultView;

            NextDriverList.Columns[0].Width = 200;
            NextDriverList.Columns[1].Width = 100;
            NextDriverList.Columns[2].Width = 100;
            NextDriverList.Columns[3].Width = 100;
            NextDriverList.Columns[4].Width = 100;
            NextDriverList.Columns[5].Width = 70;
            NextDriverList.Columns[6].Width = 100;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (NextDriverList.SelectedCells.Count > 0)
                {
                    LogicTransport.ChangeDriver(dtDriver.Rows[NextDriverList.SelectedIndex].ItemArray[2].ToString());
                    MessageBox.Show("Смена владельца прошла успешно!");
                    Logic.SecurityContext.CurrentTransport = 0;

                    InspectorMainWindow inspector = new InspectorMainWindow();
                    inspector.Show();
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
            dtDriver = DriverLogic.GetFilterListDrivers(NameDriver.Text);
            NextDriverList.ItemsSource = dtDriver.DefaultView;
        }
    }
}
