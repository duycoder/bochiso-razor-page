using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest1.Model
{
    public class BoChiSo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ten { get; set; }
    }
}
