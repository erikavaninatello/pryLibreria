﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFinal
{
    public class clsUser
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int IntentosFallidos { get; set; }
        public bool Bloqueado { get; set; }

    }
}
