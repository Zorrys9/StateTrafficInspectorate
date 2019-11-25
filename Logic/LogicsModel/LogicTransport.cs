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
            DbContext.db.Transport.Add(newTransport);
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

            var Query = from transport in DbContext.db.Transport
                        join driver in DbContext.db.Drivers on transport.IdDriver equals driver.Id
                        join type in DbContext.db.TypeOfDrive on transport.TypeOfDrive equals type.Id
                        select new
                        {
                            NameDriver = driver.FirstName + " " + driver.LastName + " " + driver.Patronymic,
                            transport.Manufacturer,
                            transport.VIN,
                            transport.YearTransport,
                            TypeOfDrive = type.Name
                        };
            foreach(var transport in Query)
            {
                dtTransport.Rows.Add(transport.NameDriver, transport.Manufacturer, transport.TypeOfDrive, transport.YearTransport, transport.VIN);
            }
            return dtTransport;
        }
    }
}
