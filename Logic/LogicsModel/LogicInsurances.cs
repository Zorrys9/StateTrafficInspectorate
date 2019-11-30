using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;
namespace Logic.LogicsModel
{
    public class LogicInsurances
    {

        public static void SaveInsurance(InsurancesModel insurances)
        {
            DbContext.db.Insurances.Add(insurances);
            DbContext.db.SaveChanges();
        }

    }
}
