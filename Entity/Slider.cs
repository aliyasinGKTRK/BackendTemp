using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Slider:BaseClass
    {
        public int SliderId { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

    }
}
