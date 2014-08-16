using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.BO
{
    public class EventoGaleria
    {
        public EventoGaleria()
        {
            Evento id_evento = new Evento();
        }

        public int id { get; set; }
        public string foto { get; set; }
        public Evento id_evento { get; set; }
    }
}
