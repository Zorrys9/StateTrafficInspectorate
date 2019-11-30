namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FIne")]
    public partial class FIneEntityModels
    {
        public int Id { get; set; }

        public int? IdDriver { get; set; }

        public double? Sum { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
