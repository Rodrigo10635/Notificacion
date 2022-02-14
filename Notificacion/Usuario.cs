using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacion
{

    
    class Usuario:IObserverUsuario
    {
        public string Nombre { get; set; }
        
        public string Correo { get; set; }

        /// <summary>
        /// 4.	Se puede enviar una alerta sobre un tema y lo reciben todos los usuarios que han optado recibir alertas de ese tema.
        /// </summary>
        /// <param name="t"></param>
        public void Actualizar(Tema t) //método para devolver notifiación
        {
            Console.WriteLine($"El usuario {this} Ha recibido una notificación del tema {t}");
        }
    }
}
