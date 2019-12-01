using Logic.Models;
using Logic.ViewModels;
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

        public static LicenseViewModel GetLicenseModel()
        {
            var License = (from license in DbContext.db.License
                           join driver in DbContext.db.Drivers on license.IdDriver equals driver.Id
                           where driver.Id == SecurityContext.CurrentDriver
                           select new
                           {
                               driver.FirstName,
                               LastNamePatr = driver.LastName + " " + driver.Patronymic,
                               driver.DateBirth,
                               AddressLife = driver.FullAddressLife,
                               DateLicense = license.LicenseDate,
                               DateExpire = license.ExpireDate,
                               SeriesNumberLicense = license.LicenseSeries.Substring(0, 2) + " " + license.LicenseSeries.Substring(2, 2) + " " + license.LicenseNumber,
                               Address = driver.FullAddress,
                               Category = license.Categories,
                               driver.Photo
                           }).FirstOrDefault();
            var Address = License.Address.Split();
            var AddressLife = License.AddressLife.Split();
            return new LicenseViewModel
            {
                FirstName = License.FirstName,
                LastNamePatr = License.LastNamePatr,
                DateBirth = License.DateBirth.ToShortDateString(),
                DateLicense = License.DateLicense.ToShortDateString(),
                DateExpire = License.DateExpire.ToShortDateString(),
                Address = Address[0].Substring(0,Address[0].Length - 1),
                AddressLife = AddressLife[0].Substring(0, AddressLife[0].Length - 1),
                Category = License.Category,
                SeriesNumberLicense = License.SeriesNumberLicense,
                Photo = License.Photo
            };
        }

    }
}
