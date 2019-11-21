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
using Logic.LogicsModel;
using Logic.Models;

namespace StateTrafficInspectorate.Inspector
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationInspector.xaml
    /// </summary>
    public partial class AuthorizationInspector : Window
    {
        public AuthorizationInspector()
        {
            InitializeComponent();
        }


        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                UserModel user = new UserModel()
                {
                    Login = Login.Text,
                    Password = Password.Password
                };
                LogicUser.Authorization(user);

                InspectorMainWindow inspectorMain = new InspectorMainWindow();
                inspectorMain.Show();
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
