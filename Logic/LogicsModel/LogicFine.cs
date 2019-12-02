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
                dtFine.Rows.Add(item.Driver, item.DateBrith.ToShortDateString(), item.Sum, item.Description);
            }
            return dtFine;
        }

        public static DataTable GetFilterListFine(string name)
        {
            DataTable dtFine = new DataTable();
            dtFine.Columns.Add("Водитель");
            dtFine.Columns.Add("Дата рождения");
            dtFine.Columns.Add("Сумма");
            dtFine.Columns.Add("Описание");
            string LastName = "";
            string Patronymic = "";
            string[] NameArray = name.Split(' ');
            if (NameArray.Length <= 3)
            {
                string FirstName = NameArray[0];
                if (NameArray.Length > 1) LastName = NameArray[1];
                if (NameArray.Length > 2) Patronymic = NameArray[2];

                var Query = from fine in DbContext.db.FIne
                            join driver in DbContext.db.Drivers on fine.IdDriver equals driver.Id
                            where (driver.FirstName.Contains(FirstName) || driver.LastName.Contains(FirstName) || driver.Patronymic.Contains(FirstName))
                            && (driver.FirstName.Contains(LastName) || driver.LastName.Contains(LastName) || driver.Patronymic.Contains(LastName))
                            && (driver.FirstName.Contains(Patronymic) || driver.LastName.Contains(Patronymic) || driver.Patronymic.Contains(Patronymic))
                            select new
                            {
                                Driver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                                DateBrith = driver.DateBirth,
                                fine.Sum,
                                fine.Description
                            };
                foreach (var item in Query)
                {
                    dtFine.Rows.Add(item.Driver, item.DateBrith.ToShortDateString(), item.Sum, item.Description);
                }
            }
            return dtFine;
        }

        public static DataTable GetListFineCurrentDriver()
        {
            DataTable dtFine = new DataTable();
            dtFine.Columns.Add("Водитель");
            dtFine.Columns.Add("Дата рождения");
            dtFine.Columns.Add("Сумма");
            dtFine.Columns.Add("Описание");

            var Query = from fine in DbContext.db.FIne
                        join driver in DbContext.db.Drivers on fine.IdDriver equals driver.Id where driver.Id == SecurityContext.CurrentDriver
                        select new
                        {
                            Driver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            DateBrith = driver.DateBirth,
                            fine.Sum,
                            fine.Description
                        };
            foreach (var item in Query)
            {
                dtFine.Rows.Add(item.Driver, item.DateBrith, item.Sum, item.Description);
            }
            return dtFine;
        }

    }
}
