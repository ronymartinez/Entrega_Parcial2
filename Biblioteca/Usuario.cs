using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Usuario
    {
        protected int legajo;
        protected string nombreUsuario;
        protected string clave;
        protected static int legajoAux;

 
        static Usuario()
        {
            legajoAux = 1000;
        }
        public Usuario(string nombreUsuario, string clave)
        {
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            legajo = legajoAux++;
        }
  
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Usuario: {nombreUsuario}");

            return sb.ToString();
        }

        public string Clave
        {
            get { return clave; }
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    }
}
