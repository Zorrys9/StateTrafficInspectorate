namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    
    [Table("Inspector")]
    public class InspectorEntityModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InspectorEntityModel()
        {
            HistoryStatusLicense = new HashSet<HistoryStatusLicenseEntityModels>();
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
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(4)]
        public string PasportSeries { get; set; }
        [Required]
        [StringLength(6)]
        public string PasportNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateBirth { get; set; }
        public int? Position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryStatusLicenseEntityModels> HistoryStatusLicense { get; set; }

        public virtual PositionEntityModels Position1 { get; set; }
    }
}
