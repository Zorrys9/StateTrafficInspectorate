using Logic.LogicsModel;
using Logic.Models;
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

namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для CurrentInspector.xaml
    /// </summary>
    public partial class CurrentInspector : Window
    {
        public CurrentInspector()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorList inspectorList = new InspectorList();
            inspectorList.Show();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                InspectorModel inspector = LogicInspector.GetInfoCurrentInspector();

                FirstName.Text = inspector.FirstName;
                LastName.Text = inspector.LastName;
                Patronymic.Text = inspector.Patronymic;
                Login.Text = inspector.Login;
                Password.Text = inspector.Password;
                DateBirth.SelectedDate = inspector.DateBirth;
                PasportSeries.Text = inspector.PasportSeries;
                PasportNumber.Text = inspector.PasportNumber;
                Position.ItemsSource = LogicPosition.GetNameList();
                Position.SelectedIndex = (int)inspector.Position - 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
