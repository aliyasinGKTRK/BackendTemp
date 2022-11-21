using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product: BaseClass
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Price { get; set; }
        public string? Quantity { get; set; }
        public string? TumbDesc { get; set; }
        public string? TumbName { get; set; }
      
    }
}
