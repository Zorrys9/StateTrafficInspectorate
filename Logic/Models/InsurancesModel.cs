using DataBase.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class InsurancesModel
    {

        [Required]
        [StringLength(10)]
        public string Series { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public int IdTransport { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime InsurancesDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }
        public double Sum { get; set; }

        public static implicit operator InsurancesEntityModels(InsurancesModel insurances)
        {
            return new InsurancesEntityModels
            {
                Series = insurances.Series,
                Number = insurances.Number,
                IdTransport = insurances.IdTransport,
                Type = insurances.Type,
                InsurancesDate = insurances.InsurancesDate,
                ExpireDate = insurances.ExpireDate
            };
        }

        public static implicit operator InsurancesModel(InsurancesEntityModels insurances)
        {
            return new InsurancesModel
            {
                Series = insurances.Series,
                Number = insurances.Number,
                IdTransport = insurances.IdTransport,
                Type = insurances.Type,
                InsurancesDate = insurances.InsurancesDate,
                ExpireDate = insurances.ExpireDate
            };
        }
    }
}
