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

namespace StateTrafficInspectorate.Inspector.Transport
{
    /// <summary>
    /// Логика взаимодействия для TransportCurrentDriver.xaml
    /// </summary>
    public partial class TransportCurrentDriver : Window
    {
        public TransportCurrentDriver()
        {
            InitializeComponent();
            TransportList.ItemsSource = Logic.LogicsModel.LogicTransport.GetTransportListCurrentDriver().DefaultView;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
