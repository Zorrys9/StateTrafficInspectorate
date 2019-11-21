namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drivers()
        {
            License = new HashSet<License>();
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

        [StringLength(50)]
        public string AddressCity { get; set; }

        [StringLength(100)]
        public string FullAddress { get; set; }

        [Required]
        [StringLength(10)]
        public string Telephone { get; set; }

        public int? DrivingExperience { get; set; }

        public int? InsuranceId { get; set; }

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

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [StringLength(50)]
        public string AddressLifeCity { get; set; }

        [StringLength(100)]
        public string FullAddressLife { get; set; }

        public virtual Insurances Insurances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<License> License { get; set; }
    }
}
