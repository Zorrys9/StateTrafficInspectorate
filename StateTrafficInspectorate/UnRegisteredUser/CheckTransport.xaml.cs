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

namespace StateTrafficInspectorate.UnRegisteredUser
{
    /// <summary>
    /// Логика взаимодействия для CheckTransport.xaml
    /// </summary>
    public partial class CheckTransport : Window
    {
        public CheckTransport()
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

                Logic.SecurityContext.CurrentTransport = Logic.LogicsModel.LogicTransport.GetIdByVIN(VINcode.Text);

                CheckCurrentTransport currentTransport = new CheckCurrentTransport();
                currentTransport.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
