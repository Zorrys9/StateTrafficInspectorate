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
    public class FineModel
    {

        public int? IdDriver { get; set; }

        public double? Sum { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int IdInspector { get; set; }
        [Column(TypeName = "date")]
        public DateTime FineDate { get; set; }

        public static implicit operator FIneEntityModels(FineModel fine)
        {
            return new FIneEntityModels
            {
                IdDriver = fine.IdDriver,
                Sum = fine.Sum,
                Description = fine.Description,
                IdInspector = fine.IdInspector,
                FineDate = fine.FineDate
            };
        }
        public static implicit operator FineModel(FIneEntityModels fine)
        {
            return new FineModel
            {
                IdDriver = fine.IdDriver,
                Sum = fine.Sum,
                Description = fine.Description,
                IdInspector = fine.IdInspector,
                FineDate = fine.FineDate
            };
        }
    }
}
