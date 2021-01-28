namespace Escritorio
{
    partial class Productos
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.iBtnAgregar = new FontAwesome.Sharp.IconButton();
            this.iBtnEditar = new FontAwesome.Sharp.IconButton();
            this.iBtnBorrar = new FontAwesome.Sharp.IconButton();
            this.ABMPanel = new System.Windows.Forms.Panel();
            this.iBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iBtnAceptar = new FontAwesome.Sharp.IconButton();
            this.cbTipoProd = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbTipoProd = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.ABMPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(65, 23);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(170, 39);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(63, 99);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(615, 342);
            this.dgvProductos.TabIndex = 1;
            // 
            // iBtnAgregar
            // 
            this.iBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtnAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAgregar.IconSize = 30;
            this.iBtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAgregar.Location = new System.Drawing.Point(219, 19);
            this.iBtnAgregar.Name = "iBtnAgregar";
            this.iBtnAgregar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnAgregar.Size = new System.Drawing.Size(125, 46);
            this.iBtnAgregar.TabIndex = 2;
            this.iBtnAgregar.Text = "Agregar";
            this.iBtnAgregar.UseVisualStyleBackColor = true;
            this.iBtnAgregar.Click += new System.EventHandler(this.iBtnAgregar_Click);
            // 
            // iBtnEditar
            // 
            this.iBtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iBtnEditar.IconColor = System.Drawing.Color.Black;
            this.iBtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnEditar.IconSize = 30;
            this.iBtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnEditar.Location = new System.Drawing.Point(387, 19);
            this.iBtnEditar.Name = "iBtnEditar";
            this.iBtnEditar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnEditar.Size = new System.Drawing.Size(125, 46);
            this.iBtnEditar.TabIndex = 2;
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.UseVisualStyleBackColor = true;
            this.iBtnEditar.Click += new System.EventHandler(this.iBtnEditar_Click);
            // 
            // iBtnBorrar
            // 
            this.iBtnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtnBorrar.IconColor = System.Drawing.Color.Red;
            this.iBtnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBorrar.IconSize = 30;
            this.iBtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnBorrar.Location = new System.Drawing.Point(554, 19);
            this.iBtnBorrar.Name = "iBtnBorrar";
            this.iBtnBorrar.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.iBtnBorrar.Size = new System.Drawing.Size(125, 46);
            this.iBtnBorrar.TabIndex = 2;
            this.iBtnBorrar.Text = "Borrar";
            this.iBtnBorrar.UseVisualStyleBackColor = true;
            this.iBtnBorrar.Click += new System.EventHandler(this.iBtnBorrar_Click);
            // 
            // ABMPanel
            // 
            this.ABMPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ABMPanel.Controls.Add(this.iBtnCancelar);
            this.ABMPanel.Controls.Add(this.iBtnAceptar);
            this.ABMPanel.Controls.Add(this.cbTipoProd);
            this.ABMPanel.Controls.Add(this.txtPrecio);
            this.ABMPanel.Controls.Add(this.txtStock);
            this.ABMPanel.Controls.Add(this.txtDesc);
            this.ABMPanel.Controls.Add(this.txtID);
            this.ABMPanel.Controls.Add(this.lbTipoProd);
            this.ABMPanel.Controls.Add(this.lbPrecio);
            this.ABMPanel.Controls.Add(this.lbDesc);
            this.ABMPanel.Controls.Add(this.lbStock);
            this.ABMPanel.Controls.Add(this.lbID);
            this.ABMPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ABMPanel.Location = new System.Drawing.Point(736, 0);
            this.ABMPanel.Name = "ABMPanel";
            this.ABMPanel.Size = new System.Drawing.Size(314, 590);
            this.ABMPanel.TabIndex = 3;
            this.ABMPanel.Visible = false;
            // 
            // iBtnCancelar
            // 
            this.iBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iBtnCancelar.IconColor = System.Drawing.Color.Red;
            this.iBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCancelar.IconSize = 30;
            this.iBtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnCancelar.Location = new System.Drawing.Point(24, 326);
            this.iBtnCancelar.Name = "iBtnCancelar";
            this.iBtnCancelar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnCancelar.Size = new System.Drawing.Size(118, 38);
            this.iBtnCancelar.TabIndex = 15;
            this.iBtnCancelar.Text = "    Cancelar";
            this.iBtnCancelar.UseVisualStyleBackColor = true;
            this.iBtnCancelar.Click += new System.EventHandler(this.iBtnCancelar_Click);
            // 
            // iBtnAceptar
            // 
            this.iBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iBtnAceptar.IconColor = System.Drawing.Color.LimeGreen;
            this.iBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAceptar.IconSize = 30;
            this.iBtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAceptar.Location = new System.Drawing.Point(178, 326);
            this.iBtnAceptar.Name = "iBtnAceptar";
            this.iBtnAceptar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iBtnAceptar.Size = new System.Drawing.Size(118, 38);
            this.iBtnAceptar.TabIndex = 16;
            this.iBtnAceptar.Text = "   Aceptar";
            this.iBtnAceptar.UseVisualStyleBackColor = true;
            this.iBtnAceptar.Click += new System.EventHandler(this.iBtnAceptar_Click);
            // 
            // cbTipoProd
            // 
            this.cbTipoProd.FormattingEnabled = true;
            this.cbTipoProd.Location = new System.Drawing.Point(149, 238);
            this.cbTipoProd.Name = "cbTipoProd";
            this.cbTipoProd.Size = new System.Drawing.Size(147, 24);
            this.cbTipoProd.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(149, 189);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(147, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(149, 139);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(147, 22);
            this.txtStock.TabIndex = 10;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(149, 89);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(147, 22);
            this.txtDesc.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(149, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 22);
            this.txtID.TabIndex = 12;
            // 
            // lbTipoProd
            // 
            this.lbTipoProd.AutoSize = true;
            this.lbTipoProd.Location = new System.Drawing.Point(26, 241);
            this.lbTipoProd.Name = "lbTipoProd";
            this.lbTipoProd.Size = new System.Drawing.Size(116, 17);
            this.lbTipoProd.TabIndex = 5;
            this.lbTipoProd.Text = "Tipo de producto";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(31, 189);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(48, 17);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(26, 94);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(82, 17);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Descripción";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(31, 144);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(43, 17);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Stock";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(26, 44);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID";
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.iBtnAgregar);
            this.btnPanel.Controls.Add(this.iBtnEditar);
            this.btnPanel.Controls.Add(this.iBtnBorrar);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 495);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(736, 95);
            this.btnPanel.TabIndex = 4;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.ABMPanel);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ABMPanel.ResumeLayout(false);
            this.ABMPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private FontAwesome.Sharp.IconButton iBtnAgregar;
        private FontAwesome.Sharp.IconButton iBtnEditar;
        private FontAwesome.Sharp.IconButton iBtnBorrar;
        private System.Windows.Forms.Panel ABMPanel;
        private FontAwesome.Sharp.IconButton iBtnCancelar;
        private FontAwesome.Sharp.IconButton iBtnAceptar;
        private System.Windows.Forms.ComboBox cbTipoProd;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbTipoProd;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel btnPanel;
    }
}