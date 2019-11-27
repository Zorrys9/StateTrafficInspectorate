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
    public class StatusChangeModel
    {

        public int PrevStatus { get; set; }

        public int CurrentStatus { get; set; }

        public int IdLicense { get; set; }

        public int IdInspector { get; set; }

        [Required]
        [StringLength(100)]
        public string Descriptoin { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateChange { get; set; }

        public static implicit operator HistoryStatusLicenseEntityModels(StatusChangeModel status)
        {
            return new HistoryStatusLicenseEntityModels
            {
                PrevStatus = status.PrevStatus,
                CurrentStatus = status.CurrentStatus,
                IdLicense = status.IdLicense,
                IdInspector = status.IdInspector,
                Descriptoin = status.Descriptoin,
                DateChange = status.DateChange
            };
        }
        public static implicit operator StatusChangeModel(HistoryStatusLicenseEntityModels status)
        {
            return new StatusChangeModel
            {
                PrevStatus = status.PrevStatus,
                CurrentStatus = status.CurrentStatus,
                IdLicense = status.IdLicense,
                IdInspector = status.IdInspector,
                Descriptoin = status.Descriptoin,
                DateChange = status.DateChange
            };
        }
    }
}
