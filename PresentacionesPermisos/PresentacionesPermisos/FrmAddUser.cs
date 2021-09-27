using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;
namespace PresentacionesPermisos
{
    public partial class FrmAddUser : Form
    {
        ManejadorUsuarios mu;
        public FrmAddUser()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (FrmUsuarios.eu.RFC.Length != 0)
            {
                TxtNombre.Text = FrmUsuarios.eu.Nombre;
                TxtPassword.Text = FrmUsuarios.eu.Password;
                TxtApellidoP.Text = FrmUsuarios.eu.Apellidop;
                TxtApellidoM.Text = FrmUsuarios.eu.Apellidom;
                TxtFechanacimiento.Text = FrmUsuarios.eu.Fechanacimiento;
                TxtRFC.Text = FrmUsuarios.eu.RFC;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.eu.RFC.Length == 0)
            {
                MessageBox.Show(mu.Guardar(new EntidadUsuarios(TxtNombre.Text, TxtPassword.Text, TxtApellidoP.Text, TxtApellidoM.Text, TxtFechanacimiento.Text, TxtRFC.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mu.Editar(new EntidadUsuarios(TxtNombre.Text, TxtPassword.Text, TxtApellidoP.Text, TxtApellidoM.Text, TxtFechanacimiento.Text, FrmUsuarios.eu.RFC)));
            }
            Close();
        }
    }
}
