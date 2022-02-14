using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacion
{
    interface IObserverUsuario
    {
        void Actualizar( Tema t);
    }
}
