using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea clase Calificación que contiene toda la información de las cursadas actuales del alumno
    /// </summary>
    public class Calificacion
    {
        private Materia materia;
        private Examen examen1;
        private Examen examen2;
        private float promedio;
        private eAprobacion aprobacion;
        private eRegularidad regularidad;
        private int cantPresente;

        
        public Calificacion(Materia materia)
        {
            this.materia = materia;
            
        }

        public Calificacion(Materia materia, Examen examen1) : this(materia)
        {
            this.examen1 = examen1;
        }

        public Calificacion(Materia materia, int cantPresente) : this(materia)
        {
            this.cantPresente = cantPresente;
        }
        public Calificacion(Materia materia, Examen examen1, int cantPresente) : this(materia, examen1)
        {
            this.examen1 = examen1;
            this.cantPresente = cantPresente;
        }

        public Calificacion(Materia materia, Examen examen1, Examen examen2, int cantPresente) : this(materia, examen1, cantPresente)
        {           
            this.examen2 = examen2;
            this.promedio = CalcularPromedio();
            this.aprobacion = Aprobacion;
            this.regularidad = Regularidad;
        }

        /// <summary>
        /// Define el promedio del alumno de acuerdo a la nota de los 2 exámenes
        /// </summary>
        /// <returns> Devuelve el promedio de los 2 exámenes </returns>
        private float CalcularPromedio()
        {
            float promedioAux = 0;
           
            if(examen1 is null)
            {
                examen1 = new Examen("Primer Parcial", DateTime.Now);
            }
            if(examen2 is null)
            {
                examen2 = new Examen("Segundo Parcial", DateTime.Now);
            }

            if (this.examen1.Nota != 0 && this.examen2.Nota != 0)
            {
                promedioAux = ((float)examen1.Nota + this.examen2.Nota) / 2;
            }

            return promedioAux;
        }

        /// <summary>
        /// Define el estado de aprobación de un alumno: aprobado, desaprobado o pendiente
        /// </summary>
        public eAprobacion Aprobacion
        {
            get
            {
                if (examen1 != null && examen2 != null)
                {
                    if (this.examen1.Nota != 0 && this.examen2.Nota != 0)
                    {
                        if (examen1.Nota > 6 && examen2.Nota > 6 && (eRegularidad.Regular == Regularidad))
                        {
                            return eAprobacion.Aprobado;
                        }
                        else if(examen1.Nota <= 6 && examen2.Nota <= 6 || this.regularidad == eRegularidad.Libre)
                        {
                            return eAprobacion.Reprobado;
                        }
                        else
                        {
                            return eAprobacion.Reprobado;
                        }
                    }
                    else
                    {
                        return eAprobacion.Pendiente;

                    }
                }
                else
                {
                    return eAprobacion.Pendiente;
                }

            }
            set
            {
                this.aprobacion = value;
            }
        }

        /// <summary>
        /// Define la regularidad de un alumno de acuerdo a su asistencia: regular o libre
        /// </summary>
        public eRegularidad Regularidad
        {
            get
            {
                if (cantPresente < 15 && cantPresente > 0)
                {
                    return eRegularidad.Libre;
                }
                else
                {
                    return eRegularidad.Regular;
                }
            }
            set
            {
                this.regularidad = value;
            }
             

        }

        /// <summary>
        /// Muestra todos los datos del alumno
        /// </summary>
        /// <returns> Devuelve una cadena de texto con toda la información del alumno </returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NombreEx: {examen1.Nombre}");
            sb.AppendLine($"Nota1: {examen1.Nota}");
            sb.AppendLine($"Nota2: {examen2.Nota}");
            sb.AppendLine($"Fecha: {examen1.Fecha}");
            sb.AppendLine($"Fecha: {examen2.Fecha}");
            sb.AppendLine($"Promedio: {promedio}");
            sb.AppendLine($"Aprobacion: {aprobacion}");
            sb.AppendLine($"Regularidad: {regularidad}");
            sb.AppendLine($"CantPrese: {cantPresente}");

            return sb.ToString();
        }

        public Materia Materia { get => materia; set => materia = value; }
        public Examen Examen1 { get => examen1; set => examen1 = value; }
        public Examen Examen2 { get => examen2; set => examen2 = value; }
        public float Promedio { get => CalcularPromedio(); }
        public int CantPresente { get => cantPresente; set => cantPresente = value; }

    }
}
