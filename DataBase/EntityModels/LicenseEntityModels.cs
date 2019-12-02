namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public class LicenseEntityModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LicenseEntityModels()
        {
            HistoryStatusLicense = new HashSet<HistoryStatusLicenseEntityModels>();
        }

        public int Id { get; set; }

        public int IdDriver { get; set; }

        public int IdTransport { get; set; }

        [Column(TypeName = "date")]
        public DateTime LicenseDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }

        [Required]
        [StringLength(4)]
        public string LicenseSeries { get; set; }
        [Required]
        [StringLength(8)]
        public string LicenseNumber { get; set; }

        public int? Status { get; set; }

        public int IdInspector { get; set; }

        public virtual DriversEntityModels Drivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryStatusLicenseEntityModels> HistoryStatusLicense { get; set; }

        public virtual StatusLicenseEntityModels StatusLicense { get; set; }

        public virtual TransportEntityModels Transport { get; set; }
    }
}
