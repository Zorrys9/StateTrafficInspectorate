using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;
using Logic.ViewModels;
namespace Logic.LogicsModel
{
    public class LogicTransport
    {

        public static void SaveTransport(TransportModel newTransport)
        {
            if (OtherLogic.LogicVIN.CheckVIN(newTransport.VIN))
            {
                if (CheckVIN(newTransport.VIN))
                {
                    DbContext.db.Transport.Add(newTransport);
                    DbContext.db.SaveChanges();
                }
                else throw new Exception("Транспорт с таким VIN кодом уже зарегистрирован!");
            }
            else throw new Exception("VIN код введен не верно!");
        }

        public static DataTable GetFilterListTransport(string name)
        {
            DataTable dtTransport = new DataTable();
            dtTransport.Columns.Add("ФИО водителя");
            dtTransport.Columns.Add("Марка");
            dtTransport.Columns.Add("Привод");
            dtTransport.Columns.Add("Год производства");
            dtTransport.Columns.Add("VIN");
            dtTransport.Columns.Add("Цвет");
            string LastName = "";
            string Patronymic = "";
            string[] NameArray = name.Split(' ');
            if (NameArray.Length <= 3)
            {
                string FirstName = NameArray[0];
                if (NameArray.Length > 1) LastName = NameArray[1];
                if (NameArray.Length > 2) Patronymic = NameArray[2];

                var Query = from transport in DbContext.db.Transport
                            join driver in DbContext.db.Drivers on transport.IdDriver equals driver.Id
                            join type in DbContext.db.TypeOfDrive on transport.TypeOfDrive equals type.Id
                            where (driver.FirstName.Contains(FirstName) || driver.LastName.Contains(FirstName) || driver.Patronymic.Contains(FirstName))
                            && (driver.FirstName.Contains(LastName) || driver.LastName.Contains(LastName) || driver.Patronymic.Contains(LastName))
                            && (driver.FirstName.Contains(Patronymic) || driver.LastName.Contains(Patronymic) || driver.Patronymic.Contains(Patronymic))
                            select new
                            {
                                NameDriver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                                transport.Manufacturer,
                                transport.VIN,
                                transport.YearTransport,
                                TypeOfDrive = type.Name,
                                transport.Color
                            };
                foreach (var transport in Query)
                {
                    dtTransport.Rows.Add(transport.NameDriver, transport.Manufacturer, transport.TypeOfDrive, transport.YearTransport, transport.VIN, transport.Color);
                }
            }
            return dtTransport;
        }
        public static void ChangeDriver(string passport)
        {
            var IdNextDriver = DbContext.db.Drivers.Where(dr => dr.SerialPasp == passport.Substring(0, 4) && dr.NumberPasp == passport.Substring(4, 6)).FirstOrDefault().Id;
            var Transport = DbContext.db.Transport.Find(SecurityContext.CurrentTransport);
            Transport.IdDriver = IdNextDriver;
            DbContext.db.Transport.Create();
            DbContext.db.SaveChanges();
        }
        
        public static void CurrentTransport(string VIN)
        {
            SecurityContext.CurrentTransport = DbContext.db.Transport.Where(tr => tr.VIN == VIN).FirstOrDefault().Id;
        }

       
        public static TransportModel GetCurrentTransport()
        {
            return DbContext.db.Transport.Where(tr => tr.Id == SecurityContext.CurrentTransport).FirstOrDefault();
        }
        public static DataTable GetTransportList()
        {
            DataTable dtTransport = new DataTable();
            dtTransport.Columns.Add("ФИО водителя");
            dtTransport.Columns.Add("Марка");
            dtTransport.Columns.Add("Привод");
            dtTransport.Columns.Add("Год производства");
            dtTransport.Columns.Add("VIN");
            dtTransport.Columns.Add("Цвет");

            var Query = from transport in DbContext.db.Transport
                        join driver in DbContext.db.Drivers on transport.IdDriver equals driver.Id
                        join type in DbContext.db.TypeOfDrive on transport.TypeOfDrive equals type.Id
                        select new
                        {
                            NameDriver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            transport.Manufacturer,
                            transport.VIN,
                            transport.YearTransport,
                            TypeOfDrive = type.Name,
                            transport.Color
                        };
            foreach(var transport in Query)
            {
                dtTransport.Rows.Add(transport.NameDriver, transport.Manufacturer, transport.TypeOfDrive, transport.YearTransport, transport.VIN,transport.Color);
            }
            return dtTransport;
        }

        public static DataTable GetTransportListCurrentDriver()
        {
            DataTable dtTransport = new DataTable();
            dtTransport.Columns.Add("ФИО водителя");
            dtTransport.Columns.Add("Марка");
            dtTransport.Columns.Add("Привод");
            dtTransport.Columns.Add("Год производства");
            dtTransport.Columns.Add("VIN");

            var Query = from transport in DbContext.db.Transport
                        join driver in DbContext.db.Drivers on transport.IdDriver equals driver.Id where driver.Id == SecurityContext.CurrentDriver
                        join type in DbContext.db.TypeOfDrive on transport.TypeOfDrive equals type.Id
                        select new
                        {
                            NameDriver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            transport.Manufacturer,
                            transport.VIN,
                            transport.YearTransport,
                            TypeOfDrive = type.Name
                        };
            foreach (var transport in Query)
            {
                dtTransport.Rows.Add(transport.NameDriver, transport.Manufacturer, transport.TypeOfDrive, transport.YearTransport, transport.VIN);
            }
            return dtTransport;
        }

        public static int GetIdByVIN(string vin)
        {
            var id = DbContext.db.Transport.Where(tr => tr.VIN == vin);
            if (id.Count() == 1)
                return id.FirstOrDefault().Id;
            else return 0;
        }
        public static int GetIdDriverByVIN(string vin)
        {
            var id = DbContext.db.Transport.Where(tr => tr.VIN == vin);
            if (id.Count() == 1)
                return id.FirstOrDefault().IdDriver;
            else return 0;
        }
        public static void DeleteTransport()
        {
            DbContext.db.Transport.Remove(DbContext.db.Transport.Find(SecurityContext.CurrentTransport));
            DbContext.db.SaveChanges();
        }

        static bool CheckVIN(string VIN)
        {
            if (DbContext.db.Transport.Where(tr => tr.VIN == VIN).Count() > 0)
                return false;
            else return true;
        }
        public static void ChangeTransport(TransportModel transport)
        {
            var CurrentTransport = DbContext.db.Transport.Find(SecurityContext.CurrentTransport);
            CurrentTransport.Manufacturer = transport.Manufacturer;
            CurrentTransport.Model = transport.Model;
            CurrentTransport.CategoryTransport = transport.CategoryTransport;
            CurrentTransport.YearTransport = transport.YearTransport;
            CurrentTransport.NumberEngine = transport.NumberEngine;
            CurrentTransport.ModelEngine = transport.ModelEngine;
            CurrentTransport.YearEngine = transport.YearEngine;
            CurrentTransport.PowerEngineH = transport.PowerEngineH;
            CurrentTransport.PowerEngineKVT = transport.PowerEngineKVT;
            CurrentTransport.MaxLoad = transport.MaxLoad;
            CurrentTransport.Color = transport.Color;
            CurrentTransport.Weight = transport.Weight;
            CurrentTransport.VIN = transport.VIN;
            CurrentTransport.Description = transport.Description;
            CurrentTransport.TypeOfDrive = transport.TypeOfDrive;
            DbContext.db.Transport.Create();
            DbContext.db.SaveChanges();
        }
    }
}
