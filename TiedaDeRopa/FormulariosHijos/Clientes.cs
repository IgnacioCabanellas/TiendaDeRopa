using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeRopa.Datos;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Clientes : ApplicationForm
    {
        private usuarios _UsuarioActual;

        public usuarios UsuarioActual { get => _UsuarioActual; set => _UsuarioActual = value; }

        public Clientes()
        {
            InitializeComponent();
        }

        private void MostrarABM(bool habilitado)
        {
            if (habilitado)
            {
                this.ABMPanel.Visible = true;
                this.btnPanel.Visible = false;
            }
            else
            {
                this.ABMPanel.Visible = false;
                this.btnPanel.Visible = true;
            }
        }
        private void iBtnAgregar_Click(object sender, EventArgs e)
        {
            MostrarABM(true);

            //MapearADatos();
            CargarComboPersona();
            CargarComboTipoUsuario();
        }

        private void MapearADatos()
        {
            UsuarioActual = new usuarios();
            UsuarioActual.idUsuario = Convert.ToInt32(this.txtID.Text);
            UsuarioActual.nombreUsuario = this.txtUsuario.Text;

            CargarComboPersona();
            CargarComboTipoUsuario();

        }

        private void MapearDatos()
        {
            DataGridViewRow row = dgvClientes.CurrentRow;

            this.txtID.Text = row.Cells["idUsuario"].Value.ToString();
            this.txtUsuario.Text = row.Cells["nombreUsuario"].Value.ToString();


           
            CargarComboPersona();
            CargarComboTipoUsuario();




            this.cbPersona.SelectedValue = row.Cells["idPersona"].Value.ToString();



            this.cbTipoUsuario.SelectedValue = 2;

            /* string nomCom = cl.GetOne(CursoActual.IdComision).Descripcion;//Busco el nombre de la comision de dicho curso.
                    this.cbComision.SelectedIndex = cbComision.FindStringExact(nomCom);//Esta funcion busca el indice que tiene asiganda la comision dentro del combo
                */

            //comboBox1.Items.IndexOf(gridView1.GetFocusedRowCellValue("vVendor"));
            //this.cbTipoUsuario.SelectedIndex = cbPersona.Items.IndexOf(row.Cells["idPersona"].Value = );
            //this.cbTipoUsuario.SelectedIndex = 2;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ListarGrid();

            dgvClientes.Columns["idPersona"].Visible = false;
        }

        private void ListarGrid()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
               //this.dgvClientes.DataSource = db.personas.Select(x => new { x.idPersona, x.apellido, x.nombre, x.dni, x.email, x.telefono, x.direccion }).ToList();


                this.dgvClientes.DataSource =
                           (from u in db.usuarios
                           join p in db.personas on u.idPersona equals p.idPersona
                           join tu in db.tipos_usuarios on u.idTipoUsuario equals tu.idTipoUsuario
                           where tu.idTipoUsuario == 2  //Cliente
                           select new {u.idUsuario, u.nombreUsuario, p.nombre, p.apellido, p.dni, p.idPersona}).ToList();

                

            }
        }

        private void iBtnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarContrasenia(this.txtPw.Text,this.txtRepetirPw.Text))
            {
                //Se crea un usuario y se mapea a datos

                //Se carga el usuario
            }
        }

        private bool ValidarContrasenia(string pw, string pw2)
        {
            if (pw == pw2)
            {
                return true;
            }
            else return false;
        }

        private void CargarComboTipoUsuario()
        {
            cbTipoUsuario.DataSource = null;

            cbTipoUsuario.DataSource = TipoUsuariosNegocio.GetAll();
            cbTipoUsuario.DisplayMember = "descripcion";
            cbTipoUsuario.ValueMember = "idTipoUsuario";
        }

        private void CargarComboPersona()
        {
            this.cbPersona.DataSource = null;

            cbPersona.DataSource = PersonaNegocio.GetAll();
            cbPersona.DisplayMember = "dni";
            cbPersona.ValueMember = "idPersona";
        }

        private void LimpiarDatos()
        {
            this.cbPersona.DataSource = null;
            this.cbTipoUsuario.DataSource = null;

            this.txtID.Text = "";
            this.txtUsuario.Text = "";
            this.txtPw.Text = "";
            this.txtRepetirPw.Text = "";
        }

        private void iBtnCancelar_Click(object sender, EventArgs e)
        {
            MostrarABM(false);
            LimpiarDatos();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.SelectedRows.Count > 0)
            {
                this.Modo = ApplicationForm.ModoForm.Modificacion;

                MapearDatos();

                MostrarABM(true);

            }
        }
    }
}
