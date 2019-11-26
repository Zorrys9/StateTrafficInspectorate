using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicCategoryTransport
    {

        public static List<string> GetNameCategory()
        {
            var ListQuery = DbContext.db.CategoryTransport;
            List<string> NameList = new List<string>();
            foreach(var name in ListQuery)
            {
                NameList.Add(name.Name + name.Id.ToString());
            }
            return NameList;
        }

        public static int GetIdByName(string name)
        {
            return DbContext.db.CategoryTransport.Where(cat => cat.Name == name).FirstOrDefault().Id;
        }

    }
}
