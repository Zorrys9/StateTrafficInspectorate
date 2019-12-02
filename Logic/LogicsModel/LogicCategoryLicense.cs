using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;
namespace Logic.LogicsModel
{
    public class LogicCategoryLicense
    {

        public static void SaveCategory(CategoryLicenseModel NewCategory)
        {
            DbContext.db.CategoryLicense.Add(NewCategory);
            DbContext.db.SaveChanges();
        }

    }
}
