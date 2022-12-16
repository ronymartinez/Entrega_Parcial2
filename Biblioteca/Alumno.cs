using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la clase Alumno que hereda de Usuario
    /// </summary>
    public class Alumno : Usuario
    {
        private string nombre;
        private string apellido;
        private List<Calificacion> calificaciones;
        public Alumno(string nombreUsuario, string clave) : base(nombreUsuario, clave)
        {
        }

        public Alumno(string nombre, string apellido, string nombreUsuario, string clave) : this(nombreUsuario, clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Alumno(string nombre, string apellido, string nombreUsuario, string clave, List<Calificacion> calificaciones) : this(nombre, apellido, nombreUsuario, clave)
        {
            this.calificaciones = calificaciones;
        }

        public Alumno() : base("alumnoPrueba", "12345")
        {
        }


        /// <summary>
        /// Agrega una clase calificación al alumno
        /// </summary>
        /// <param name="calificacion"></param>
        public void AgregarCalificacion(Calificacion calificacion)
        {
            foreach (var item in calificaciones)
            {
                if (item.Materia.NombreMateria != calificacion.Materia.NombreMateria)
                {
                    if (calificacion.Examen1 is null)
                    {
                        calificacion.Examen1 = new Examen("Primer parcial", DateTime.Now);
                    }
                    if (calificacion.Examen2 is null)
                    {
                        calificacion.Examen2 = new Examen("Segundo parcial", DateTime.Now);
                    }
                    this.calificaciones.Add(calificacion);
                    break;
                }
            }
        }


        /// <summary>
        /// Muestra los datos del Alumno
        /// </summary>
        /// <returns> Devuelve una cadena de texto con los datos del Alumno </returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Categoría: Alumno");

            return sb.ToString();
        }

        public float ObtenerPromedio(float notaUno, float notaDos)
        {
            if (notaDos != 0 && notaDos > 0)
            {
                return notaUno / notaDos;
            }
            return 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }

    }
}
