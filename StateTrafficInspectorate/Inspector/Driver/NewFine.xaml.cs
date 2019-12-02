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

namespace StateTrafficInspectorate.Inspector.Driver
{
    /// <summary>
    /// Логика взаимодействия для NewFine.xaml
    /// </summary>
    public partial class NewFine : Window
    {
        public NewFine()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Fine fine = new Fine();
            fine.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                FineModel fine = new FineModel()
                {
                    IdDriver = LogicLicense.GetIdDriver(Driver.Text),
                    Sum = double.Parse(Sum.Text),
                    Description = Description.Text
                };
                LogicFine.SaveFine(fine);
                MessageBox.Show("Новый штраф успешно создан");

                Fine fineList = new Fine();
                fineList.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Driver_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (Driver.Text.Length == 10)
                {
                    if (LogicLicense.GetId(Driver.Text) == 0)
                    {
                        Add.IsEnabled = false;
                        MessageBoxResult message = MessageBox.Show("Водитель с такими данными не найден, желаете его добавить?", "Водитель не найден", MessageBoxButton.YesNo);
                        if (message == MessageBoxResult.Yes)
                        {
                            Driver.AddDriverWindow addDriver = new Driver.AddDriverWindow();
                            addDriver.Show();
                        }
                    }
                    else Add.IsEnabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
