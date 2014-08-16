using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioArtistaSeguir
    {
        public UsuarioArtistaSeguir()
        {
            id_usuario_estandar = new UsuarioEstandar();
            id_usuario_artista = new UsuarioArtistaOrganizador();
        }

        public int id { get; set; }
        public UsuarioEstandar id_usuario_estandar { get; set; }
        public UsuarioArtistaOrganizador id_usuario_artista { get; set; }
    }
}
