namespace Escritorio
{
    partial class ProductosVentas
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
            this.iBtnAgregarTipoUsuario = new FontAwesome.Sharp.IconButton();
            this.iBtnAgregarPersona = new FontAwesome.Sharp.IconButton();
            this.iBtnAceptar = new FontAwesome.Sharp.IconButton();
            this.ABMPanel = new System.Windows.Forms.Panel();
            this.iBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.txtRepetirPw = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipoProd = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbVentas = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosVentas = new System.Windows.Forms.DataGridView();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.iBtnAgregar = new FontAwesome.Sharp.IconButton();
            this.iBtnEditar = new FontAwesome.Sharp.IconButton();
            this.iBtnBorrar = new FontAwesome.Sharp.IconButton();
            this.ABMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVentas)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iBtnAgregarTipoUsuario
            // 
            this.iBtnAgregarTipoUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAgregarTipoUsuario.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAgregarTipoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAgregarTipoUsuario.IconSize = 30;
            this.iBtnAgregarTipoUsuario.Location = new System.Drawing.Point(343, 395);
            this.iBtnAgregarTipoUsuario.Name = "iBtnAgregarTipoUsuario";
            this.iBtnAgregarTipoUsuario.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnAgregarTipoUsuario.Size = new System.Drawing.Size(27, 27);
            this.iBtnAgregarTipoUsuario.TabIndex = 18;
            this.iBtnAgregarTipoUsuario.UseVisualStyleBackColor = true;
            // 
            // iBtnAgregarPersona
            // 
            this.iBtnAgregarPersona.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAgregarPersona.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAgregarPersona.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAgregarPersona.IconSize = 30;
            this.iBtnAgregarPersona.Location = new System.Drawing.Point(343, 313);
            this.iBtnAgregarPersona.Name = "iBtnAgregarPersona";
            this.iBtnAgregarPersona.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnAgregarPersona.Size = new System.Drawing.Size(27, 27);
            this.iBtnAgregarPersona.TabIndex = 17;
            this.iBtnAgregarPersona.UseVisualStyleBackColor = true;
            // 
            // iBtnAceptar
            // 
            this.iBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iBtnAceptar.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAceptar.IconSize = 30;
            this.iBtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAceptar.Location = new System.Drawing.Point(212, 478);
            this.iBtnAceptar.Name = "iBtnAceptar";
            this.iBtnAceptar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnAceptar.Size = new System.Drawing.Size(118, 38);
            this.iBtnAceptar.TabIndex = 16;
            this.iBtnAceptar.Text = "   Aceptar";
            this.iBtnAceptar.UseVisualStyleBackColor = true;
            // 
            // ABMPanel
            // 
            this.ABMPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ABMPanel.Controls.Add(this.iBtnAgregarTipoUsuario);
            this.ABMPanel.Controls.Add(this.iBtnAgregarPersona);
            this.ABMPanel.Controls.Add(this.iBtnCancelar);
            this.ABMPanel.Controls.Add(this.iBtnAceptar);
            this.ABMPanel.Controls.Add(this.cbTipoUsuario);
            this.ABMPanel.Controls.Add(this.cbPersona);
            this.ABMPanel.Controls.Add(this.txtRepetirPw);
            this.ABMPanel.Controls.Add(this.txtPw);
            this.ABMPanel.Controls.Add(this.txtUsuario);
            this.ABMPanel.Controls.Add(this.txtID);
            this.ABMPanel.Controls.Add(this.label1);
            this.ABMPanel.Controls.Add(this.lbTipoProd);
            this.ABMPanel.Controls.Add(this.lbPrecio);
            this.ABMPanel.Controls.Add(this.lbDesc);
            this.ABMPanel.Controls.Add(this.lbStock);
            this.ABMPanel.Controls.Add(this.lbID);
            this.ABMPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ABMPanel.Location = new System.Drawing.Point(650, 0);
            this.ABMPanel.Name = "ABMPanel";
            this.ABMPanel.Size = new System.Drawing.Size(382, 543);
            this.ABMPanel.TabIndex = 12;
            this.ABMPanel.Visible = false;
            // 
            // iBtnCancelar
            // 
            this.iBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iBtnCancelar.IconColor = System.Drawing.Color.Red;
            this.iBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCancelar.IconSize = 30;
            this.iBtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnCancelar.Location = new System.Drawing.Point(58, 478);
            this.iBtnCancelar.Name = "iBtnCancelar";
            this.iBtnCancelar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnCancelar.Size = new System.Drawing.Size(118, 38);
            this.iBtnCancelar.TabIndex = 15;
            this.iBtnCancelar.Text = "    Cancelar";
            this.iBtnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(174, 397);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(147, 24);
            this.cbTipoUsuario.TabIndex = 14;
            // 
            // cbPersona
            // 
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Location = new System.Drawing.Point(174, 315);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(147, 24);
            this.cbPersona.TabIndex = 14;
            // 
            // txtRepetirPw
            // 
            this.txtRepetirPw.Location = new System.Drawing.Point(174, 247);
            this.txtRepetirPw.Name = "txtRepetirPw";
            this.txtRepetirPw.Size = new System.Drawing.Size(147, 22);
            this.txtRepetirPw.TabIndex = 13;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(174, 159);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(147, 22);
            this.txtPw.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(174, 96);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(147, 22);
            this.txtUsuario.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(174, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 22);
            this.txtID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de usuario";
            // 
            // lbTipoProd
            // 
            this.lbTipoProd.AutoSize = true;
            this.lbTipoProd.Location = new System.Drawing.Point(27, 318);
            this.lbTipoProd.Name = "lbTipoProd";
            this.lbTipoProd.Size = new System.Drawing.Size(61, 17);
            this.lbTipoProd.TabIndex = 5;
            this.lbTipoProd.Text = "Persona";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.lbPrecio.Location = new System.Drawing.Point(27, 247);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(129, 17);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Repetir contraseña";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(27, 101);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(57, 17);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Usuario";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(27, 164);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(81, 17);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Contraseña";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(27, 30);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID";
            // 
            // lbVentas
            // 
            this.lbVentas.AutoSize = true;
            this.lbVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentas.Location = new System.Drawing.Point(31, 9);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(299, 39);
            this.lbVentas.TabIndex = 14;
            this.lbVentas.Text = "Detalle de la venta";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Visible = false;
            // 
            // nroTel
            // 
            this.nroTel.HeaderText = "Teléfono";
            this.nroTel.MinimumWidth = 6;
            this.nroTel.Name = "nroTel";
            this.nroTel.ReadOnly = true;
            this.nroTel.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Visible = false;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Visible = false;
            // 
            // idPersona
            // 
            this.idPersona.HeaderText = "ID";
            this.idPersona.MinimumWidth = 6;
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Visible = false;
            // 
            // dgvProductosVentas
            // 
            this.dgvProductosVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersona,
            this.nombre,
            this.apellido,
            this.dni,
            this.email,
            this.nroTel,
            this.direccion});
            this.dgvProductosVentas.Location = new System.Drawing.Point(12, 76);
            this.dgvProductosVentas.Name = "dgvProductosVentas";
            this.dgvProductosVentas.RowHeadersWidth = 51;
            this.dgvProductosVentas.RowTemplate.Height = 24;
            this.dgvProductosVentas.Size = new System.Drawing.Size(615, 342);
            this.dgvProductosVentas.TabIndex = 15;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.iBtnAgregar);
            this.btnPanel.Controls.Add(this.iBtnEditar);
            this.btnPanel.Controls.Add(this.iBtnBorrar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 448);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(650, 95);
            this.btnPanel.TabIndex = 16;
            // 
            // iBtnAgregar
            // 
            this.iBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAgregar.IconSize = 30;
            this.iBtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAgregar.Location = new System.Drawing.Point(184, 27);
            this.iBtnAgregar.Name = "iBtnAgregar";
            this.iBtnAgregar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnAgregar.Size = new System.Drawing.Size(125, 46);
            this.iBtnAgregar.TabIndex = 2;
            this.iBtnAgregar.Text = "Agregar";
            this.iBtnAgregar.UseVisualStyleBackColor = true;
            // 
            // iBtnEditar
            // 
            this.iBtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtnEditar.IconColor = System.Drawing.Color.Black;
            this.iBtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditar.IconSize = 30;
            this.iBtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnEditar.Location = new System.Drawing.Point(352, 27);
            this.iBtnEditar.Name = "iBtnEditar";
            this.iBtnEditar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnEditar.Size = new System.Drawing.Size(125, 46);
            this.iBtnEditar.TabIndex = 2;
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.UseVisualStyleBackColor = true;
            // 
            // iBtnBorrar
            // 
            this.iBtnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnBorrar.IconColor = System.Drawing.Color.Red;
            this.iBtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBorrar.IconSize = 30;
            this.iBtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnBorrar.Location = new System.Drawing.Point(519, 27);
            this.iBtnBorrar.Name = "iBtnBorrar";
            this.iBtnBorrar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnBorrar.Size = new System.Drawing.Size(125, 46);
            this.iBtnBorrar.TabIndex = 2;
            this.iBtnBorrar.Text = "Borrar";
            this.iBtnBorrar.UseVisualStyleBackColor = true;
            // 
            // ProductosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 543);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.ABMPanel);
            this.Controls.Add(this.lbVentas);
            this.Controls.Add(this.dgvProductosVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosVentas";
            this.Text = "ProductosVentas";
            this.ABMPanel.ResumeLayout(false);
            this.ABMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVentas)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnAgregarTipoUsuario;
        private FontAwesome.Sharp.IconButton iBtnAgregarPersona;
        private FontAwesome.Sharp.IconButton iBtnAceptar;
        private System.Windows.Forms.Panel ABMPanel;
        private FontAwesome.Sharp.IconButton iBtnCancelar;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.TextBox txtRepetirPw;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipoProd;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridView dgvProductosVentas;
        private System.Windows.Forms.Panel btnPanel;
        private FontAwesome.Sharp.IconButton iBtnAgregar;
        private FontAwesome.Sharp.IconButton iBtnEditar;
        private FontAwesome.Sharp.IconButton iBtnBorrar;
    }
}