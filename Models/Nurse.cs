using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Nurse
    {
        [Key]
        public int Nrs_id { get; set; }

        [Required]
        public string Nrs_name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Nrs_Wo_Shift { get; set; }

        [Required]
        public string Experience { get; set; }

        [Required]
        public string Salary { get; set; }
    }
}
