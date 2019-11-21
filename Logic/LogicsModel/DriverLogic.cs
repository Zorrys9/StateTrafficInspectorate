using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.ViewModels;
using Logic.Models;
namespace Logic.LogicsModel
{
    public class DriverLogic
    {

        public static DataTable GetListDrivers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Дата рождения");
            dt.Columns.Add("Паспорт");
            dt.Columns.Add("Адрес");
            dt.Columns.Add("Телефон");
            dt.Columns.Add("Водительский стаж");
            dt.Columns.Add("Email");

            DriverView driverView;
            var ListDriver = DbContext.db.Drivers;
            foreach(var driver in ListDriver)
            {
                driverView = driver;
                dt.Rows.Add(driverView.Name, driverView.DateBirth.ToShortDateString(), driverView.Passport, driverView.FullAddress, driverView.Telephone, driverView.DrivingExperience, driverView.Email);
            }
            return dt;
        }

        public static void AddDriver(DriverModel newDriver)
        {
            DbContext.db.Drivers.Add(newDriver);
            DbContext.db.SaveChanges();
        }

        public static void CurrentDriver(string pasp)
        {
            SecurityContext.CurrentDriver = DbContext.db.Drivers.Where(dr => dr.SerialPasp == pasp.Substring(0, 4) && dr.NumberPasp == pasp.Substring(5, 6)).FirstOrDefault().Id;
        }

        public static DriverModel GetDriver()
        {

            return DbContext.db.Drivers.Where(dr => dr.Id == SecurityContext.CurrentDriver).FirstOrDefault();         

        }

    }
}
