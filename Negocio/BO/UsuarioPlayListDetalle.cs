using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioPlayListDetalle
    {
        public UsuarioPlayListDetalle()
        {
            Cancion id_cancion = new Cancion();
            UsuarioplayList id_playList = new UsuarioplayList();
        }

        public int id { get; set; }
        public Cancion id_cancion { get; set; }
        public UsuarioplayList id_playList { get; set; }
    }
}
