using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.LogicsModel
{
    public class LogicLicense
    {

        public static void SaveLicense(LicenseModel license)
        {
            license.IdInspector = SecurityContext.IdUser;
            DbContext.db.License.Add(license);
            DbContext.db.SaveChanges();
        }
        public static bool CheckLicense(string license)
        {
            var Query = DbContext.db.License.Where(lic => lic.LicenseSeries == license.Substring(0, 4) && lic.LicenseNumber == license.Substring(4, 6));
            if (Query.Count() > 0)
                return true;
            else return false;
        }
        public static int GetId(string license)
        {
            var Query = DbContext.db.License.Where(lic => lic.LicenseSeries == license.Substring(0, 4) && lic.LicenseNumber == license.Substring(4, 6));
            if (Query.Count() > 0)
                return Query.FirstOrDefault().Id;
            else return 0;
        }
        public static int GetIdDriver(string license)
        {
            var Query = DbContext.db.License.Where(lic => lic.LicenseSeries == license.Substring(0, 4) && lic.LicenseNumber == license.Substring(4, 6));
            return Query.FirstOrDefault().IdDriver;
        }
        public static void ChangeStatusLicense(StatusChangeModel newStatus)
        {

            var License = DbContext.db.License.Find(newStatus.IdLicense);
            newStatus.PrevStatus = License.Status.Value;
            License.Status = newStatus.CurrentStatus;
            newStatus.IdInspector = SecurityContext.IdUser;

            DbContext.db.License.Create();
            DbContext.db.HistoryStatusLicense.Add(newStatus);
            DbContext.db.SaveChanges();

        }

    }
}
