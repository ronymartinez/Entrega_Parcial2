using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Se crea el enumerado de Regularidad
    /// </summary>
    public enum eRegularidad
    {
       Libre = 1,
       Regular = 2,
    }

    /// <summary>
    /// Se crea el enumerado de Aprobación
    /// </summary>
    public enum eAprobacion
    {
        Reprobado = 1,
        Aprobado = 2,
        Pendiente = 3
    }

    /// <summary>
    /// Se crea el enumerado de Cuatrimestre
    /// </summary>
    public enum eCuatriMestre
    {
       Primero = 1,
       Segundo = 2,
       Tercero = 3,
       Cuarto = 4,
    }
}
