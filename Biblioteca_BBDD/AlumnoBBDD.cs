using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BBDD
{
    public class AlumnoBBDD
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private string materia;
        private string esta_activo;
        private DateTime fechaIncripcion;
        private float promedio;

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Materia: {materia}");
            sb.AppendLine($"Esta_activo: {esta_activo}");
            sb.AppendLine($"F. Inscripcion: {fechaIncripcion}");
            sb.AppendLine($"Promedio: {promedio}");

            return sb.ToString();
        }
        public AlumnoBBDD()
        {
           
        }

        public AlumnoBBDD(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public AlumnoBBDD(int legajo, string nombre, string apellido, string materia, string esta_activo, DateTime fechaIncripcion, float promedio):this(legajo, nombre, apellido)
        {          
            this.materia = materia;
            this.esta_activo = esta_activo;
            this.fechaIncripcion = fechaIncripcion;
            this.promedio = promedio;
        }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Esta_activo { get => esta_activo; set => esta_activo = value; }
        public DateTime FechaIncripcion { get => fechaIncripcion; set => fechaIncripcion = value; }
        public float Promedio { get => promedio; set => promedio = value; }
    }
}
