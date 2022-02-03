
using CapaNegocio;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Exceptions;
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public IServiceProvider ServiceProvider { get; }
        private IGenericaNegocio<tbProductos> insBProductos { get; set; }
        public IGenericaNegocio<tbCategorias> InsCategorias { get; }
        public IGenericaNegocio<tbImpuestos> InsImpuestos { get; }
        public IGenericaNegocio<tbProveedores> InsProveedores { get; }
        public tbProductos producto { get; set; }

        private bool isNew = true;


        public frmProductos(IServiceProvider _serviceProvider,  IGenericaNegocio<tbProductos> _insBProductos, IGenericaNegocio<tbCategorias> _insCategorias, IGenericaNegocio<tbImpuestos> _insImpuestos
            , IGenericaNegocio<tbProveedores> _insProveedores)
        {
            InitializeComponent();
            ServiceProvider = _serviceProvider;
            this.insBProductos = _insBProductos;
            InsCategorias = _insCategorias;
            InsImpuestos = _insImpuestos;
            InsProveedores = _insProveedores;
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombos();

                isNew = producto == null ? true : false;


                //funcion de producto nuevo
                if (isNew)
                {//crear nuevo

                    lblTitulo.Text = "Crear Producto Nuevo";
                    cboCategoria.SelectedIndex = 0;
                    cboImpuesto.SelectedIndex = 0;
                    btnEliminar.Enabled = false;
                }
                else
                {//producto existente para modificar o eliminar
                    lblTitulo.Text = "Modificar/Eliminar Producto";
                    btnGuardar.Text = "Modificar";
                    txtCodigo.ReadOnly = true;
                    btnEliminar.Enabled = true;
                    cargarForm();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la carga de datos del formulario.");
            }
              
        }

        private void cargarCombos()
        {
            try
            {

                var listaCategorias = InsCategorias.obtenerTodos();
                var listaImpuestos = InsImpuestos.obtenerTodos();

                cboCategoria.DataSource = listaCategorias;
                cboCategoria.DisplayMember = "nombre";
                cboCategoria.ValueMember = "id";

                cboImpuesto.DataSource = listaImpuestos;
                cboImpuesto.DisplayMember = "nombre";
                cboImpuesto.ValueMember = "id";

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar las listas");
            }
        }

        private void cargarForm()
        {
            txtID.Text = producto.id.ToString().Trim();
            txtCodigo.Text = producto.codigo.Trim();
            txtNombre.Text = producto.nombre.Trim();
            txtPrecioCosto.Text = producto.precioCosto.ToString().Trim();
            txtUtilidad.Text = producto.utilidad.ToString().Trim();
            cboImpuesto.SelectedValue = producto.idImpuesto;
            txtPrecioVenta.Text = producto.precioVenta.ToString().Trim();
            txtProveedor.Text = producto.idProveedor.Trim();
            cboCategoria.SelectedValue = producto.idCategoria;
            txtNombreProv.Text = producto.tbProveedores.nombre + " " + producto.tbProveedores.apellido1;
            txtValor.Text = producto.tbImpuestos.valor.ToString();
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarForm())
                {
                    //MANDAR A GUARDAR

                    tbProductos product;

                    if (isNew)
                    {
                        //CRERELA NUEVA
                        product = new tbProductos();

                    }
                    else
                    {   //UTLICE LA EXISTE
                        product = producto;

                    }

                    //asigna valores de los controles a la entidad productos
                    product.codigo = txtCodigo.Text;
                    product.nombre = txtNombre.Text;
                    product.precioCosto = decimal.Parse(txtPrecioCosto.Text);
                    product.utilidad = decimal.Parse(txtUtilidad.Text);
                    product.idImpuesto = (int)cboImpuesto.SelectedValue;
                    product.precioVenta = decimal.Parse(txtPrecioVenta.Text);
                    product.idCategoria = (int)cboCategoria.SelectedValue;
                    product.idProveedor = txtProveedor.Text;
                    //asigna estado true xq estamos creando la entidad o modificando. por lo tanto tiene que estar true
                    product.estado = true;


                    //creo instancia de obtjeto de NEGOCIO- pasar los datos a negocio
                    //BProductos ProductoIns = new BProductos();

                    var result = new tbProductos();
                    if (isNew)
                    {
                        result = insBProductos.guardar(product);
                    }
                    else
                    {
                        result = insBProductos.modificar(product);
                    }



                    if (result != null)
                    {
                        MessageBox.Show("Se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro al guardar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



            }
            catch (EntityExistException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (EntityExistDisableException ex)
            {

               DialogResult resp= MessageBox.Show(ex.Message+" Desea reactivarlo?","Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {

                    var pro = insBProductos.obtenerPorId(txtCodigo.Text);
                    pro.estado = true;
                    var resultado = insBProductos.modificar(pro);
                    if (resultado != null)
                    {
                        MessageBox.Show("Se guardo correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
            catch (Exception ex)
            {

                MessageBox.Show("Error, contacte al administrador.");
            }





        }
        /// <summary>
        /// Metodo para validar el formulario
        /// </summary>
        /// <returns>TRUE= CORRECTO, FALSE= ALGUN DATO INCORRECTO</returns>
        private bool validarForm()
        {

            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Debe digita el Código del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe digita el nombre del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;

            }

            if (txtPrecioCosto.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar el precio de costo del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCosto.Focus();
                return false;
            }

            if (txtUtilidad.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar la utilidad del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUtilidad.Focus();
                return false;
            }

            if (txtPrecioVenta.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar el precio de venta del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }

            if (cboImpuesto.Text == string.Empty)
            {
                MessageBox.Show("Debe escoger un impuesto para el producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboImpuesto.Focus();
                return false;
            }

            if (cboCategoria.Text == string.Empty)
            {
                MessageBox.Show("Debe escoger una categoria para el producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.Focus();
                return false;
            }

            if (txtProveedor.Text == string.Empty)
            {
                MessageBox.Show("Debe escribir el nombre del proveedor del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtPrecioCosto.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Precio de costo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCosto.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtUtilidad.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Utilidad", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUtilidad.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Precio de venta", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return false;
            }
            return true;
        }

        private void gbxProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Eliminar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    bool result = insBProductos.eliminar(producto.codigo);
                    if (result)
                    {
                        MessageBox.Show("Se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al elimnar");
            }
          

        }

        private void btnBusquedaProv_Click(object sender, EventArgs e)
        {
            var form= ServiceProvider.GetRequiredService<frmConsultaProveedores>();
            form.pasarDatosEvent += recibirDatos;
           
            form.ShowDialog(this);
        }

        private void recibirDatos(tbProveedores prov)
        {
            txtProveedor.Text = prov.id.Trim();
            txtNombreProv.Text = string.Format("{0} {1} {2}", prov.nombre.Trim().ToUpper(), prov.apellido1.Trim().ToUpper(), prov.apellido2.Trim().ToUpper());

        }
    }
}
