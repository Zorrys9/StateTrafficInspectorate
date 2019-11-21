namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Insurances
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insurances()
        {
            Drivers = new HashSet<Drivers>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Series { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public int IdTransport { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string PurposeOfUse { get; set; }

        [Column(TypeName = "date")]
        public DateTime InsurancesDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drivers> Drivers { get; set; }

        public virtual Transport Transport { get; set; }
    }
}
