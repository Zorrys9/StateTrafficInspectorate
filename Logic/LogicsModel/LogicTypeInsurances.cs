using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicTypeInsurances
    {

        public static List<string> GetNameList()
        {
            List<string> ListName = new List<string>();

            var Query = DbContext.db.TypeInsurances;
            foreach(var name in Query)
            {
                ListName.Add(name.Name);
            }

            return ListName;
        } 

        public static int GetIdByName(string name)
        {
            return DbContext.db.TypeInsurances.Where(type => type.Name == name).FirstOrDefault().Id;
        }

    }
}
