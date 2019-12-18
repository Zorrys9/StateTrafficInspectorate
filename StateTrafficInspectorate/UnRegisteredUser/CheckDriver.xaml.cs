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
    /// Логика взаимодействия для CheckDriver.xaml
    /// </summary>
    public partial class CheckDriver : Window
    {
        public CheckDriver()
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

                if (Logic.LogicsModel.LogicLicense.CurrentDriver(License.Text))
                {

                    CheckCurrentDriver currentDriver = new CheckCurrentDriver();
                    currentDriver.Show();
                    this.Close();

                }
                else throw new Exception("Водителя с таким ВУ не существует");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
