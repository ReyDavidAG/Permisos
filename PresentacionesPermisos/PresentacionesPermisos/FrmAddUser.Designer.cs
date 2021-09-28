
namespace PresentacionesPermisos
{
    partial class FrmAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidoP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFechanacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.CbCliente = new System.Windows.Forms.CheckBox();
            this.Cbvendedor = new System.Windows.Forms.CheckBox();
            this.CbAdministrador = new System.Windows.Forms.CheckBox();
            this.CbActualizacion = new System.Windows.Forms.CheckBox();
            this.CbEliminacion = new System.Windows.Forms.CheckBox();
            this.CbEscritura = new System.Windows.Forms.CheckBox();
            this.CbLectura = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTGP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(68, 115);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(272, 23);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellidoP
            // 
            this.TxtApellidoP.Location = new System.Drawing.Point(68, 207);
            this.TxtApellidoP.Name = "TxtApellidoP";
            this.TxtApellidoP.Size = new System.Drawing.Size(272, 23);
            this.TxtApellidoP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno:";
            // 
            // TxtApellidoM
            // 
            this.TxtApellidoM.Location = new System.Drawing.Point(68, 251);
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.Size = new System.Drawing.Size(272, 23);
            this.TxtApellidoM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno:";
            // 
            // TxtFechanacimiento
            // 
            this.TxtFechanacimiento.Location = new System.Drawing.Point(68, 295);
            this.TxtFechanacimiento.Name = "TxtFechanacimiento";
            this.TxtFechanacimiento.Size = new System.Drawing.Size(272, 23);
            this.TxtFechanacimiento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(68, 339);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(272, 23);
            this.TxtRFC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "RFC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agregar Datos ";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(68, 395);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 46);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(208, 395);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(132, 46);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "Aceptar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(68, 157);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(272, 23);
            this.TxtPassword.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contrasena:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(68, 71);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(272, 23);
            this.TxtId.TabIndex = 30;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(65, 53);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(24, 15);
            this.lable.TabIndex = 29;
            this.lable.Text = "ID:";
            // 
            // CbCliente
            // 
            this.CbCliente.AutoSize = true;
            this.CbCliente.Location = new System.Drawing.Point(748, 78);
            this.CbCliente.Name = "CbCliente";
            this.CbCliente.Size = new System.Drawing.Size(70, 19);
            this.CbCliente.TabIndex = 38;
            this.CbCliente.Text = "Cliente";
            this.CbCliente.UseVisualStyleBackColor = true;
            // 
            // Cbvendedor
            // 
            this.Cbvendedor.AutoSize = true;
            this.Cbvendedor.Location = new System.Drawing.Point(653, 78);
            this.Cbvendedor.Name = "Cbvendedor";
            this.Cbvendedor.Size = new System.Drawing.Size(89, 19);
            this.Cbvendedor.TabIndex = 37;
            this.Cbvendedor.Text = "Vendedor";
            this.Cbvendedor.UseVisualStyleBackColor = true;
            // 
            // CbAdministrador
            // 
            this.CbAdministrador.AutoSize = true;
            this.CbAdministrador.Location = new System.Drawing.Point(533, 78);
            this.CbAdministrador.Name = "CbAdministrador";
            this.CbAdministrador.Size = new System.Drawing.Size(114, 19);
            this.CbAdministrador.TabIndex = 36;
            this.CbAdministrador.Text = "Administrador";
            this.CbAdministrador.UseVisualStyleBackColor = true;
            // 
            // CbActualizacion
            // 
            this.CbActualizacion.AutoSize = true;
            this.CbActualizacion.Location = new System.Drawing.Point(533, 195);
            this.CbActualizacion.Name = "CbActualizacion";
            this.CbActualizacion.Size = new System.Drawing.Size(110, 19);
            this.CbActualizacion.TabIndex = 35;
            this.CbActualizacion.Text = "Actualizacion";
            this.CbActualizacion.UseVisualStyleBackColor = true;
            // 
            // CbEliminacion
            // 
            this.CbEliminacion.AutoSize = true;
            this.CbEliminacion.Location = new System.Drawing.Point(533, 170);
            this.CbEliminacion.Name = "CbEliminacion";
            this.CbEliminacion.Size = new System.Drawing.Size(95, 19);
            this.CbEliminacion.TabIndex = 34;
            this.CbEliminacion.Text = "Eliminacion";
            this.CbEliminacion.UseVisualStyleBackColor = true;
            // 
            // CbEscritura
            // 
            this.CbEscritura.AutoSize = true;
            this.CbEscritura.Location = new System.Drawing.Point(533, 145);
            this.CbEscritura.Name = "CbEscritura";
            this.CbEscritura.Size = new System.Drawing.Size(80, 19);
            this.CbEscritura.TabIndex = 33;
            this.CbEscritura.Text = "Escritura";
            this.CbEscritura.UseVisualStyleBackColor = true;
            // 
            // CbLectura
            // 
            this.CbLectura.AutoSize = true;
            this.CbLectura.Location = new System.Drawing.Point(533, 120);
            this.CbLectura.Name = "CbLectura";
            this.CbLectura.Size = new System.Drawing.Size(73, 19);
            this.CbLectura.TabIndex = 32;
            this.CbLectura.Text = "Lectura";
            this.CbLectura.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Permisos";
            // 
            // DTGP
            // 
            this.DTGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGP.Location = new System.Drawing.Point(407, 220);
            this.DTGP.Name = "DTGP";
            this.DTGP.Size = new System.Drawing.Size(456, 216);
            this.DTGP.TabIndex = 39;
            this.DTGP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGP_CellContentClick);
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 448);
            this.Controls.Add(this.DTGP);
            this.Controls.Add(this.CbCliente);
            this.Controls.Add(this.Cbvendedor);
            this.Controls.Add(this.CbAdministrador);
            this.Controls.Add(this.CbActualizacion);
            this.Controls.Add(this.CbEliminacion);
            this.Controls.Add(this.CbEscritura);
            this.Controls.Add(this.CbLectura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtRFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFechanacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellidoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellidoP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddUser";
            this.Text = "FrmAddUser";
            ((System.ComponentModel.ISupportInitialize)(this.DTGP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidoP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFechanacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.CheckBox CbCliente;
        private System.Windows.Forms.CheckBox Cbvendedor;
        private System.Windows.Forms.CheckBox CbAdministrador;
        private System.Windows.Forms.CheckBox CbActualizacion;
        private System.Windows.Forms.CheckBox CbEliminacion;
        private System.Windows.Forms.CheckBox CbEscritura;
        private System.Windows.Forms.CheckBox CbLectura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DTGP;
    }
}