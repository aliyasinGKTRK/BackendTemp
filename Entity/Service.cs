using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Service:BaseClass
    {
        [Key]
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceContent { get; set; }
        public string? ServiceIcon { get; set; }
        
    }
}
