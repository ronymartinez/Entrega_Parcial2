using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la clase Admin que hereda de Usuario
    /// </summary>
    public class Admin : Usuario
    {
        protected string nombre;
        protected string apellido;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

      
        public Admin(string nombreUsuario, string clave) : base(nombreUsuario, clave)
        {
        }
        public Admin(string nombre, string apellido, string nombreUsuario, string clave) : this(nombreUsuario, clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Muestra los datos del Admin
        /// </summary>
        /// <returns> Devuelve una cadena de texto con los datos del admin </returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Categoría: Administrador");

            return sb.ToString();
        }
    }
}
