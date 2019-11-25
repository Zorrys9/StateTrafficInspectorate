using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class CategoryTransport
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

    }
}
