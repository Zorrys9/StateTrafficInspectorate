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
using Logic.ViewModels;
using Logic.LogicsModel;
using StateTrafficInspectorate.Inspector.Transport;
using StateTrafficInspectorate.Inspector.Driver;

namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для InspectorMainWindow.xaml
    /// </summary>
    public partial class InspectorMainWindow : Window
    {
        public InspectorMainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

               InspectorViewModel CurrentInspector = LogicInspector.GetCurrentInspector();
               Name.Text = CurrentInspector.FirstName + " " + CurrentInspector.LastName + " " + CurrentInspector.Patronymic;
                Position.Text = CurrentInspector.Position;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Drivers_Click(object sender, RoutedEventArgs e)
        {
            Driver.DriverList drivers = new Driver.DriverList();
            drivers.Show();
            this.Close();
        }

        private void ExitAccount_Click(object sender, RoutedEventArgs e)
        {
            Logic.SecurityContext.IdUser = 0;
            AuthorizationInspector inspector = new AuthorizationInspector();
            inspector.Show();
            this.Close();
        }

        private void Transport_Click(object sender, RoutedEventArgs e)
        {
            TransportList transportList = new TransportList();
            transportList.Show();
            this.Close();
        }

        private void AddLicense_Click(object sender, RoutedEventArgs e)
        {
            AddLicense addLicense = new AddLicense();
            addLicense.Show();
            this.Close();
        }

        private void ChangeDriver_Click(object sender, RoutedEventArgs e)
        {
            ChangeDriver changeDriver = new ChangeDriver();
            changeDriver.Show();
            this.Close();
        }

        private void AddInsurance_Click(object sender, RoutedEventArgs e)
        {
            AddInsurance addInsurance = new AddInsurance();
            addInsurance.Show();
            this.Close();
        }

        private void InspectorList_Click(object sender, RoutedEventArgs e)
        {
            InspectorList inspectorList = new InspectorList();
            inspectorList.Show();
            this.Close();
        }

        private void AddFine_Click(object sender, RoutedEventArgs e)
        {
            Fine fine = new Fine();
            fine.Show();
            this.Close();
        }

        private void ChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            ChangeStatus changeStatus = new ChangeStatus();
            changeStatus.Show();
            this.Close();
        }
    }
}
