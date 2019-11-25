using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ViewModels
{
    public class TransportViewModel
    {


        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(4)]
        public string YearTransport { get; set; }

        [Required]
        [StringLength(17)]
        public string VIN { get; set; }

        public string TypeOfDrive { get; set; }

        public string NameDriver { get; set; }

    }
}
