using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class OT
    {
        [Key]
        public int Ot_id { get; set; }

        [Required]
        public string Ot_room_no { get; set; }
    }
}
