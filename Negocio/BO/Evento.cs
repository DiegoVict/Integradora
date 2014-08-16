using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class Evento
    {
        public Evento()
        {
            id_organizador = new UsuarioArtistaOrganizador();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string direccion { get; set; }
        public DateTime fecha { get; set; }
        public string enlace { get; set; }
        public string imagen { get; set; }
        public UsuarioArtistaOrganizador id_organizador { get; set; }
    }
}
