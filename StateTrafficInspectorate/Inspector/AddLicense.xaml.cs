using Logic.LogicsModel;
using System.Windows;

namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для AddLicense.xaml
    /// </summary>
    public partial class AddLicense : Window
    {
        public bool CheckDriver = false;
        public bool CheckTransport = false;
        public AddLicense()
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

        }

        private void PassportDriver_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if(PassportDriver.Text.Length == 10 )
            {
                if (DriverLogic.GetIdByPassport(PassportDriver.Text) == 0)
                {
                    CheckDriver = false;
                    MessageBoxResult message = MessageBox.Show("Водитель с такими данными не найден, желаете его добавить?", "Водитель не найден", MessageBoxButton.YesNo);
                    if (message == MessageBoxResult.Yes)
                    {
                        Driver.AddDriverWindow addDriver = new Driver.AddDriverWindow();
                        addDriver.Show();
                    }
                }
                else CheckDriver = true;
            }
        }

        private void VIN_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (VIN.Text.Length == 10)
            {
                if (LogicTransport.GetIdByVIN(VIN.Text) == 0)
                {
                    CheckTransport = false;
                    MessageBoxResult message = MessageBox.Show("Транспорта с таким VIN кодом не существует, желаете добавить новый транспорт?", "Транспорт не найден", MessageBoxButton.YesNo);
                    if (message == MessageBoxResult.Yes)
                    {
                        Transport.AddTransport addTransport = new Transport.AddTransport();
                        addTransport.Show();
                    }
                }
                else CheckTransport = true;
            }
        }
    }
}
