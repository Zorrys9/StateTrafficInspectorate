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
    /// Логика взаимодействия для TransportList.xaml
    /// </summary>
    public partial class TransportList : Window
    {
        public TransportList()
        {
            InitializeComponent();
        }

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

        private void TextBlock_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentTransport currentTransport = new CurrentTransport();
            currentTransport.Show();
            this.Close();
        }
    }
}
