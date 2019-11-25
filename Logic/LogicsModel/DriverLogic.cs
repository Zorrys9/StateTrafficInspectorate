using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.ViewModels;
using Logic.Models;
using System.Text.RegularExpressions;

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

            DriverViewModel driverView;
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
            newDriver.Telephone = "+7" + CheckPhone(newDriver.Telephone);
            newDriver.Email = CheckEmail(newDriver.Email);
            DbContext.db.Drivers.Add(newDriver);
            DbContext.db.SaveChanges();
        }

        public static void CurrentDriver(string pasp)
        {
            SecurityContext.CurrentDriver = DbContext.db.Drivers.Where(dr => dr.SerialPasp == pasp.Substring(0, 4) && dr.NumberPasp == pasp.Substring(5, 6)).FirstOrDefault().Id;
        }

        public static DriverViewModel GetCurrentDriver()
        {
            return DbContext.db.Drivers.Where(dr => dr.Id == SecurityContext.CurrentDriver).FirstOrDefault();         
        }

        public static int GetIdByPassport(string passport)
        {
            var id = DbContext.db.Drivers.Where(dr => dr.SerialPasp == passport.Substring(0, 4) && dr.NumberPasp == passport.Substring(4, 6));
            if (id.Count() > 0)
                return id.FirstOrDefault().Id;
            else return 0;
        }

        static string CheckPhone(string phone)
        {
            Regex regexPhone = new Regex(@"^[0-9]+$");
            if (regexPhone.IsMatch(phone) && phone.Length == 10)
                return phone;
            else throw new Exception("Телефон введен не верно!");
        }
        static string CheckEmail(string email)
        {
            Regex regexMail = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
            if (regexMail.IsMatch(email))
                return email;
            else throw new Exception("Email введен не верно!");
        }

    }
}
