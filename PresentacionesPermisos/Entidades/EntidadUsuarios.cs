using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadUsuarios 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fechanacimiento { get; set; }
        public string RFC { get; set; }
        public EntidadUsuarios(int id, string nombre,
            string password, string apellidop,
            string apellidom, string fechanacimiento,
            string rfc)
        {
            Id = id;
            Nombre = nombre;
            Password = password;
            Apellidop = apellidop;
            Apellidom = apellidom;
            Fechanacimiento = fechanacimiento;
            RFC = rfc;
        }

        public EntidadUsuarios()
        {
        }
    }
}
