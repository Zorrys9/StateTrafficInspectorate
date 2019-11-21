namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transport")]
    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            Insurances = new HashSet<Insurances>();
            License = new HashSet<License>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int TypeTransport { get; set; }

        public int CategoryTransport { get; set; }

        [Required]
        [StringLength(4)]
        public string YearTransport { get; set; }

        [Required]
        [StringLength(10)]
        public string NumberEngine { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelEngine { get; set; }

        [Required]
        [StringLength(4)]
        public string YearEngine { get; set; }

        [Required]
        [StringLength(10)]
        public string PowerEngineKVT { get; set; }

        [Required]
        [StringLength(10)]
        public string PowerEngineH { get; set; }

        public double MaxLoad { get; set; }

        public double Weight { get; set; }

        public int TypeEngine { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(17)]
        public string VIN { get; set; }

        public int TypeOfDrive { get; set; }

        public int IdDriver { get; set; }

        public virtual CategoryTransport CategoryTransport1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Insurances> Insurances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<License> License { get; set; }

        public virtual TypeOfDrive TypeOfDrive1 { get; set; }

        public virtual TypeTransport TypeTransport1 { get; set; }
    }
}
