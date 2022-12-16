using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la mclase materia
    /// </summary>
    public class Materia: IMostrarListado
    {
        private string nombreMateria;
        private List<Profesor> listaProfesoresAsignados;
        private List<Alumno> listaAlumnosAsignados;
        private List<Alumno> listaAlumnosFinal;
        private eCuatriMestre cuatrimestre;
        private List<Materia> listaCorrelativas;

        public Materia()
        {
        }

        public Materia(string nombreMateria, List<Profesor> listaProfesoresAsignados, eCuatriMestre cuatrimestre)
        {
            this.nombreMateria = nombreMateria;
            this.listaProfesoresAsignados = listaProfesoresAsignados;
            this.cuatrimestre = cuatrimestre;
        }

        public Materia(string nombreMateria, List<Profesor> listaProfesoresAsignados, List<Alumno> listaAlumnosAsignados, eCuatriMestre cuatrimestre) : this(nombreMateria, listaProfesoresAsignados, cuatrimestre)
        {
            this.listaAlumnosAsignados = listaAlumnosAsignados;
        }

        public Materia(string nombreMateria, List<Profesor> listaProfesoresAsignados, List<Alumno> listaAlumnosAsignados, eCuatriMestre cuatrimestre, List<Materia> listaCorrelativas) : this(nombreMateria, listaProfesoresAsignados, listaAlumnosAsignados, cuatrimestre)
        {
            this.listaCorrelativas = listaCorrelativas;
        }

        public Materia(string nombreMateria, List<Profesor> listaProfesoresAsignados, eCuatriMestre cuatrimestre, List<Materia> listaCorrelativas) : this(nombreMateria, listaProfesoresAsignados, cuatrimestre)
        {
            this.listaCorrelativas = listaCorrelativas;
        }

        /// <summary>
        /// Se agregan alumno a la lista de anotados para un final
        /// </summary>
        /// <param name="alumno"></param>
        public void AgregarAlumnosAFinal(Alumno alumno)
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
        /// Muestra la lista de los profesores aisgnados a una materia
        /// </summary>
        /// <returns> Devuelve un string con los nombres y apellidos de los profesores </returns>
        public string MostrarProfesores()
        {
            StringBuilder sb = new StringBuilder();

            if (listaProfesoresAsignados is not null)
            {
                int contador = 1;
                foreach (var item in listaProfesoresAsignados)
                {
                                     

                    if (listaProfesoresAsignados.Count == contador)
                    {
                        sb.Append($"-{item.Nombre} {item.Apellido} ");
                    }
                    else
                    {
                        sb.AppendLine($"-{item.Nombre} {item.Apellido} ");
                    }

                    contador++;
                }
            }
            else
            {
                sb.Append("Profesores sin asignar");
            }
            return sb.ToString();
        }


        /// <summary>
        /// Muestra la lista de los alumnos anotados a una materia
        /// </summary>
        /// <returns> Devuelve un string con los nombres y apellidos de los alumnos anotados </returns>
        public string MostrarAlumnos()
        {
            StringBuilder sb = new StringBuilder();
                       
            if (listaAlumnosAsignados is not null)
            {
                int contador = 1;
                foreach (Alumno alumno in listaAlumnosAsignados)
                {
                    if (listaProfesoresAsignados.Count == contador)
                    {
                        sb.Append($"-{alumno.Nombre} {alumno.Apellido} ");
                    }
                    else
                    {
                        sb.AppendLine($"-{alumno.Nombre} {alumno.Apellido} ");
                    }

                    contador++;
                }
            }
            else
            {
                sb.Append("Alumnos sin asignar");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Muestra la lista de correlatividades de una materia
        /// </summary>
        /// <returns> Devuelve un string con la lista de correlatividades de una materia </returns>
        public string MostrarCorrelativas()
        {
            StringBuilder sb = new StringBuilder();

            if (listaCorrelativas is not null)
            {
                foreach (var item in listaCorrelativas)
                {
                    sb.AppendLine($"-{item.NombreMateria}");
                }
            }
            else
            {
                sb.AppendLine("Sin correlatividad");
            }
            return sb.ToString();
        }

        public string IMostrarListadoAlumnos()
        {
             StringBuilder sb = new StringBuilder();
                       
            if (listaAlumnosAsignados is not null)
            {
                int contador = 1;
                foreach (Alumno alumno in listaAlumnosAsignados)
                {
                    if (listaAlumnosAsignados.Count == contador)
                    {
                        sb.Append($"{alumno.Nombre} {alumno.Apellido}");
                    }
                    else
                    {
                        sb.Append($"{alumno.Nombre} {alumno.Apellido}, ");
                    }

                    contador++;
                }
            }
            else
            {
                sb.Append("Alumnos sin asignar");
            }

            return sb.ToString();
        }
        public string IMostrarListadoProfesores()
        {
            StringBuilder sb = new StringBuilder();

            if (listaProfesoresAsignados is not null)
            {
                int contador = 1;
                foreach (var item in listaProfesoresAsignados)
                {
                    if (listaProfesoresAsignados.Count == contador)
                    {
                        sb.Append($"{item.Nombre} {item.Apellido}");
                    }
                    else
                    {
                        sb.Append($"{item.Nombre} {item.Apellido}, ");
                    }
                    contador++;
                }
            }
            else
            {
                sb.Append("Profesores sin asignar");
            }
            return sb.ToString();
        }

        public string IMostrarListadoCorrelativas()
        {
            StringBuilder sb = new StringBuilder();

            if (listaCorrelativas is not null)
            {
                int contador = 1;
                foreach (var item in listaCorrelativas)
                {
                    if (listaCorrelativas.Count == contador)
                    {
                        sb.Append($"{item.NombreMateria}");
                    }
                    else
                    {
                        sb.Append($"{item.NombreMateria}, ");
                    }
                    contador++;
                }
            }
            else
            {
                sb.Append("Sin correlatividad");
            }
            return sb.ToString();
        }

        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public List<Profesor> ListaProfesoresAsignados { get => listaProfesoresAsignados; set => listaProfesoresAsignados = value; }
        public List<Alumno> ListaAlumnosAsignados { get => listaAlumnosAsignados; set => listaAlumnosAsignados = value; }
        public eCuatriMestre Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public List<Materia> ListaCorrelativas { get => listaCorrelativas; set => listaCorrelativas = value; }
        public List<Alumno> ListaAlumnosFinal { get => listaAlumnosFinal; set => listaAlumnosFinal = value; }
        
    }
}
