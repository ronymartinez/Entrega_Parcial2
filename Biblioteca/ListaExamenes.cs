using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea una lista estática de Exámenes
    /// </summary>
    public static class ListaExamenes
    {
        private static Dictionary<Examen, Materia> diccionarioExamenes;

        static ListaExamenes()
        {
            diccionarioExamenes = new Dictionary<Examen, Materia>();          
        }


        /// <summary>
        /// Agrega un examen a la materia
        /// </summary>
        /// <param name="examen"></param>
        /// <param name="materia"></param>
        public static void AgregarExamen(Examen examen, Materia materia)
        {

            diccionarioExamenes.Add(examen, materia);
        }
        public static Dictionary<Examen, Materia> GetdiccionarioExamenes
        {
            get { return diccionarioExamenes; }
        }
    }
}
