namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Insurances")]
    public class InsurancesEntityModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsurancesEntityModels()
        {
        }

        public int Id { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual TransportEntityModels Transport { get; set; }
    }
}
