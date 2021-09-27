using System;
using System.Windows.Forms;
using Manejadores;
using Entidades;
namespace PresentacionesPermisos
{
    public partial class Login : Form
    {
        ManejadorUsuarios m;
        EntidadUsuarios eu;

        public Login()
        {
            InitializeComponent();
            m = new ManejadorUsuarios();
            eu = new EntidadUsuarios();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            eu.Nombre = TxtUsuario.Text;
            eu.Password = TxtContrasena.Text;
            if (m.ExisteUsuario(eu))
            {
                FrmPrincipal frm = new FrmPrincipal();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contrasena son incorrectas");
            }

            
        }

        private void CbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            TxtContrasena.PasswordChar = CbMostrar.Checked ? '\0' : '*';
        }
    }
}
