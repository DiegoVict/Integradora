using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string correo { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string youtube { get; set; } // le agregue este
    }
}
