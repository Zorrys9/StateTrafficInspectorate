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
using Logic;

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для ChangeStatus.xaml
    /// </summary>
    public partial class ChangeStatus : Window
    {
        public ChangeStatus()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StatusChangeModel status = new StatusChangeModel();

                status.DateChange = DateTime.Today;
                status.Descriptoin = Description.Text;
                status.IdLicense = LogicLicense.GetId(License.Text);
                status.CurrentStatus = LogicStatusLicense.GetIdByName(StatusName.Text);

                LogicLicense.ChangeStatusLicense(status);
                MessageBox.Show("Статус лицензии успешно изменен!");

                InspectorMainWindow inspector = new InspectorMainWindow();
                inspector.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            StatusName.ItemsSource = LogicStatusLicense.GetListNameStatus();
            if(SecurityContext.CurrentDriver != 0)
            {
                var driver = DriverLogic.GetCurrentDriver();
            }
        }

        private void License_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(License.Text.Length == 10)
            {
                if (LogicLicense.CheckLicense(License.Text))
                    Change.IsEnabled = true;
                else
                {
                    Change.IsEnabled = false;
                    MessageBoxResult message = MessageBox.Show("Данного водительского удостоверения не найдено, желаете создать его?", "Водительское удостоверение не найдено", MessageBoxButton.YesNo);
                    if (message == MessageBoxResult.Yes)
                    {
                        Inspector.AddLicense license = new AddLicense();
                        license.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
