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
using Negocio;

namespace Escritorio
{
    public partial class Productos : ApplicationForm
    {
        private TiendaDeRopa.Datos.productos _ProductoActual;

        public productos ProductoActual { get => _ProductoActual; set => _ProductoActual = value; }

        public Productos()
        {
            InitializeComponent();
        }

        public Productos(ModoForm modo) : this()
        {
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        #region Eventos click de los botones de ABMs

        private void iBtnAgregar_Click(object sender, EventArgs e)
        {
            if (this.dgvProductos.SelectedRows.Count > 0)
            {
                this.Modo = ModoForm.Alta;

                MostrarABM(true, this.Modo);

                cargarComboBox();
            }
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvProductos.SelectedRows.Count > 0)
            {
                this.Modo = ApplicationForm.ModoForm.Modificacion;

                MapearDatos();

                MostrarABM(true, this.Modo);
            }
        }

        private void iBtnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dgvProductos.SelectedRows.Count > 0)
            {
                this.Modo = ModoForm.Baja;

                MapearDatos();

                MostrarABM(true, this.Modo);
            }
        }

        #endregion


        #region Eventos click de los botones aceptar y cancelar

        private void iBtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo == ApplicationForm.ModoForm.Alta)
            {
                MapearADatos();

                CargarProducto();

                MostrarABM(false, this.Modo);
            }
            else if (this.Modo == ApplicationForm.ModoForm.Modificacion)
            {
                MapearADatos();

                ModificarProducto(ProductoActual);

                MostrarABM(false, this.Modo);
            }
            else if (this.Modo == ApplicationForm.ModoForm.Baja)
            {
                MapearADatos();

                EliminarProducto(ProductoActual);

            }

            LimpiarCampos();
            ListarGrid();
        }

        private void iBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarABM(false, this.Modo);
        }

        #endregion


        #region  Metodos con llamados a la capa de negocio

        private void CargarProducto()
        {
            ProductosNegocio.Insert(ProductoActual);
        }

        private void ModificarProducto(productos prod)
        {
            ProductosNegocio.Modificar(prod);
        }

        private void EliminarProducto(productos prod)
        {
            ProductosNegocio.Eliminar(prod);
        }

        #endregion


        private void ListarGrid()
        {
            using (DB_NegocioDeRopaEntities db = new DB_NegocioDeRopaEntities())
            {
                this.dgvProductos.DataSource = 
                    db.productos.Select(p => new { p.idProducto, p.descripcion, p.stock, p.precio, p.idTipoProducto }).ToList();
            }
        }

        #region Metodos de manejo de informacion y controladores del formulario

        private void MostrarABM(bool habilitado, ModoForm modo)
        {
            if (habilitado) //Muestra el panel con la informacion del objeto y cierra el panel de botones (Agregar/Editar/Borrar)
            {
                this.ABMPanel.Visible = true;
                this.btnPanel.Visible = false;

                HabilitarCampos(modo);

            }
            else //Cierra el panel con la informacion del objeto y muestra el panel de botones (Agregar/Editar/Borrar)
            {
                this.ABMPanel.Visible = false;
                this.btnPanel.Visible = true;
            }
        }

        private void HabilitarCampos(ModoForm modo)
        {
            if (modo == ModoForm.Baja)      //Deshabilita los campos para eliminar el producto
            {
                this.txtDesc.Enabled = false;
                this.txtPrecio.Enabled = false;
                this.txtStock.Enabled = false;
                this.cbTipoProd.Enabled = false;
            }
            else //Habilita los campos necesarios para modificar o dar de alta un producto
            {
                this.txtDesc.Enabled = true;
                this.txtPrecio.Enabled = true;
                this.txtStock.Enabled = true;
                this.cbTipoProd.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            //Borra los datos
            this.txtDesc.Text = null;
            this.txtID.Text = null;
            this.txtPrecio.Text = null;
            this.txtStock.Text = null;
        }

        private void MapearADatos()
        {
            ProductoActual = new productos();

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Modificacion)
                {
                    ProductoActual.idProducto = Convert.ToInt32(this.txtID.Text);
                }

                ProductoActual.descripcion = this.txtDesc.Text;
                ProductoActual.stock = Convert.ToInt32(this.txtStock.Text);
                ProductoActual.precio = Convert.ToDecimal(this.txtPrecio.Text);
                ProductoActual.idTipoProducto = Convert.ToInt32(this.cbTipoProd.SelectedValue);

            }
            else if (this.Modo == ModoForm.Baja)
            {
                ProductoActual.idProducto = Convert.ToInt32(this.txtID.Text);
            }

        }
        private void MapearDatos()
        {
            DataGridViewRow row = dgvProductos.CurrentRow;

            this.txtID.Text = row.Cells["idProducto"].Value.ToString();
            this.txtDesc.Text = row.Cells["descripcion"].Value.ToString();
            this.txtStock.Text = row.Cells["stock"].Value.ToString();
            this.txtPrecio.Text = row.Cells["precio"].Value.ToString();

            cargarComboBox();
        }

        private void cargarComboBox()
        {
            cbTipoProd.DataSource = null;

            cbTipoProd.DataSource = TiposProductosNegocio.GetAll();
            cbTipoProd.DisplayMember = "Descripcion";
            cbTipoProd.ValueMember = "idTipoProducto";
        }

        #endregion

    }
}
