using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int? Position { get; set; }


        public static implicit operator Inspector(InspectorModel inspector)
        {
            return new Inspector
            {
                FirstName = inspector.FirstName,
                LastName = inspector.LastName,
                Patronymic = inspector.Patronymic,
                Login = inspector.Login,
                Password = inspector.Password,
                Position = inspector.Position,
            };
        }
        public static implicit operator InspectorModel(Inspector inspector)
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
