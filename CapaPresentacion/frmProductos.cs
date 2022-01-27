
using CapaNegocio;
using Entidades;
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
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {

        private IGenericaNegocio<clsProductos> insBProductos { get; set; }
        public clsProductos producto { get; set; }

        private bool isNew = true;


        public frmProductos(IGenericaNegocio<clsProductos> _insBProductos)
        {
            InitializeComponent();
            this.insBProductos = _insBProductos;
         
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

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

        private void cargarForm()
        {
            txtID.Text = producto.id.ToString();
            txtCodigo.Text = producto.codigo;
            txtNombre.Text = producto.nombre;
            txtPrecioCosto.Text = producto.precioCosto.ToString();
            txtUtilidad.Text = producto.utilidad.ToString();
            cboImpuesto.Text = producto.impuesto.ToString();
            txtPrecioVenta.Text = producto.precioVenta.ToString();
            txtProveedor.Text = producto.proveedor;
            cboCategoria.Text = producto.categoria;

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

            if (validarForm())
            {
                //MANDAR A GUARDAR

                clsProductos product;

                if (isNew)
                {
                    product = new clsProductos();

                }
                else
                {
                    product = producto;

                }

                //asigna valores de los controles a la entidad productos
                product.codigo = txtCodigo.Text;
                product.nombre = txtNombre.Text;
                product.precioCosto = decimal.Parse(txtPrecioCosto.Text);
                product.utilidad = decimal.Parse(txtUtilidad.Text);
                product.impuesto = int.Parse(cboImpuesto.Text);
                product.precioVenta = decimal.Parse(txtPrecioVenta.Text);
                product.categoria = cboCategoria.Text;
                product.proveedor = txtProveedor.Text;
                //asigna estado true xq estamos creando la entidad o modificando. por lo tanto tiene que estar true
                product.estado = true;


                //creo instancia de obtjeto de NEGOCIO- pasar los datos a negocio
                //BProductos ProductoIns = new BProductos();

                var result = new clsProductos();
                if (isNew)
                {
                    result = insBProductos.guardar(product);
                }
                else
                {
                    result = insBProductos.modificar(product);
                }
               


                if (result!=null)
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

           DialogResult resp = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Eliminar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(resp == DialogResult.Yes)
            {
                bool result = insBProductos.eliminar(producto.codigo);
                if (result)
                {
                    MessageBox.Show("Se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }

        }
    }
}
