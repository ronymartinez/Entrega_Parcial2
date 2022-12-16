using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la lista principal de usuarios
    /// </summary>
    public static class ListaUsuarios
    {
        private static List<Usuario> listaUsuarios;
        static ListaUsuarios()
        {
            listaUsuarios = new List<Usuario>();
        }
       
        /// <summary>
        /// Se agrega un usuario a la lista principal
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns> Devuelve true si se pudo agregar el profesor a la lista </returns>
        public static bool AgregarUsuario(Usuario usuario)
        {
            bool retorno = false;

            if (usuario != null)
            {
                retorno = true;
                foreach (var item in listaUsuarios)
                {
                    if(item.NombreUsuario == usuario.NombreUsuario)
                    {
                        retorno = false;
                        break;
                    }
                } 
            }
            if(retorno == true)
            {
                listaUsuarios.Add(usuario);
            }
            return retorno;
        }

        public static List<Usuario> GetListaUsuarios
        {
            get { return listaUsuarios; }

        }
    }
}
