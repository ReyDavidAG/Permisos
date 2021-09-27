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
        public static EntidadUsuarios eu;
        int i = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            eu = new EntidadUsuarios();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            eu.Nombre = "";
            eu.Password = "";
            eu.Apellidop = "";
            eu.Apellidom = "";
            eu.Fechanacimiento = "";
            eu.RFC = "";
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
            Actualizar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            mu.Mostrar(DTG, TxtBuscar.Text);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DTG.RowCount > 0)
            {
                FrmAddUser frm = new FrmAddUser();
                frm.ShowDialog();
                Actualizar();
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DTG.RowCount > 0)
            {
                string r = mu.Borrar(eu);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eu.Nombre = DTG.Rows[i].Cells[1].Value.ToString();
            eu.Password = DTG.Rows[i].Cells[2].Value.ToString();
            eu.Apellidop = DTG.Rows[i].Cells[3].Value.ToString();
            eu.Apellidom = DTG.Rows[i].Cells[4].Value.ToString();
            eu.Fechanacimiento = DTG.Rows[i].Cells[5].Value.ToString();
            eu.RFC = DTG.Rows[i].Cells[6].Value.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
