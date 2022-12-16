using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BBDD
{
    public class ProfesorBBDD
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private string materia;
        private float sueldo;

        public ProfesorBBDD(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public ProfesorBBDD(int legajo, string nombre, string apellido, string materia, float sueldo):this(legajo, nombre, apellido)
        {      
            this.materia = materia;
            this.sueldo = sueldo;
        }

    }
}
