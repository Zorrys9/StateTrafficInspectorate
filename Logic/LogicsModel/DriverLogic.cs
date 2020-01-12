using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.ViewModels;
using Logic.Models;
using System.Text.RegularExpressions;
using DataBase.EntityModels;
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
            var ListDriver = DbContext.db.Drivers.Where( dr=> dr != null);
            if (SecurityContext.CurrentTransport != 0)
            {
                int idDriver = DbContext.db.Transport.Find(SecurityContext.CurrentTransport).IdDriver;
                ListDriver = ListDriver.Where(driver => driver.Id == idDriver);
            }
            foreach (var driver in ListDriver)
            {
                driverView = driver;
                dt.Rows.Add(driverView.Name, driverView.DateBirth.ToShortDateString(), driverView.Passport, driverView.FullAddress, driverView.Telephone, driverView.DrivingExperience, driverView.Email);
            }
            return dt;
        }

        public static DataTable GetFilterListDrivers(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Дата рождения");
            dt.Columns.Add("Паспорт");
            dt.Columns.Add("Адрес");
            dt.Columns.Add("Телефон");
            dt.Columns.Add("Водительский стаж");
            dt.Columns.Add("Email");
            string LastName = "";
            string Patronymic = "";
            string[] NameArray = name.Split(' ');
            if(NameArray.Length <= 3)
            {
                string FirstName = NameArray[0];
                if (NameArray.Length > 1) LastName = NameArray[1];
                if (NameArray.Length > 2) Patronymic = NameArray[2];

                DriverViewModel driverView;
                var ListDriver = from driver in DbContext.db.Drivers
                                 where (driver.FirstName.Contains(FirstName) || driver.LastName.Contains(FirstName) || driver.Patronymic.Contains(FirstName))
                                 && (driver.FirstName.Contains(LastName) || driver.LastName.Contains(LastName) || driver.Patronymic.Contains(LastName))
                                 && (driver.FirstName.Contains(Patronymic) || driver.LastName.Contains(Patronymic) || driver.Patronymic.Contains(Patronymic))
                                 select driver;
                if (SecurityContext.CurrentTransport != 0)
                {
                    int idDriver = DbContext.db.Transport.Find(SecurityContext.CurrentTransport).IdDriver;
                    ListDriver = ListDriver.Where(driver => driver.Id == idDriver);
                }
                foreach (var driver in ListDriver)
                {
                    driverView = driver;
                    dt.Rows.Add(driverView.Name, driverView.DateBirth.ToShortDateString(), driverView.Passport, driverView.FullAddress, driverView.Telephone, driverView.DrivingExperience, driverView.Email);
                }
            }


            return dt;
        }
        public static void DeleteDriver()
        {
            DbContext.db.Drivers.Remove(DbContext.db.Drivers.Where(dr => dr.Id == SecurityContext.CurrentDriver).FirstOrDefault());
            DbContext.db.SaveChanges();
            SecurityContext.CurrentDriver = 0;
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
            SecurityContext.CurrentDriver = DbContext.db.Drivers.Where(dr => dr.SerialPasp == pasp.Substring(0, 4) && dr.NumberPasp == pasp.Substring(4, 6)).FirstOrDefault().Id;
        }
        public static void ClearCurrentDriver()
        {
            SecurityContext.CurrentDriver = 0;
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

        public static void ChangeDriver(DriverModel driver)
        {
            DriversEntityModels CurrentDriver = DbContext.db.Drivers.Find(SecurityContext.CurrentDriver);
            CurrentDriver.FirstName = driver.FirstName;
            CurrentDriver.LastName = driver.LastName;
            CurrentDriver.Patronymic = driver.Patronymic;
            CurrentDriver.Telephone = "+7" + CheckPhone(driver.Telephone.Substring(2,10));
            CurrentDriver.Email = CheckEmail(driver.Email);
            CurrentDriver.SerialPasp = driver.SerialPasp;
            CurrentDriver.NumberPasp = driver.NumberPasp;
            CurrentDriver.DateBirth = driver.DateBirth;
            CurrentDriver.DrivingExperience = driver.DrivingExperience;
            CurrentDriver.FullAddress = driver.FullAddress;
            CurrentDriver.FullAddressLife = driver.FullAddressLife;
            CurrentDriver.PostCode = driver.PostCode;
            CurrentDriver.Company = driver.Company;
            CurrentDriver.JobName = driver.JobName;
            CurrentDriver.Photo = driver.Photo;
            DbContext.db.Drivers.Create();
            DbContext.db.SaveChanges();
            SecurityContext.CurrentDriver = 0;
        }

        public static DataTable GetListFine(string pasport)
        {
            DataTable dtFine = new DataTable();
            dtFine.Columns.Add("ФИО водителя");
            dtFine.Columns.Add("Сумма штрафа");
            dtFine.Columns.Add("Причина штрафа");
            dtFine.Columns.Add("Дата штрафования");
            dtFine.Columns.Add("Инспектор");


            var query = from fine in DbContext.db.FIne
                        join driver in DbContext.db.Drivers on fine.IdDriver equals driver.Id
                        join inspector in DbContext.db.Inspector on fine.IdInspector equals inspector.Id
                        where driver.SerialPasp == pasport.Substring(0, 4) && driver.NumberPasp == pasport.Substring(4, 6)
                        select new
                        {
                            Driver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            fine.Sum,
                            fine.Description,
                            fine.FineDate,
                            Inspector = inspector.FirstName + " " + inspector.LastName + " " + inspector.Patronymic
                        };
            foreach (var fine in query)
            {
                dtFine.Rows.Add(fine.Driver, fine.Sum, fine.Description, fine.FineDate.ToShortDateString(), fine.Inspector);
            }
            return dtFine;
        }

        public static DataTable GetReportList()
        {
            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("ФИО водителя");
            dtReport.Columns.Add("Паспорт");
            dtReport.Columns.Add("Дата рождения");
            dtReport.Columns.Add("Водительский стаж");
            dtReport.Columns.Add("Количество автомобилей");
            dtReport.Columns.Add("Количество штрафов");


            var query = DbContext.db.Drivers.OrderBy(dr => dr.FirstName).ToList();
            

            foreach (var driver in query)
            {
                var countTransport = DbContext.db.Transport.Where(tr => tr.IdDriver == driver.Id);
                var countFine = DbContext.db.FIne.Where(fine => fine.IdDriver == driver.Id);
                dtReport.Rows.Add(driver.FirstName + " " + driver.LastName + " " + driver.Patronymic, driver.SerialPasp + " " + driver.NumberPasp, driver.DateBirth, driver.DrivingExperience, countTransport.Count(), countFine.Count());
            }

            return dtReport;
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
