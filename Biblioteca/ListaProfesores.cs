using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea una lista estática de profesores
    /// </summary>
    public static class ListaProfesores
    {
        private static List<Profesor> listaProfesores;

        static ListaProfesores()
        {
            listaProfesores = ListaMaterias.ListaProfesoresTotales;
        }

        public static List<Profesor> GetListaProfesores
        {
            get
            {
                return listaProfesores;
            }
            set
            {
                listaProfesores = value;
            }
        }
    }
}