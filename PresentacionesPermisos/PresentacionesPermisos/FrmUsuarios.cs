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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        EntidadUsuarios eu;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            eu = new EntidadUsuarios();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            mu.Mostrar(DTG, TxtBuscar.Text);
        }
    }
}
