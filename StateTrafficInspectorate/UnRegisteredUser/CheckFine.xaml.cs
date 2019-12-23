using Logic.LogicsModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace StateTrafficInspectorate.UnRegisteredUser
{
    /// <summary>
    /// Логика взаимодействия для CheckFine.xaml
    /// </summary>
    public partial class CheckFine : Window
    {
        public CheckFine()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (FilterName.SelectedIndex)
                {
                    case 0:
                        //pasport
                        FineList.ItemsSource = DriverLogic.GetListFine(CheckItem.Text).DefaultView;
                        break;
                    case 1:
                        //license
                        FineList.ItemsSource = LogicLicense.GetListFine(CheckItem.Text).DefaultView;
                        break;
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

    }
}
