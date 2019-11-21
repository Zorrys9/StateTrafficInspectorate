namespace DataBase.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryStatusLicense")]
    public partial class HistoryStatusLicense
    {
        public int Id { get; set; }

        public int PrevStatus { get; set; }

        public int CurrentStatus { get; set; }

        public int IdLicense { get; set; }

        public int IdInspector { get; set; }

        [Required]
        [StringLength(100)]
        public string Descriptoin { get; set; }

        public virtual Inspector Inspector { get; set; }

        public virtual License License { get; set; }

        public virtual StatusLicense StatusLicense { get; set; }

        public virtual StatusLicense StatusLicense1 { get; set; }
    }
}
