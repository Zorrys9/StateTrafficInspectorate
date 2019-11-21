using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;
using Logic;
namespace Logic.LogicsModel
{
    public class LogicUser
    {

        public static void Authorization(UserModel user)
        {
            var User = DbContext.db.Inspector.Where(ins => ins.Login == user.Login && ins.Password == user.Password);
            if (User.Count() == 1)
            {
                SecurityContext.IdUser = User.FirstOrDefault().Id;
            }
            else throw new Exception("Логин или пароль введены не верно!");
        }

    }
}
