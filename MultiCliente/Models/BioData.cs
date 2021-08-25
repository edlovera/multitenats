using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCliente.Models
{
    public class BioData
    {
        [Key]
        public int BioDataID { get; set; }
        public int Index { get; set; }
        public string Tmp { get; set; }
    }
}
