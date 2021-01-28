using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Runtime.CompilerServices;
using TiendaDeRopa.Datos;

namespace Escritorio
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();


            //Ocultar bordes
            this.Text = String.Empty;
            this.ControlBox = false;

            

            //Evita el parpadeo al cambiar de tamaño en el formulario
            this.DoubleBuffered = true;

            //Sirve para evitar que el formulario al maximizarse ocupe toda la pantalla
            //de esta manera solo ocupara un area de trabajo 
            //(dejando visible la barra de tareas de windows, por ejemplo)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private usuarios _UsuarioLogueado;

        public usuarios UsuarioLogueado { get => _UsuarioLogueado; set => _UsuarioLogueado = value; }

        private IconButton btnActual;



        private struct RGBDefaultColors
        {
            public static Color colorLeftPanel = Color.FromArgb(0, 48, 63);
            public static Color colorLettersIcon = Color.FromArgb(245, 244, 244);
        }

        private struct RGBChangeColors
        {
            public static Color colorButton = Color.FromArgb(202, 228, 219);
            public static Color colorLettersIcon = Color.Black;
        }

        #region Movimiento de formulario desde el top panel
        
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //PALABRAS RESERVADAS DE LA LIBRERIA InteropServices 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsj, int wparam, int lparam);
        #endregion

        #region Metodos para mostrar el boton seleccionado

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                btnActual = (IconButton)senderBtn;


                this.iPicBoxFormActual.IconChar = btnActual.IconChar;
                this.lblFormActual.Text = btnActual.Text;
            }
            else
            {
                DisableButton();

                this.iPicBoxFormActual.IconChar = IconChar.Home;
                this.lblFormActual.Text = "Home";
            }
        }


        private void DisableButton()
        {
            if (btnActual != null)
            {
                btnActual = null;
            }
        }

        #endregion

        #region Funcionalidad de los Botones Salir, minimizar, achicar/agrandar

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAgrandar_Click(object sender, EventArgs e)
        {
            this.picAgrandar.Visible = false;
            this.picAchicar.Visible = true;

            this.WindowState = FormWindowState.Maximized;
        }

        private void picAchicar_Click(object sender, EventArgs e)
        {
            this.picAchicar.Visible = false;
            this.picAgrandar.Visible = true;

            this.WindowState = FormWindowState.Normal;
        }

        #endregion

        #region Funcionalidad del boton para abrir formularios

        public void AbrirFormularioHijo(object tipoFormHijo)
        {
            if (this.panelChild.Controls.Count > 0)
            {
                this.panelChild.Controls.RemoveAt(0);
            }

            if (tipoFormHijo != null)
            {
                Form formHijo = tipoFormHijo as Form;
                formHijo.TopLevel = false;
                formHijo.Dock = DockStyle.Fill;
                this.panelChild.Controls.Add(formHijo);
                this.panelChild.Tag = formHijo;
                formHijo.Show();
            }
        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Productos());
        }

       

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new Clientes());
        }



        private void btnTipoProductos_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new TiposProductos());
        }

        private void iBtnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(this.iBtnProductos);
            AbrirFormularioHijo(new Productos());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(this.iBtnClients);
            AbrirFormularioHijo(new Clientes());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(this.iBtnSales);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(this.iBtnStats);
        }

        private void iPicBoxLOGO_Click(object sender, EventArgs e)
        {
            ActivateButton(null);
            AbrirFormularioHijo(null);

        }



        #endregion

        private void FormularioPrincipal_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm userLogin = new LoginForm();

            userLogin.ShowDialog();

            if (userLogin.DialogResult == DialogResult.OK)
            {
                UsuarioLogueado = userLogin.UsuarioLogueado;
                this.Visible = true;

                //Aca se podria validar lo que se muestra en el formulario principal segun el tipo de usuario
                //pero la interfaz de escritorio es solamente para Admin
            }

        }
    }
}
