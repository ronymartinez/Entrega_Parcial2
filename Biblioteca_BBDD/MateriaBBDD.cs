using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BBDD
{
    public class MateriaBBDD
    {
        private int id_materia;
        private string nombreMateria;
        private string cuatrimestre;
        private string carrera;

        public MateriaBBDD(int id_materia, string nombreMateria)
        {
            this.id_materia = id_materia;
            this.nombreMateria = nombreMateria;
        }

        public MateriaBBDD(int id_materia, string nombreMateria, string cuatrimestre, string carrera):this(id_materia, nombreMateria)
        {
            this.cuatrimestre = cuatrimestre;
            this.carrera = carrera;
        }
        public int Id_materia { get => id_materia; set => id_materia = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public string Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }
}
