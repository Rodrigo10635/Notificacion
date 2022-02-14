using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacion
{
    public enum ETipo
    {
        Informativa = 1,
        Urgente = 2
        
    }

    class Alerta // se crea la clase alerta con sus atributos
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string NotiCabecera { get; set; }

        public string NotiCuerpo { get; set; }

        public string mensaje { get; set; }
        public ETipo tipo { get; set; }        

        public bool leido { get; set; } = false;
    }
}
