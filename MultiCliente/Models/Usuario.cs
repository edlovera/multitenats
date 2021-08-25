using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCliente.Models
{
    public class Usuario
    {
        [Key]
        public int UserID { get; set; }
        public int Uid { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo caracteres 50")]
        public string CardNo { get; set; }
        public int Pin { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo caracteres 50")]
        public string Password { get; set; }
        public int Group { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo caracteres 50")]
        public string StartTime { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo caracteres 50")]
        public string EndTime { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo caracteres 100")]
        public string Name { get; set; }
        public int Privilege { get; set; }
        public int Disable { get; set; }
        public int Verify { get; set; }
    }
}
