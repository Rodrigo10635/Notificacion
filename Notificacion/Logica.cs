using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacion
{
    class Logica
    {
        public List<Usuario> Usuarios = new List<Usuario>();  // se crea una lista de usuarios


        /// <summary>
        /// 1.	Se pueden registrar usuarios que recibirán alertas. 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="correo"></param>
        public void crearUsuario (string nombre, string correo) // método para crear un usuario nuevo
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Correo = correo;
            Usuarios.Add(usuario);

        }

      
        
    }
}
