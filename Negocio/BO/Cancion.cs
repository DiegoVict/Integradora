using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class Cancion
    {
        public Cancion()
        {
            Album id_album = new Album();
            Genero id_genero = new Genero();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string duracion { get; set; }
        public int numero { get; set; } // opcional
        public int reproducciones { get; set; } // agregado el 23 0702014 edwin
        public Album id_album { get; set; }
        public Genero id_genero { get; set; }
    }
}
