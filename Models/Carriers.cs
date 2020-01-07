using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Carriers
    {
       [Key]
       public int Cr_id { get; set; }

        [Required]
       public string Cr_name { get; set; }

        [Required]
        public string MOB { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Salary { get; set; }
    }
}
