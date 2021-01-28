namespace Escritorio
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklblOlvideMiPw = new System.Windows.Forms.LinkLabel();
            this.picEsconder = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.linklblOlvideMiPw);
            this.panel2.Controls.Add(this.picEsconder);
            this.panel2.Controls.Add(this.picSalir);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.txtPw);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 283);
            this.panel2.TabIndex = 7;
            // 
            // linklblOlvideMiPw
            // 
            this.linklblOlvideMiPw.AutoSize = true;
            this.linklblOlvideMiPw.Location = new System.Drawing.Point(273, 236);
            this.linklblOlvideMiPw.Name = "linklblOlvideMiPw";
            this.linklblOlvideMiPw.Size = new System.Drawing.Size(145, 17);
            this.linklblOlvideMiPw.TabIndex = 4;
            this.linklblOlvideMiPw.TabStop = true;
            this.linklblOlvideMiPw.Text = "Olvidé mi contraseña.";
            this.linklblOlvideMiPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblOlvideMiPw_LinkClicked);
            // 
            // picEsconder
            // 
            this.picEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picEsconder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEsconder.Image = ((System.Drawing.Image)(resources.GetObject("picEsconder.Image")));
            this.picEsconder.Location = new System.Drawing.Point(686, 3);
            this.picEsconder.Name = "picEsconder";
            this.picEsconder.Size = new System.Drawing.Size(35, 35);
            this.picEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEsconder.TabIndex = 6;
            this.picEsconder.TabStop = false;
            this.picEsconder.Click += new System.EventHandler(this.picEsconder_Click);
            // 
            // picSalir
            // 
            this.picSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(172)))), ((int)(((byte)(129)))));
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = ((System.Drawing.Image)(resources.GetObject("picSalir.Image")));
            this.picSalir.Location = new System.Drawing.Point(727, 3);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(35, 35);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalir.TabIndex = 7;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 283);
            this.panel1.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(536, 218);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(162, 53);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.Gray;
            this.txtPw.Location = new System.Drawing.Point(276, 144);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(422, 28);
            this.txtPw.TabIndex = 3;
            this.txtPw.Text = "CONTRASEÑA";
            this.txtPw.Enter += new System.EventHandler(this.txtPw_Enter);
            this.txtPw.Leave += new System.EventHandler(this.txtPw_Leave);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(276, 66);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(422, 28);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 283);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picEsconder;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.LinkLabel linklblOlvideMiPw;
        private System.Windows.Forms.TextBox txtPw;
    }
}