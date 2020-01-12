using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.OtherLogic
{
    public class ChangeDataBaseLogic
    {

        public static void Change(string conn)
        {
            DataBase.DataBaseLogic.Change(conn);
        }


    }
}
