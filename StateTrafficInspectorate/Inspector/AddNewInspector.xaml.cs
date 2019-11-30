using Logic.LogicsModel;
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
namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для AddNewInspector.xaml
    /// </summary>
    public partial class AddNewInspector : Window
    {
        public AddNewInspector()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorList inspectorList = new InspectorList();
            inspectorList.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InspectorModel inspector = new InspectorModel()
                {
                    FirstName = FirtsName.Text,
                    LastName = LastName.Text,
                    Patronymic = Patronymic.Text,
                    DateBirth = DateBirth.SelectedDate.Value,
                    Login = Login.Text,
                    Password = Password.Text,
                    PasportSeries = PasportSeries.Text,
                    PasportNumber = PasportNumber.Text,
                    Position = LogicPosition.GetIdByName(Position.Text)
                };

                LogicInspector.SaveInspector(inspector);
                MessageBox.Show("Инспектор успешно зарегистрирован!");

                InspectorList inspectorList = new InspectorList();
                inspectorList.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Position.ItemsSource = LogicPosition.GetNameList();
        }
    }
}
