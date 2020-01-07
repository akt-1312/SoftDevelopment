using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Room
    {
        [Key]
        public int Room_id { get; set; }

        [Required]
        public string Room_No { get; set; }

        [Required]
        public string Room_type { get; set; }

        [Required]
        public string Room_cost { get; set; }
    }
}
