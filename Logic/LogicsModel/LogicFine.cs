using Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicFine
    {

        public static void SaveFine(FineModel fine)
        {
            DbContext.db.FIne.Add(fine);
            DbContext.db.SaveChanges();
        }
        
        public static DataTable GetListFine()
        {
            DataTable dtFine = new DataTable();
            dtFine.Columns.Add("Водитель");
            dtFine.Columns.Add("Дата рождения");
            dtFine.Columns.Add("Сумма");
            dtFine.Columns.Add("Описание");

            var Query = from fine in DbContext.db.FIne
                        join driver in DbContext.db.Drivers on fine.IdDriver equals driver.Id
                        select new
                        {
                            Driver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            DateBrith = driver.DateBirth,
                            fine.Sum,
                            fine.Description
                        };
            foreach(var item in Query)
            {
                dtFine.Rows.Add(item.Driver, item.DateBrith, item.Sum, item.Description);
            }
            return dtFine;
        }

    }
}
