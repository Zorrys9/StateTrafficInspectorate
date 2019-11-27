using Logic.LogicsModel;
using Logic.Models;
using System.Collections.Generic;
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
            LicenseModel license = new LicenseModel();
            license.IdDriver = DriverLogic.GetIdByPassport(PassportDriver.Text);
            license.IdTransport = LogicTransport.GetIdByVIN(VIN.Text);
            license.LicenseDate = LicenseDate.SelectedDate.Value;
            license.ExpireDate = ExpireDate.SelectedDate.Value;
            license.LicenseSeries = Series.Text;
            license.LicenseNumber = Number.Text;

            List<string> listCategory = new List<string>();
            if (M.IsChecked == true) listCategory.Add("M"); 
            if (A.IsChecked == true) listCategory.Add("A"); 
            if (A1.IsChecked == true) listCategory.Add("A1"); 
            if (B.IsChecked == true) listCategory.Add("B"); 
            if (D1.IsChecked == true) listCategory.Add("D1"); 
            if (D.IsChecked == true) listCategory.Add("D"); 
            if (CE.IsChecked == true) listCategory.Add("CE"); 
            if (C1E.IsChecked == true) listCategory.Add("C1E"); 
            if (BE.IsChecked == true) listCategory.Add("BE"); 
            if (B1.IsChecked == true) listCategory.Add("B1"); 
            if (C.IsChecked == true) listCategory.Add("C"); 
            if (C1.IsChecked == true) listCategory.Add("C1"); 
            if (D1E.IsChecked == true) listCategory.Add("D1E"); 
            if (DE.IsChecked == true) listCategory.Add("DE"); 
            if (Tm.IsChecked == true) listCategory.Add("Tm"); 
            if (Tb.IsChecked == true) listCategory.Add("Tb"); 

            for(int i = 0; i < listCategory.Count; i++)
            {
                license.Categories = listCategory[i];
            }

            LogicLicense.SaveLicense(license);
            MessageBox.Show("Водительское удостоверение успешно сохранено!");

            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
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
                if (CheckTransport && CheckDriver)
                    Add.IsEnabled = true;
            }
        }

        private void VIN_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (VIN.Text.Length == 17)
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
                if (CheckTransport && CheckDriver)
                    Add.IsEnabled = true;
            }
        }
    }
}
