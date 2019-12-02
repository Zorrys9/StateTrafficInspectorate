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

namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для InspectorList.xaml
    /// </summary>
    public partial class InspectorList : Window
    {
        public InspectorList()
        {
            InitializeComponent();
        }
        DataTable dtInspector = LogicInspector.GetListInspector();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void AddInspector_Click(object sender, RoutedEventArgs e)
        {
            AddNewInspector inspector = new AddNewInspector();
            inspector.Show();
            this.Close();
        }

        private void InspectorList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {

                if (ListInspector.SelectedCells.Count > 0)
                {
                    LogicInspector.CurrentInspector(dtInspector.Rows[ListInspector.SelectedIndex].ItemArray[1].ToString());

                    CurrentInspector inspector = new CurrentInspector();
                    inspector.Show();
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ListInspector.ItemsSource = dtInspector.DefaultView;

            ListInspector.Columns[0].Width = 220;
            ListInspector.Columns[1].Width = 95;
            ListInspector.Columns[2].Width = 95;
            ListInspector.Columns[3].Width = 100;
            ListInspector.Columns[4].Width = 100;

        }

        private void NameInspector_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtInspector = LogicInspector.GetFilterListInspector(NameInspector.Text);
            ListInspector.ItemsSource = dtInspector.DefaultView;
        }
    }
}
