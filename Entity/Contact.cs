using Entity.BaseProperty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contact:BaseClass
    {
        [Key]
        public int ContactId { get; set; }
        public string? ContactTitle { get; set; }
        public string? Content  { get; set; }
        public string?  CompanyNumber { get; set; }
        public string? CompanyNumberTwo { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyAddressTwo { get; set; }
        public string? CompanyMail { get; set; }
        public string? CompanyMailTwo { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerMail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
