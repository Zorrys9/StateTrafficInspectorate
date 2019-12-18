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
            license.Status = 1;

            var ListLicense = DbContext.db.License.Where(lic => lic.IdDriver == license.IdDriver);
            foreach(var License in ListLicense)
            {
                if (license.LicenseDate > License.LicenseDate && license.LicenseDate < License.ExpireDate)
                    throw new Exception("На данную дату уже зарегистрировано ВУ!");
            }
            if (license.LicenseDate > license.ExpireDate)
                throw new Exception("Дата регистрации должна быть меньше, чем дата истечения срока");
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
        public static bool CurrentDriver(string license)
        {
            var Query = DbContext.db.License.Where(lic => lic.LicenseSeries == license.Substring(0, 4) && lic.LicenseNumber == license.Substring(4, 6));
            if (Query.Count() == 1)
            {
                SecurityContext.CurrentDriver = Query.FirstOrDefault().IdDriver;
                return true;
            }
            else return false;

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
                           join category in DbContext.db.CategoryLicense on license.Id equals category.IdLicense
                           where driver.Id == SecurityContext.CurrentDriver
                           && (DateTime.Today > license.LicenseDate && DateTime.Today < license.ExpireDate)
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
                               driver.Photo,
                               category.M, category.Tb, category.Tm, category.DE, category.D1E, category.D1, category.D,category.CE, category.C1E, category.C1,
                               category.C, category.BE, category.B1, category.B, category.A1, category.A
                           }).FirstOrDefault();
            var Address = License.Address.Split();
            var AddressLife = License.AddressLife.Split();
            List<string> ListCategory = new List<string>();
            if (License.A) ListCategory.Add("A");
            if (License.A) ListCategory.Add("Tb");
            if (License.A) ListCategory.Add("Tm");
            if (License.A) ListCategory.Add("DE");
            if (License.A) ListCategory.Add("D1E");
            if (License.A) ListCategory.Add("D1");
            if (License.A) ListCategory.Add("D");
            if (License.A) ListCategory.Add("CE");
            if (License.A) ListCategory.Add("C1E");
            if (License.A) ListCategory.Add("C1");
            if (License.A) ListCategory.Add("C");
            if (License.A) ListCategory.Add("BE");
            if (License.A) ListCategory.Add("B1");
            if (License.A) ListCategory.Add("B");
            if (License.A) ListCategory.Add("A1");
            if (License.A) ListCategory.Add("M");

            string Category = "";

            for(int i = 0; i < ListCategory.Count; i++)
            {
                if (i < ListCategory.Count() - 1)
                    Category += ListCategory[i] + ", ";
                else
                    Category += ListCategory[i];
            }

            return new LicenseViewModel
            {
                FirstName = License.FirstName,
                LastNamePatr = License.LastNamePatr,
                DateBirth = License.DateBirth.ToShortDateString(),
                DateLicense = License.DateLicense.ToShortDateString(),
                DateExpire = License.DateExpire.ToShortDateString(),
                Address = Address[0].Substring(0,Address[0].Length - 1),
                AddressLife = AddressLife[0].Substring(0, AddressLife[0].Length - 1),
                Category = Category,
                SeriesNumberLicense = License.SeriesNumberLicense,
                Photo = License.Photo
            };
        }

    }
}
