using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "", "taller", 3306);

        public string Guardar(EntidadUsuarios user)
        {
            return b.Comando(string.Format("insertar into usuarios values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", user.Nombre, user.Password, user.Apellidop, user.Apellidom, user.Apellidom,
                user.Fechanacimiento, user.RFC));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = b.Mostrar(string.Format("select * from usuarios where nombre like '%{0}%' or rfc like '%{0}%';", dato), "usuarios").Tables["usuarios"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadUsuarios user)
        {
            return b.Comando(string.Format("update usuarios set nombre = '{0}', password = '{1}', apellidop = '{2}', apellidom = '{3}', " +
                "fechanacimiento = '{4}', rfc = '{5}', '{6}' where rfc = '{6}';", user.Nombre, user.Password, user.Apellidop, user.Apellidom, user.Fechanacimiento, user.RFC));
        }
        public string Borrar(EntidadUsuarios user)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + user.Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from usuarios where rfc = '{0}';", user.RFC));
            }
            return r;
        }
        public bool ExisteUsuario(EntidadUsuarios user)
        {
            try
            {
                string consulta = string.Format("select count(*) from usuarios where nombre = '{0}' and password = '{1}'", user.Nombre, user.Password);
                var existencia = b.Existencia(consulta);
                if (existencia == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo al iniciar sesion  " + ex.Message);
                return false;
            }

        }
        public bool Antiduplicador(EntidadUsuarios user)
        {
            try
            {
                string consulta = string.Format("select count(*) from usuarios where nombre = '{0}' or password = '{1}'", user.Nombre, user.Password);
                var existencia = b.Existencia(consulta);
                if (existencia > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al guardar" + ex.Message);
                return false;
            }
        }
    }
}
