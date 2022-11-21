using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category:BaseClass
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        

        
    }
}
