using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicPosition
    {

        public static List<string> GetNameList()
        {
            List<string> ListName = new List<string>();
            var Query = DbContext.db.Position;
            foreach(var pos in Query)
            {
                ListName.Add(pos.Name);
            }
            return ListName;
        }

        public static int GetIdByName(string name)
        {
            return DbContext.db.Position.Where(pos => pos.Name == name).FirstOrDefault().Id;
        }

    }
}
