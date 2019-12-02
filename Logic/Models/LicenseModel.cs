using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;

namespace Logic.Models
{
    public class LicenseModel
    {

        public int IdDriver { get; set; }

        public int IdTransport { get; set; }

        [Column(TypeName = "date")]
        public DateTime LicenseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }


        [Required]
        [StringLength(5)]
        public string LicenseSeries { get; set; }

        [Required]
        [StringLength(8)]
        public string LicenseNumber { get; set; }

        public int? Status { get; set; }

        public int IdInspector { get; set; }

        public static implicit operator LicenseEntityModels(LicenseModel license)
        {
            return new LicenseEntityModels
            {
                IdDriver = license.IdDriver,
                ExpireDate = license.ExpireDate,
                LicenseDate = license.LicenseDate,
                IdTransport = license.IdTransport,
                IdInspector = license.IdInspector,
                LicenseSeries = license.LicenseSeries,
                LicenseNumber = license.LicenseNumber,
                Status = license.Status
            };
        }

        public static implicit operator LicenseModel(LicenseEntityModels license)
        {
            return new LicenseModel
            {
                IdDriver = license.IdDriver,
                ExpireDate = license.ExpireDate,
                LicenseDate = license.LicenseDate,
                IdTransport = license.IdTransport,
                IdInspector = license.IdInspector,
                LicenseSeries = license.LicenseSeries,
                LicenseNumber = license.LicenseNumber,
                Status = license.Status
            };
        }
    }
}
