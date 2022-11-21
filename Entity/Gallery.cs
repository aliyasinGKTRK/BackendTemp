using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gallery:BaseClass
    {
        [Key]
        public int GalleryId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
