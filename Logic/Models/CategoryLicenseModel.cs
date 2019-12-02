using DataBase.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class CategoryLicenseModel
    {

        public bool M { get; set; }

        public bool A { get; set; }

        public bool A1 { get; set; }

        public bool B { get; set; }

        public bool BE { get; set; }

        public bool B1 { get; set; }

        public bool C { get; set; }

        public bool C1 { get; set; }

        public bool C1E { get; set; }

        public bool CE { get; set; }

        public bool D { get; set; }

        public bool D1 { get; set; }

        public bool D1E { get; set; }

        public bool DE { get; set; }

        public bool Tm { get; set; }

        public bool Tb { get; set; }
        public int IdLicense { get; set; }

        public static implicit operator CategoryLicenseEntityModels(CategoryLicenseModel category)
        {
            return new CategoryLicenseEntityModels()
            {
                A = category.A,
                A1 = category.A1,
                B = category.B,
                B1 = category.B1,
                BE = category.BE,
                C = category.C,
                C1 = category.C1,
                C1E = category.C1E,
                CE = category.CE,
                D = category.D,
                D1 = category.D1,
                D1E = category.D1E,
                DE = category.DE,
                M = category.M,
                Tb = category.Tb,
                Tm = category.Tm,
                IdLicense = category.IdLicense
            };
        }

        public static implicit operator CategoryLicenseModel(CategoryLicenseEntityModels category)
        {
            return new CategoryLicenseModel()
            {
                A = category.A,
                A1 = category.A1,
                B = category.B,
                B1 = category.B1,
                BE = category.BE,
                C = category.C,
                C1 = category.C1,
                C1E = category.C1E,
                CE = category.CE,
                D = category.D,
                D1 = category.D1,
                D1E = category.D1E,
                DE = category.DE,
                M = category.M,
                Tb = category.Tb,
                Tm = category.Tm,
                IdLicense = category.IdLicense
            };
        }

    }
}
