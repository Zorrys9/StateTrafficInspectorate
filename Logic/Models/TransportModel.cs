using DataBase.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class TransportModel
    {

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

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
        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(17)]
        public string VIN { get; set; }

        public int TypeOfDrive { get; set; }

        public int IdDriver { get; set; }

        public static implicit operator TransportEntityModels(TransportModel transport)
        {
            return new TransportEntityModels
            {
                CategoryTransport = transport.CategoryTransport,
                Color = transport.Color,
                Description = transport.Description,
                IdDriver = transport.IdDriver,
                Manufacturer = transport.Manufacturer,
                MaxLoad = transport.MaxLoad,
                Model = transport.Model,
                ModelEngine = transport.ModelEngine,
                NumberEngine = transport.NumberEngine,
                PowerEngineH = transport.PowerEngineH,
                PowerEngineKVT = transport.PowerEngineKVT,
                VIN = transport.VIN,
                Weight = transport.Weight,
                YearEngine = transport.YearEngine,
                YearTransport = transport.YearTransport,
                TypeOfDrive = transport.TypeOfDrive
            };
        }
        public static implicit operator TransportModel(TransportEntityModels transport)
        {
            return new TransportModel
            {
                CategoryTransport = transport.CategoryTransport,
                Color = transport.Color,
                Description = transport.Description,
                IdDriver = transport.IdDriver,
                Manufacturer = transport.Manufacturer,
                MaxLoad = transport.MaxLoad,
                Model = transport.Model,
                ModelEngine = transport.ModelEngine,
                NumberEngine = transport.NumberEngine,
                PowerEngineH = transport.PowerEngineH,
                PowerEngineKVT = transport.PowerEngineKVT,
                VIN = transport.VIN,
                Weight = transport.Weight,
                YearEngine = transport.YearEngine,
                YearTransport = transport.YearTransport,
                TypeOfDrive = transport.TypeOfDrive
            };
        }
    }
}
