using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Referance:BaseClass
    {
        [Key]
        public int ReferanceId { get; set; }
        public string? ReferanceName { get; set; }
        public string? ImagePath { get; set; }

    }
}
