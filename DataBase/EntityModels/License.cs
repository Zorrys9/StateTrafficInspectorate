namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public License()
        {
            HistoryStatusLicense = new HashSet<HistoryStatusLicense>();
        }

        public int Id { get; set; }

        public int IdDriver { get; set; }

        public int IdTransport { get; set; }

        [Column(TypeName = "date")]
        public DateTime LicenseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Categories { get; set; }

        [Required]
        [StringLength(5)]
        public string LicenseSeries { get; set; }

        [Required]
        [StringLength(8)]
        public string LicenseNumber { get; set; }

        public int? Status { get; set; }

        public int IdInspector { get; set; }

        public virtual Drivers Drivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryStatusLicense> HistoryStatusLicense { get; set; }

        public virtual StatusLicense StatusLicense { get; set; }

        public virtual Transport Transport { get; set; }
    }
}
