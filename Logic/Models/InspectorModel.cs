using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;

namespace Logic.Models
{
    public class InspectorModel
    {
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


        public static implicit operator InspectorEntityModel(InspectorModel inspector)
        {
            return new InspectorEntityModel
            {
                FirstName = inspector.FirstName,
                LastName = inspector.LastName,
                Patronymic = inspector.Patronymic,
                Login = inspector.Login,
                Password = inspector.Password,
                Position = inspector.Position,
            };
        }
        public static implicit operator InspectorModel(InspectorEntityModel inspector)
        {
            return new InspectorModel
            {
                FirstName = inspector.FirstName,
                LastName = inspector.LastName,
                Patronymic = inspector.Patronymic,
                Login = inspector.Login,
                Password = inspector.Password,
                Position = inspector.Position,
            };
        }
    }
}
