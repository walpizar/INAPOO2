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
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmConsultaProveedores : Form
    {

        public delegate void pasarDatos(tbProveedores prov);
        public event pasarDatos pasarDatosEvent;





        public IEnumerable<tbProveedores> listaProveedores { get; set; }
        public IGenericaNegocio<tbProveedores> InsProveedores { get; }

        public frmConsultaProveedores(IGenericaNegocio<tbProveedores> _insProveedores)
        {
            InitializeComponent();
            InsProveedores = _insProveedores;
        }

        private void frmConsultaProveedores_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Busqueda de Proveedores";
            cargarDatos();
        }

        private void cargarDatos()
        {
            listaProveedores = InsProveedores.obtenerTodos();
            cargarLista(listaProveedores);

        }

        private void cargarLista(IEnumerable<tbProveedores> lista)
        {
            lstvLista.Items.Clear();

            foreach (var prod in lista)
            {

                ListViewItem linea = new ListViewItem();
                linea.Text = prod.id.Trim().ToString();
                linea.SubItems.Add(prod.nombre.Trim());
                linea.SubItems.Add(prod.apellido1.Trim());
                linea.SubItems.Add(prod.apellido2.Trim());

                lstvLista.Items.Add(linea);
            }
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            if (txtBusqueda.Text != string.Empty)
            {
                var listafiltrada = listaProveedores.Where(x => x.id.Trim().ToUpper().Contains(txtBusqueda.Text.ToUpper())
                || x.nombre.ToUpper().Trim().Contains(txtBusqueda.Text.ToUpper())
                || x.apellido1.Trim().ToUpper().Contains(txtBusqueda.Text.ToUpper())
                || x.apellido2.Trim().ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();

                /*var suma=listaProductos.Where(y=>y.categoria=="Frutas").Sum(x => x.precioVenta);


                decimal total = 0;
                foreach (var pro in listaProductos)
                {
                    if (pro.categoria == "Frutas")
                    {
                        total += pro.precioVenta;
                    }

                }*/



                cargarLista(listafiltrada);
            }
            else
            {
                cargarLista(listaProveedores);
            }
        }

        private void lstvLista_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = lstvLista.SelectedItems[0].Text;
            var prov = listaProveedores.Where(x => x.id.Trim() == id.Trim()).SingleOrDefault();

            if (prov != null)
            {

                pasarDatosEvent(prov);
                this.Close();
            }
        }
    }
}
