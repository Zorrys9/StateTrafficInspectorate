using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicStatusLicense
    {

        public static List<string> GetListNameStatus()
        {
            List<string> listName = new List<string>();
            var NameQuery = DbContext.db.StatusLicense;
            foreach(var name in NameQuery)
            {
                listName.Add(name.Name);
            }
            return listName;
        }

        public static int GetIdByName(string name)
        {
            return DbContext.db.StatusLicense.Where(st => st.Name == name).FirstOrDefault().Id;
        }

    }
}
