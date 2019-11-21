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
    }
}
