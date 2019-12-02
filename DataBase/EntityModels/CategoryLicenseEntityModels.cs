namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryLicense")]
    public class CategoryLicenseEntityModels
    {
        public int Id { get; set; }

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
    }
}
