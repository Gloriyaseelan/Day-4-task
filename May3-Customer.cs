using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdoMVC.Models
{
    public class Customer
    {
        [Key]
        //[Required]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
    }
}
