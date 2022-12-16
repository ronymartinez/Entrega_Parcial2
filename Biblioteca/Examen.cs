using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la clase Examen
    /// </summary>
    public class Examen
    {
        private string nombre;
        private DateTime fecha;
        private int nota;
        private List<Alumno> listaAlumnosFinal;
        public Examen(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public Examen(string nombre, DateTime fecha, int nota):this(nombre, fecha)
        {
            this.nota = nota;
        }
        public Examen(string nombre, DateTime fecha, List<Alumno> listaAlumnosFinal):this(nombre, fecha)
        {
            this.listaAlumnosFinal = listaAlumnosFinal;
        }

        /// <summary>
        /// Agrega un alumno a un examen final
        /// </summary>
        /// <param name="alumno"></param>
        public void AgregarAlumnoAFinal(Alumno alumno)
        {
            if (listaAlumnosFinal is null)
            {
                listaAlumnosFinal = new List<Alumno>();
                listaAlumnosFinal.Add(alumno);
            }
            else
            {
                bool verificar = true;
                foreach (Alumno alumno2 in listaAlumnosFinal)
                {
                    if (alumno.Legajo == alumno2.Legajo)
                    {
                        verificar = false;
                    }
                }
                if (verificar == true)
                {
                    listaAlumnosFinal.Add(alumno);
                }
            }
        }

        /// <summary>
        /// Indica toda la lista de alumnos inscriptos para un final
        /// </summary>
        /// <returns> Devuelve un string con la lista de nombre y apellidos de los alumnos anotados a final</returns>
        public string ListadoDeAlumnosString()
        {
            StringBuilder sb = new StringBuilder();

            if (listaAlumnosFinal is null)
            {               
                sb.AppendLine("Aún no hay inscriptos");
            }
            else
            {
                int contador = 1;

                foreach (Alumno alumno in listaAlumnosFinal)
                {
                    if(listaAlumnosFinal.Count == contador)
                    {
                        sb.Append($"-{alumno.Nombre} {alumno.Apellido}");
                    }
                    else
                    {
                    sb.AppendLine($"-{alumno.Nombre} {alumno.Apellido}");
                    }
                    contador++;
                }
            }

            return sb.ToString();
        }




        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Nota { get => nota; set => nota = value; }
        public List<Alumno> ListaAlumnosFinal { get => listaAlumnosFinal; set => listaAlumnosFinal = value; }
    }
}
