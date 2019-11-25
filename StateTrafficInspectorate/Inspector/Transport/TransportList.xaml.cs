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
using Logic.LogicsModel;
namespace StateTrafficInspectorate.Inspector.Transport
{
    /// <summary>
    /// Логика взаимодействия для TransportList.xaml
    /// </summary>
    public partial class TransportList : Window
    {
        public TransportList()
        {
            InitializeComponent();
        }
        DataTable dtTransport = new DataTable();
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            InspectorMainWindow inspector = new InspectorMainWindow();
            inspector.Show();
            this.Close();
        }

        private void NewDriver_Click(object sender, RoutedEventArgs e)
        {
            AddTransport addTransport = new AddTransport();
            addTransport.Show();
            this.Close();
        }
        private void TransportList_Loaded(object sender, RoutedEventArgs e)
        {
            dtTransport = LogicTransport.GetTransportList();
            Transports.ItemsSource = dtTransport.DefaultView;
        }

        private void TransportList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(Transports.SelectedCells.Count() > 0)
            {

                LogicTransport.CurrentTransport(dtTransport.Rows[Transports.SelectedIndex].ItemArray[4].ToString());

                CurrentTransport currentTransport = new CurrentTransport();
                currentTransport.Show();
                this.Close();
            }
        }
    }
}
