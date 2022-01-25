
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
            lblTitulo.Text = "Crear Producto Nuevo";
            cboCategoria.SelectedIndex = 0;
            cboImpuesto.SelectedIndex = 0;
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

                //como el producto es nuevo no existe, debo de crear una instancia
                clsProductos producto = new clsProductos();
                producto.codigo = txtCodigo.Text;
                producto.nombre = txtNombre.Text;
                producto.precioCosto = decimal.Parse(txtPrecioCosto.Text);
                producto.utilidad = decimal.Parse(txtUtilidad.Text);
                producto.impuesto = int.Parse(cboImpuesto.Text);
                producto.precioVenta = decimal.Parse(txtPrecioVenta.Text);
                producto.categoria = cboCategoria.Text;
                producto.proveedor = txtProveedor.Text;
                producto.estado = true;


                //creo instancia de obtjeto de NEGOCIO- pasar los datos a negocio
                //BProductos ProductoIns = new BProductos();
               
                var result= insBProductos.guardar(producto);
                if (result!=null)
                {
                    MessageBox.Show("Se guardo correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se guardaron los datos. Verifique...");
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
                MessageBox.Show("Debe digita el Código del producto");
                txtCodigo.Focus();
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe digita el nombre del producto");
                txtNombre.Focus();
                return false;

            }

            if (txtPrecioCosto.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar el precio de costo del producto");
                txtPrecioCosto.Focus();
                return false;
            }

            if (txtUtilidad.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar la utilidad del producto");
                txtUtilidad.Focus();
                return false;
            }

            if (txtPrecioVenta.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar el precio de venta del producto");
                txtPrecioVenta.Focus();
                return false;
            }

            if (cboImpuesto.Text == string.Empty)
            {
                MessageBox.Show("Debe escoger un impuesto para el producto");
                cboImpuesto.Focus();
                return false;
            }

            if (cboCategoria.Text == string.Empty)
            {
                MessageBox.Show("Debe escoger una categoria para el producto");
                cboCategoria.Focus();
                return false;
            }

            if (txtProveedor.Text == string.Empty)
            {
                MessageBox.Show("Debe escribir el nombre del proveedor del producto");
                txtProveedor.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtPrecioCosto.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Precio de costo");
                txtPrecioCosto.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtUtilidad.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Utilidad");
                txtUtilidad.Focus();
                return false;
            }

            if (!clsNumber.isNumber(txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe indicar un valor numerico en el campo Precio de venta");
                txtPrecioVenta.Focus();
                return false;
            }
            return true;
        }

        private void gbxProducto_Enter(object sender, EventArgs e)
        {

        }
    }
}
