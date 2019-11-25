using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicTypeOfDrive
    {

        public static List<string> GetNameType()
        {
            List<string> NameList = new List<string>();
            var QueryList = DbContext.db.TypeOfDrive;
            foreach(var name in QueryList)
            {
                NameList.Add(name.Name);
            }
            return NameList;
        }

        public static int GetIdByName(string name)
        {
            return DbContext.db.TypeOfDrive.Where(type => type.Name == name).FirstOrDefault().Id;
        }

    }
}
