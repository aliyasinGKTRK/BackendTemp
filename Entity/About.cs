using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class About :BaseClass
    {
        [Key]
        public int AboutId { get; set; }
        public string? AboutTitle { get; set; }
        public string? Description { get; set; }


      
    }
}
