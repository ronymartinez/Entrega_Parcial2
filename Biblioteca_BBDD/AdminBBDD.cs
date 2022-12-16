using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_BBDD
{
    public class AdminBBDD
    {
        private int legajo;
        private string nombre;
        private string apellido;

        public AdminBBDD(int legajo)
        {
            this.legajo = legajo;
        }
        public AdminBBDD(int legajo, string nombre, string apellido):this(legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
