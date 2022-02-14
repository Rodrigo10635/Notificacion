using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacion
{
    class Tema :ISujetoTema //herencia
    {
        private List<IObserverUsuario> _usuarios;

        public Tema(string nombre)
        {
            _usuarios = new List<IObserverUsuario>();
            this.nombre = nombre;
        }

        public string nombre { get; set; }
        /// <summary>
        /// 3.	Los usuarios pueden optar sobre cuales temas quieren recibir alertas.
        /// </summary>
        /// <param name="usuario"></param>
        public void Agregar(IObserverUsuario usuario) 
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((Usuario)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach (IObserverUsuario usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripción para {((Usuario)usuario)}");
            }
        }
    }
}
