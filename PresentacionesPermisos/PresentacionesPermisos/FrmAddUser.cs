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
        ManejadorPermisos mp;
        public FrmAddUser()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            mp = new ManejadorPermisos();
            if (FrmUsuarios.eu.Id != 0)
            {
                TxtId.Text = FrmUsuarios.eu.Id.ToString();
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

            //MessageBox.Show(CbLectura.Checked.ToString());
            
            if (FrmUsuarios.eu.Id == 0)
            {
                MessageBox.Show(mu.Guardar(new EntidadUsuarios(int.Parse(TxtId.Text), TxtNombre.Text, TxtPassword.Text, 
                    TxtApellidoP.Text, TxtApellidoM.Text, TxtFechanacimiento.Text, TxtRFC.Text)));
                MessageBox.Show(mp.Guardar(new EntidadPermisos(CbLectura.Checked, CbEscritura.Checked, CbEliminacion.Checked, CbActualizacion.Checked, int.Parse(TxtId.Text))));
                Close();
            }
            else
            {
                MessageBox.Show(mu.Editar(new EntidadUsuarios(FrmUsuarios.eu.Id, TxtNombre.Text, TxtPassword.Text, TxtApellidoP.Text,
                    TxtApellidoM.Text, TxtFechanacimiento.Text, TxtRFC.Text)));
                MessageBox.Show(mp.Editar(new EntidadPermisos(CbLectura.Checked, CbEscritura.Checked, CbEliminacion.Checked, CbActualizacion.Checked, FrmUsuarios.eu.Id)));
            }
            Close();


        }

        private void DTGP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
