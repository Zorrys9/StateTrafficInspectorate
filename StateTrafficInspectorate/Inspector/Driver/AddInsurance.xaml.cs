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
namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для AddInsurance.xaml
    /// </summary>
    public partial class AddInsurance : Window
    {
        public AddInsurance()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            InsurancesModel insurances = new InsurancesModel()
            {
                IdTransport = LogicTransport.GetIdByVIN(VIN.Text),
                InsurancesDate = DateInsurance.SelectedDate.Value,
                ExpireDate = DateExpire.SelectedDate.Value,
                Series = Series.Text,
                Number = Number.Text,
                Type = LogicTypeInsurances.GetIdByName(Type.Text),
                Sum = double.Parse(Sum.Text)
            };
            LogicInsurances.SaveInsurance(insurances);
            MessageBox.Show("Страховка успешно зарегистрирована");

            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Type.ItemsSource = LogicTypeInsurances.GetNameList();
        }

        private void VIN_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (VIN.Text.Length == 17)
            {
                if (LogicTransport.GetIdByVIN(VIN.Text) == 0)
                {
                    Add.IsEnabled = false;
                    MessageBoxResult message = MessageBox.Show("Транспорта с таким VIN кодом не существует, желаете добавить новый транспорт?", "Транспорт не найден", MessageBoxButton.YesNo);
                    if (message == MessageBoxResult.Yes)
                    {
                        Transport.AddTransport addTransport = new Transport.AddTransport();
                        addTransport.Show();
                    }
                }
                else Add.IsEnabled = true;
            }
        }
    }
}
