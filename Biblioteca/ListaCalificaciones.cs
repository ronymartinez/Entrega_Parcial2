using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la lista estática de todas las calificaciones actuales
    /// </summary>
    public static class ListaCalificaciones
    {
        private static Dictionary<Alumno, List<Calificacion>> diccionarioCalificaciones;
        private static List<Materia> listaMaterias;

        static ListaCalificaciones()
        {
            diccionarioCalificaciones = new Dictionary<Alumno, List<Calificacion>>();
            listaMaterias = ListaMaterias.GetListaMateriaTotales;
            CargarDiccionario();
        }

        /// <summary>
        /// Se cargan los datos harcodeados a la lista estática
        /// </summary>
        private static void CargarDiccionario()
        {
            List<Calificacion> listaAuxCalificaciones = new List<Calificacion>();

            foreach (var itemMateria in listaMaterias)
            {
                if (itemMateria.ListaAlumnosAsignados is not null)
                {
                    foreach (var itemAlumno in itemMateria.ListaAlumnosAsignados)
                    {
                        if (!diccionarioCalificaciones.ContainsKey(itemAlumno))
                        {
                            listaAuxCalificaciones = itemAlumno.Calificaciones;
                            diccionarioCalificaciones.Add(itemAlumno, listaAuxCalificaciones);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Se agrega un alumno a la lista estática de las calificaciones
        /// </summary>
        /// <param name="alumno"></param>
        public static void AgregarDiccionarioCalificaciones(Alumno alumno)
        {   

            if (!diccionarioCalificaciones.ContainsKey(alumno))
            {
                diccionarioCalificaciones.Add(alumno, alumno.Calificaciones);
            }
        }
        public static Dictionary<Alumno, List<Calificacion>> GetDiccionarioCalificaciones { get => diccionarioCalificaciones; set => diccionarioCalificaciones = value; }
    }
}
