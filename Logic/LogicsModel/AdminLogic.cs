using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;
namespace Logic.LogicsModel
{
    public class AdminLogic
    {

        public static void AuthorizationAdmin(UserModel admin)
        {
            if (Properties.Settings.Default.AdminLogin == admin.Login && Properties.Settings.Default.AdminPassword == admin.Password) { }
                else throw new Exception("Логин или пароль администратора введены не верно, проверьте введенные данные и повторите попытку");

        }

        public static void ChangeLoginAdmin(string currentLogin, string newLogin)
        {
            if (currentLogin == Properties.Settings.Default.AdminLogin)
                Properties.Settings.Default.AdminLogin = newLogin;
            else throw new Exception("Текущий логин введен не верно, смена логина прервана");
        }
        public static void ChangePasswordAdmin(string currentPassword, string newPassword)
        {
            if (currentPassword == Properties.Settings.Default.AdminPassword)
                Properties.Settings.Default.AdminPassword = newPassword;
            else throw new Exception("Текущий пароль введен не верно, смена пароля прервана");
        }
    }
}
