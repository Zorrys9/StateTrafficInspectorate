using Logic.LogicsModel;
using Logic.Models;
using Logic.OtherLogic;
using System;
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
            try
            {

                LicenseModel license = new LicenseModel();
                license.IdDriver = DriverLogic.GetIdByPassport(PassportDriver.Text);
                license.IdTransport = LogicTransport.GetIdByVIN(VIN.Text);
                license.LicenseDate = LicenseDate.SelectedDate.Value;
                license.ExpireDate = ExpireDate.SelectedDate.Value;
                license.LicenseSeries = Series.Text;
                license.LicenseNumber = Number.Text;

                CategoryLicenseModel category = new CategoryLicenseModel();

                List<string> listCategory = new List<string>();
                if (M.IsChecked == true) category.M = true;
                if (A.IsChecked == true) category.A = true;
                if (A1.IsChecked == true) category.A1 = true;
                if (B.IsChecked == true) category.B = true;
                if (D1.IsChecked == true) category.D1 = true;
                if (D.IsChecked == true) category.D = true;
                if (CE.IsChecked == true) category.CE = true;
                if (C1E.IsChecked == true) category.C1E = true;
                if (BE.IsChecked == true) category.BE = true;
                if (B1.IsChecked == true) category.B1 = true;
                if (C.IsChecked == true) category.C = true;
                if (C1.IsChecked == true) category.C1 = true;
                if (D1E.IsChecked == true) category.D1E = true;
                if (DE.IsChecked == true) category.DE = true;
                if (Tm.IsChecked == true) category.Tm = true;
                if (Tb.IsChecked == true) category.Tb = true;


                LogicLicense.SaveLicense(license);
                category.IdLicense = LogicLicense.GetId(Series.Text + Number.Text);
                LogicCategoryLicense.SaveCategory(category);
                MessageBox.Show("Водительское удостоверение успешно сохранено!");

                InspectorMainWindow inspector = new InspectorMainWindow();
                inspector.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PassportDriver_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {

                if (PassportDriver.Text.Length == 10)
                {
                    if (DriverLogic.GetIdByPassport(PassportDriver.Text) == 0)
                    {
                        CheckDriver = false;
                        MessageBoxResult message = MessageBox.Show("Водитель с такими данными не найден, желаете его добавить?", "Водитель не найден", MessageBoxButton.YesNo);
                        if (message == MessageBoxResult.Yes)
                        {
                            Logic.OtherLogic.LogicWindow.FromAddLicense();
                            Driver.AddDriverWindow addDriver = new Driver.AddDriverWindow();
                            addDriver.Show();
                        }
                    }
                    else CheckDriver = true;
                    if (CheckTransport && CheckDriver)
                        Add.IsEnabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void VIN_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
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
                            LogicWindow.FromAddLicense();
                            addTransport.Show();
                        }
                    }
                    else CheckTransport = true;
                    if (CheckTransport && CheckDriver)
                        Add.IsEnabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
