using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeRopa.Datos;

namespace Escritorio
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //Ocultar bordes
            this.Text = String.Empty;
            this.ControlBox = false;

        }

        private usuarios _UsuarioLogueado;

        public usuarios UsuarioLogueado { get => _UsuarioLogueado; set => _UsuarioLogueado = value; }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "USUARIO")
            {
                this.txtUser.Text = "";
                this.txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "")
            {
                this.txtUser.Text = "USUARIO";
                this.txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (this.txtPw.Text == "CONTRASEÑA")
            {
                this.txtPw.Text = String.Empty;
                this.txtPw.ForeColor = Color.Black;
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (this.txtPw.Text == String.Empty)
            {
                this.txtPw.Text = "CONTRASEÑA";
                this.txtPw.ForeColor = Color.Gray;
            }
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogueado = ValidarUsuario(this.txtUser.Text, this.txtPw.Text);
            if (UsuarioLogueado != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Pruebe otra vez!", "Problemillas",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

        }

        public static usuarios ValidarUsuario(string usuario, string pass)
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {

                //FirstOrDefault() devuelve el objeto si lo encuentra, caso contrario devuelve null
                var myUser = db.usuarios
                    .FirstOrDefault(u => u.nombreUsuario == usuario
                                 && u.password == pass);

                return myUser;

            }
            

        }

        private void linklblOlvideMiPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pruebe con usuario y contraseña: \"admin\" ", "No le digas a nadie",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }
    }
}
