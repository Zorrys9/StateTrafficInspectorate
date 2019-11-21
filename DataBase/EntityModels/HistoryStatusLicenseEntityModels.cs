namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryStatusLicense")]
    public class HistoryStatusLicenseEntityModels
    {
        public int Id { get; set; }

        public int PrevStatus { get; set; }

        public int CurrentStatus { get; set; }

        public int IdLicense { get; set; }

        public int IdInspector { get; set; }

        [Required]
        [StringLength(100)]
        public string Descriptoin { get; set; }

        public virtual InspectorEntityModel Inspector { get; set; }

        public virtual LicenseEntityModels License { get; set; }

        public virtual StatusLicenseEntityModels StatusLicense { get; set; }

        public virtual StatusLicenseEntityModels StatusLicense1 { get; set; }
    }
}
