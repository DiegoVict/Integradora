using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioEstandar:Usuario
    {
        public UsuarioEstandar()
        {
            UsuarioTipo id_tipo = new UsuarioTipo();
        }

        //public int id { get; set; }
        //public string usuario { get; set; }
        //public string contrasenia { get; set; }
        //public string correo { get; set; }
        //public string twitter { get; set; }
        //public string facebook { get; set; }
        //public string youtube { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string nacimiento { get; set; }
        public string sexo { get; set; }
        public UsuarioTipo id_tipo { get; set; }
        public string imagen { get; set; }
    }
}
