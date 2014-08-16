using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioArtistaOrganizador:Usuario
    {
        public UsuarioArtistaOrganizador()
        {
             id_genero = new Genero();
             id_tipo = new UsuarioTipo();
        }

        //public int id { get; set; }
        //public string usuario { get; set; }
        //public string contrasenia { get; set; }
        //public string correo { get; set; }
        //public string twitter { get; set; }
        //public string facebook { get; set; }
        //public string youtube { get; set; }
        public string imagen { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public UsuarioTipo id_tipo { get; set; } // aqui se debio haber usado una tabla
        public Genero id_genero { get; set; }
    }
}
