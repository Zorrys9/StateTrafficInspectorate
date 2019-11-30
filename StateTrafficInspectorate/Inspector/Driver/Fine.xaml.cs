using Logic.LogicsModel;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Fine.xaml
    /// </summary>
    public partial class Fine : Window
    {
        public Fine()
        {
            InitializeComponent();
        }
        DataTable dtFine = new DataTable();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void NewFine_Click(object sender, RoutedEventArgs e)
        {
            NewFine newFine = new NewFine();
            newFine.Show();
            this.Close();
        }

        private void FineList_Loaded(object sender, RoutedEventArgs e)
        {
            dtFine = LogicFine.GetListFine();
            FineList.ItemsSource = dtFine.DefaultView;
        }
    }
}
