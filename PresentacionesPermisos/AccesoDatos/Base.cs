using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection con;

        public Base(string s, string u, string p, string b, uint po)
        {
            con = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database = {3}; port = {4}", s, u, p,
                b, po));
        }
        public string Comando(string comandos)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(comandos, con);
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                return "Operacion completa";
            }
            catch (Exception ex)
            {

                con.Close();
                return ex.Message;
            }
        }
        public DataSet Mostrar(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                con.Open();
                da.Fill(ds, tabla);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                con.Close();
                return ds;
            }
        }
        public int Existencia(string consulta)
        {
            con.Open();
            var command = new MySqlCommand(consulta, con);
            var res = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return res;
        }
    }
}
