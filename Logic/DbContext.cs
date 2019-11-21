using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
namespace Logic
{
    public class DbContext
    {
       public static DataBase.DbContext db = new DataBase.DbContext();
    }
}
