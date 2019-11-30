namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Drivers")]
    public class DriversEntityModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DriversEntityModels()
        {
            License = new HashSet<LicenseEntityModels>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(4)]
        public string SerialPasp { get; set; }

        [Required]
        [StringLength(6)]
        public string NumberPasp { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateBirth { get; set; }

        [StringLength(100)]
        public string FullAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string Telephone { get; set; }

        public int? DrivingExperience { get; set; }

        public int PostCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string JobName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        public byte[] Photo { get; set; }

        [StringLength(100)]
        public string FullAddressLife { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LicenseEntityModels> License { get; set; }
    }
}
