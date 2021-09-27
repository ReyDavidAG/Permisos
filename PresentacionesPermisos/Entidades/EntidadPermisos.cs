using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadPermisos
    {
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Eliminacion { get; set; }
        public bool Actualizacion { get; set; }
        public EntidadPermisos(bool lectura,
            bool escritura, bool eliminacion,
            bool actualizacion)
        {
            Lectura = lectura;
            Escritura = escritura;
            Eliminacion = eliminacion;
            Actualizacion = actualizacion;
        }
    }
}
