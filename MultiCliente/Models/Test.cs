﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiCliente.Models
{
    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public string Nombre { get; set; }
    }
}
