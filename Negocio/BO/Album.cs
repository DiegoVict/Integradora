using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class Album
    {
        public Album()
        {
            UsuarioArtistaOrganizador id_artista = new UsuarioArtistaOrganizador();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime anio { get; set; }
        public int pistas { get; set; }
        public string imagen { get; set; }
        public UsuarioArtistaOrganizador id_artista { get; set; }
    }
}
