using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public static implicit operator FIneEntityModels(FineModel fine)
        {
            return new FIneEntityModels
            {
                IdDriver = fine.IdDriver,
                Sum = fine.Sum,
                Description = fine.Description
            };
        }
    }
}
