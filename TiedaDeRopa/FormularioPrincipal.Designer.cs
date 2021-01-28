namespace Escritorio
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iBtnConfig = new FontAwesome.Sharp.IconButton();
            this.iBtnStats = new FontAwesome.Sharp.IconButton();
            this.iBtnSales = new FontAwesome.Sharp.IconButton();
            this.iBtnClients = new FontAwesome.Sharp.IconButton();
            this.iBtnProductos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iPicBoxLOGO = new FontAwesome.Sharp.IconPictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblFormActual = new System.Windows.Forms.Label();
            this.iPicBoxFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.picAchicar = new System.Windows.Forms.PictureBox();
            this.picEsconder = new System.Windows.Forms.PictureBox();
            this.picAgrandar = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxLOGO)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxFormActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAchicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgrandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.panelLeft.Controls.Add(this.iBtnConfig);
            this.panelLeft.Controls.Add(this.iBtnStats);
            this.panelLeft.Controls.Add(this.iBtnSales);
            this.panelLeft.Controls.Add(this.iBtnClients);
            this.panelLeft.Controls.Add(this.iBtnProductos);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 650);
            this.panelLeft.TabIndex = 0;
            // 
            // iBtnConfig
            // 
            this.iBtnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnConfig.FlatAppearance.BorderSize = 0;
            this.iBtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iBtnConfig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnConfig.Location = new System.Drawing.Point(0, 350);
            this.iBtnConfig.Name = "iBtnConfig";
            this.iBtnConfig.Size = new System.Drawing.Size(250, 50);
            this.iBtnConfig.TabIndex = 5;
            this.iBtnConfig.Text = "Configuración";
            this.iBtnConfig.UseVisualStyleBackColor = true;
            // 
            // iBtnStats
            // 
            this.iBtnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnStats.FlatAppearance.BorderSize = 0;
            this.iBtnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnStats.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iBtnStats.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnStats.Location = new System.Drawing.Point(0, 300);
            this.iBtnStats.Name = "iBtnStats";
            this.iBtnStats.Size = new System.Drawing.Size(250, 50);
            this.iBtnStats.TabIndex = 4;
            this.iBtnStats.Text = "Estadisticas";
            this.iBtnStats.UseVisualStyleBackColor = true;
            this.iBtnStats.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iBtnSales
            // 
            this.iBtnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnSales.FlatAppearance.BorderSize = 0;
            this.iBtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iBtnSales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSales.Location = new System.Drawing.Point(0, 250);
            this.iBtnSales.Name = "iBtnSales";
            this.iBtnSales.Size = new System.Drawing.Size(250, 50);
            this.iBtnSales.TabIndex = 3;
            this.iBtnSales.Text = "Ventas";
            this.iBtnSales.UseVisualStyleBackColor = true;
            this.iBtnSales.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iBtnClients
            // 
            this.iBtnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnClients.FlatAppearance.BorderSize = 0;
            this.iBtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnClients.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iBtnClients.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnClients.Location = new System.Drawing.Point(0, 200);
            this.iBtnClients.Name = "iBtnClients";
            this.iBtnClients.Size = new System.Drawing.Size(250, 50);
            this.iBtnClients.TabIndex = 2;
            this.iBtnClients.Text = "Clientes";
            this.iBtnClients.UseVisualStyleBackColor = true;
            this.iBtnClients.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iBtnProductos
            // 
            this.iBtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtnProductos.FlatAppearance.BorderSize = 0;
            this.iBtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnProductos.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.iBtnProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iBtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnProductos.Location = new System.Drawing.Point(0, 150);
            this.iBtnProductos.Name = "iBtnProductos";
            this.iBtnProductos.Size = new System.Drawing.Size(250, 50);
            this.iBtnProductos.TabIndex = 1;
            this.iBtnProductos.Text = "Productos";
            this.iBtnProductos.UseVisualStyleBackColor = true;
            this.iBtnProductos.Click += new System.EventHandler(this.iBtnProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.iPicBoxLOGO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 0;
            // 
            // iPicBoxLOGO
            // 
            this.iPicBoxLOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.iPicBoxLOGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iPicBoxLOGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iPicBoxLOGO.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iPicBoxLOGO.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iPicBoxLOGO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPicBoxLOGO.IconSize = 122;
            this.iPicBoxLOGO.Location = new System.Drawing.Point(27, 11);
            this.iPicBoxLOGO.Name = "iPicBoxLOGO";
            this.iPicBoxLOGO.Size = new System.Drawing.Size(197, 122);
            this.iPicBoxLOGO.TabIndex = 0;
            this.iPicBoxLOGO.TabStop = false;
            this.iPicBoxLOGO.Click += new System.EventHandler(this.iPicBoxLOGO_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.panelTop.Controls.Add(this.lblFormActual);
            this.panelTop.Controls.Add(this.iPicBoxFormActual);
            this.panelTop.Controls.Add(this.picAchicar);
            this.panelTop.Controls.Add(this.picEsconder);
            this.panelTop.Controls.Add(this.picAgrandar);
            this.panelTop.Controls.Add(this.picSalir);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1050, 60);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lblFormActual
            // 
            this.lblFormActual.AutoSize = true;
            this.lblFormActual.Location = new System.Drawing.Point(78, 27);
            this.lblFormActual.Name = "lblFormActual";
            this.lblFormActual.Size = new System.Drawing.Size(45, 17);
            this.lblFormActual.TabIndex = 4;
            this.lblFormActual.Text = "Home";
            // 
            // iPicBoxFormActual
            // 
            this.iPicBoxFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.iPicBoxFormActual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPicBoxFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iPicBoxFormActual.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPicBoxFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iPicBoxFormActual.IconSize = 45;
            this.iPicBoxFormActual.Location = new System.Drawing.Point(16, 9);
            this.iPicBoxFormActual.Name = "iPicBoxFormActual";
            this.iPicBoxFormActual.Size = new System.Drawing.Size(56, 45);
            this.iPicBoxFormActual.TabIndex = 3;
            this.iPicBoxFormActual.TabStop = false;
            // 
            // picAchicar
            // 
            this.picAchicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAchicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picAchicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAchicar.Image = ((System.Drawing.Image)(resources.GetObject("picAchicar.Image")));
            this.picAchicar.Location = new System.Drawing.Point(962, 9);
            this.picAchicar.Name = "picAchicar";
            this.picAchicar.Size = new System.Drawing.Size(35, 35);
            this.picAchicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAchicar.TabIndex = 2;
            this.picAchicar.TabStop = false;
            this.picAchicar.Visible = false;
            this.picAchicar.Click += new System.EventHandler(this.picAchicar_Click);
            // 
            // picEsconder
            // 
            this.picEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picEsconder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEsconder.Image = ((System.Drawing.Image)(resources.GetObject("picEsconder.Image")));
            this.picEsconder.Location = new System.Drawing.Point(921, 9);
            this.picEsconder.Name = "picEsconder";
            this.picEsconder.Size = new System.Drawing.Size(35, 35);
            this.picEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEsconder.TabIndex = 1;
            this.picEsconder.TabStop = false;
            this.picEsconder.Click += new System.EventHandler(this.picEsconder_Click);
            // 
            // picAgrandar
            // 
            this.picAgrandar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAgrandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picAgrandar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgrandar.Image = ((System.Drawing.Image)(resources.GetObject("picAgrandar.Image")));
            this.picAgrandar.Location = new System.Drawing.Point(962, 9);
            this.picAgrandar.Name = "picAgrandar";
            this.picAgrandar.Size = new System.Drawing.Size(35, 35);
            this.picAgrandar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgrandar.TabIndex = 1;
            this.picAgrandar.TabStop = false;
            this.picAgrandar.Click += new System.EventHandler(this.picAgrandar_Click);
            // 
            // picSalir
            // 
            this.picSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(1003, 9);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(35, 35);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalir.TabIndex = 1;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 60);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1050, 590);
            this.panelChild.TabIndex = 2;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormularioPrincipal_Shown);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxLOGO)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPicBoxFormActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAchicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgrandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelChild;
        private FontAwesome.Sharp.IconButton iBtnProductos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnClients;
        private FontAwesome.Sharp.IconButton iBtnStats;
        private FontAwesome.Sharp.IconButton iBtnSales;
        private FontAwesome.Sharp.IconButton iBtnConfig;
        private System.Windows.Forms.PictureBox picAchicar;
        private System.Windows.Forms.PictureBox picEsconder;
        private System.Windows.Forms.PictureBox picAgrandar;
        private System.Windows.Forms.PictureBox picSalir;
        private FontAwesome.Sharp.IconPictureBox iPicBoxLOGO;
        private System.Windows.Forms.Label lblFormActual;
        private FontAwesome.Sharp.IconPictureBox iPicBoxFormActual;
    }
}

