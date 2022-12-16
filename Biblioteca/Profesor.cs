using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Usuario
    {
        protected string nombre;
        protected string apellido;
        protected List<Materia> materiasAsignadas;
        protected static bool cargaListado = false;

        public Profesor(string nombreUsuario, string clave) : base(nombreUsuario, clave)
        {
            materiasAsignadas = new List<Materia>();
        }

        public Profesor(string nombre, string apellido, string nombreUsuario, string clave) : this(nombreUsuario, clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;       
        }
        //public Profesor(string nombre, string apellido, Materia materiasAsignadas) : this(nombre, apellido)
        //{

        //}
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Categoría: Profesor");

            return sb.ToString();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Materia> MateriasAsignadas
        {
            get
            {
                return materiasAsignadas;
            }
            set
            {
                materiasAsignadas = value;
            }
        }

    }
}
