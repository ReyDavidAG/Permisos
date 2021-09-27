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
    public partial class FrmPrincipal : Form
    {
        ManejadorUsuarios mu;
        EntidadUsuarios eu;
        public FrmPrincipal()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            eu = new EntidadUsuarios();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
