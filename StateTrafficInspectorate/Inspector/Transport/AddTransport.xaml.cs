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
namespace StateTrafficInspectorate.Inspector.Transport
{
    /// <summary>
    /// Логика взаимодействия для AddTransport.xaml
    /// </summary>
    public partial class AddTransport : Window
    {
        public AddTransport()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransportList transportList = new TransportList();
            transportList.Show();
            this.Close();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryTransport.ItemsSource = LogicCategoryTransport.GetNameCategory();
            TypeOfDrive.ItemsSource = LogicTypeOfDrive.GetNameType();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TransportModel transport = new TransportModel
                {
                    Manufacturer = Manufacturer.Text,
                    Model = Model.Text,
                    CategoryTransport = LogicCategoryTransport.GetIdByName(CategoryTransport.Text),
                    YearTransport = Year.Text,
                    NumberEngine = NumberEngine.Text,
                    ModelEngine = ModelEngine.Text,
                    YearEngine = YearEngine.Text,
                    PowerEngineKVT = PowerEngineK.Text,
                    PowerEngineH = PowerEngineH.Text,
                    MaxLoad = double.Parse(MaxWeight.Text),
                    Color = Color.Text,
                    Weight = double.Parse(Weight.Text),
                    VIN = VIN.Text,
                    TypeOfDrive = LogicTypeOfDrive.GetIdByName(TypeOfDrive.Text),
                    IdDriver = DriverLogic.GetIdByPassport(Passport.Text),
                    Description = Descriptoin.Text
                };

                LogicTransport.SaveTransport(transport);
                MessageBox.Show("Транспорт успешно добавлен");

                TransportList transportList = new TransportList();
                transportList.Show();
                this.Close();
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Passport_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Passport.Text.Length == 10 && DriverLogic.GetIdByPassport(Passport.Text) == 0)
            {
                Add.IsEnabled = false;
                MessageBoxResult message = MessageBox.Show("Водителя с такими паспортными данными не существует! Желаете добавить его?", "Водитель не найден", MessageBoxButton.YesNo);
                if (message == MessageBoxResult.Yes)
                {
                    Driver.AddDriverWindow addDriver = new Driver.AddDriverWindow();
                    addDriver.Show();
                    this.Close();
                }
            }else Add.IsEnabled = true;
        }
    }
}
