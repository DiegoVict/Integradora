using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioContacto
    {
        public UsuarioContacto()
        {
            id_usuario = new UsuarioArtistaOrganizador();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido_pat { get; set; }
        public string apellido_mat { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string rfc { get; set; }
        public string descripcion { get; set; }
        public UsuarioArtistaOrganizador id_usuario { get; set; }
    }
}
