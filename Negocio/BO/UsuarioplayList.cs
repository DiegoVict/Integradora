using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class UsuarioplayList
    {
        public UsuarioplayList()
        {
            UsuarioEstandar id_usuario = new UsuarioEstandar();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public UsuarioEstandar id_usuario { get; set; }
    }
}
