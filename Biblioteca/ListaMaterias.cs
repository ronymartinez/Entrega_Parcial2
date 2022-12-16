using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea la lista estática de materias
    /// </summary>
    public static class ListaMaterias
    {
        private static List<Materia> listaMateriasTotales;
        private static List<Profesor> listaProfesoresTotales;

        static ListaMaterias()
        {
            listaMateriasTotales = new List<Materia>();
            listaProfesoresTotales = new List<Profesor>();
        }

        /// <summary>
        /// Se agrega una materia a la lista principal
        /// </summary>
        /// <param name="materia"></param>
        /// <returns> Retorna true si se hizo correctamente el agregado</returns>
        public static bool AgregarMateriaALaListaTotal(Materia materia)
        {
            bool retorno = false;

            if (materia != null)
            {
                if (listaMateriasTotales.Count == 0)
                {
                    retorno = true;
                }
                else
                {
                    foreach (var item in listaMateriasTotales)
                    {
                        if (item.NombreMateria == materia.NombreMateria)
                        {
                            retorno = false;
                        }
                        else
                        {
                            retorno = true;
                        }
                    }
                }                
            }
            if (retorno == true)
            {
                listaMateriasTotales.Add(materia);
            }
            return retorno;
        }

        /// <summary>
        /// Se agregan las materias harcodeadas al profesor
        /// </summary>
        public static void CargarMateriasAProfes()
        {
            foreach (Materia materia in listaMateriasTotales)
            {
                foreach (Profesor profesor in materia.ListaProfesoresAsignados)
                {
                    AgregarMateriaAProfe(profesor, materia);
                }
            }
        }


        /// <summary>
        /// Se cargan los profesores a la lista principal
        /// </summary>
        /// <returns> Devuelve una lista de profesores con materias asignadas </returns>
        private static List<Profesor> CargarListaProfesoresTotales()
        {
            foreach(Materia materia in listaMateriasTotales)
            {
                foreach(Profesor profesor in materia.ListaProfesoresAsignados)
                {
                    if(listaProfesoresTotales.Count == 0)
                    {
                        listaProfesoresTotales.Add(profesor);
                    }
                    else
                    {
                        bool verificarProfesor = true;
                        foreach (Profesor profesor2 in listaProfesoresTotales)
                        {
                           
                            if(profesor.Legajo == profesor2.Legajo)
                            {
                                verificarProfesor = false;
                            }
                            
                        }
                        if(verificarProfesor == true)
                        {
                            listaProfesoresTotales.Add(profesor);
                        }
                    }                   
                }
            }
            return listaProfesoresTotales;
        }

        /// <summary>
        /// Se agrega una materia a un profesor
        /// </summary>
        /// <param name="profesor"></param>
        /// <param name="materia"></param>
        /// <returns></returns>
        public static bool AgregarMateriaAProfe(Profesor profesor, Materia materia)
        {

            if (profesor.MateriasAsignadas is null || profesor.MateriasAsignadas.Count == 0)
            {
                profesor.MateriasAsignadas.Add(materia);
                return true;
            }
            else
            {
                foreach (Materia materia2 in profesor.MateriasAsignadas)
                {
                    if (materia2.NombreMateria != materia.NombreMateria)
                    {
                        profesor.MateriasAsignadas.Add(materia);
                        return true;
                    }
                }
            }
            return false;
        }

        public static List<Materia> GetListaMateriaTotales
        {
            get { return listaMateriasTotales; }
        }

        public static List<Profesor> ListaProfesoresTotales { get => CargarListaProfesoresTotales(); set => listaProfesoresTotales = value; }
    }
}
