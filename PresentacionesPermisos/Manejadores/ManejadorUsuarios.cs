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

        public string Guardar(EntidadUsuarios user, EntidadPermisos per)
        {
            return b.Comando(string.Format("insert into usuarios values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'); insert into permisos values(null, '{7}', '{8}', '{9}', '{10}', '{0}');",user.Id, user.Nombre, user.Password, user.Apellidop, user.Apellidom,
                user.Fechanacimiento, user.RFC, per.Lectura, per.Escritura, per.Eliminacion, per.Actualizacion));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = b.Mostrar(string.Format("select * from usuarios where nombre like '%{0}%' or rfc like '%{0}%';", dato), "usuarios").Tables["usuarios"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadUsuarios user, EntidadPermisos per)
        {
            return b.Comando(string.Format("update usuarios set idusuario = '{0}', nombre = '{1}', password = '{2}', apellidop = '{3}', apellidom = '{4}', " +
                "fechanacimiento = '{5}', rfc = '{6}' where idusuario = '{0}'; update permisos set lectura = '{7}', escritura = '{8}', eliminacion = '{9}', actualizacion = '{10}' where fkidusuario = '{0}'", 
                user.Id, user.Nombre,
                user.Password, user.Apellidop, user.Apellidom, user.Fechanacimiento, user.RFC, per.Lectura, per.Escritura, per.Eliminacion, per.Actualizacion));
        }
        public string Borrar(EntidadUsuarios user)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar " + user.Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from permisos where fkidusuario = '{0}';"+
                    "delete from usuarios where idusuario = '{0}';", user.Id));
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
