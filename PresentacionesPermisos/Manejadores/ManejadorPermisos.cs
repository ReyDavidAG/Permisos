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
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "", "taller", 3306);
        public string Guardar(EntidadPermisos per)
        {
            return b.Comando(string.Format("insert into permisos values(null, '{0}', '{1}', '{2}', '{3}', '{4}');",
                per.Lectura, per.Escritura, per.Eliminacion, per.Actualizacion, per.FKID));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = b.Mostrar(string.Format("select * from permisos where idpermiso like '%{0}%' or fkidusuario like '%{0}%';", dato), "permisos").Tables["permisos"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadPermisos per)
        {
            return b.Comando(string.Format("update permisos set lectura = '{0}', escritura = '{1}', eliminacion = '{2}', actualizacion = '{3}' where fkidusuario = '{4}';",
                per.Lectura, per.Escritura, per.Eliminacion, per.Actualizacion, per.FKID));
        }
        public string Borrar(EntidadUsuarios per)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar los permisos de: " + per.Nombre, "Atencion!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = b.Comando(string.Format("delete from permisos where fkidusuario = '{0}';", per.Id));
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
