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
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmConsultaProductos : Form
    {

        //global
        int valor = 5;


        public IEnumerable<clsProductos> listaProductos { get; set; }
        public IServiceProvider ServiceProvider { get; }
        public IGenericaNegocio<clsProductos> InsBProducto { get; }

        public frmConsultaProductos(IServiceProvider _serviceProvider, IGenericaNegocio<clsProductos> _insBProducto)
        {
            InitializeComponent();
            ServiceProvider = _serviceProvider;
            InsBProducto = _insBProducto;            
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Mantenimiento: Productos";
            cargarDatos();
            valor = 88;

        }


        //VALORES: VALOR Y POR REFERENCIA




        //NIVELES DE ACCESO
        //internal: cualquier objeto detro del ensamblado
        // internal procted: dentro del mismo ensamblado pero mediante herencia
        // protected: mediante la herencia
        //privado: nadie puede accederlo, solamente dentro de el
        // publico: todo el mundo puede accederlo en el mismo ensamblado o otro ensamblado


        // valores de retorno tipo de datos primitivo: string, int, bool, array, List, double, float, decimal, var
        //valores de retorno sino objetos personalizados

        //nivel de acceso -- valor de retorno-- identicador (verbo- infinitivo) -- parametros
        //firma del metodo:private void cargarDatos()-- cierpo del metodo (scope-ambito)
        private void cargarDatos()
        {
            listaProductos = InsBProducto.obtenerTodos();

            cargarLista(listaProductos);

          
        }

        private void cargarLista(IEnumerable<clsProductos> lista)
        {

            lstvLista.Items.Clear();

            foreach (var prod in lista)
            {

                ListViewItem linea = new ListViewItem();
                linea.Text = prod.id.ToString();
                linea.SubItems.Add(prod.codigo);
                linea.SubItems.Add(prod.nombre);
                linea.SubItems.Add(prod.precioCosto.ToString());
                linea.SubItems.Add(prod.precioVenta.ToString());

                lstvLista.Items.Add(linea);
            }

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //frmProductos frmProductos = new frmProductos();
            //frmProductos.ShowDialog();

            var form = ServiceProvider.GetRequiredService<frmProductos>();
            form.ShowDialog(this);



            cargarDatos();


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           
            if (txtBusqueda.Text!=string.Empty) 
            {
                var listafiltrada = listaProductos.Where(x => x.codigo.ToUpper().Contains(txtBusqueda.Text.ToUpper()) 
                || x.nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();

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
                cargarLista(listaProductos);
            }


        }

        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var codigo = lstvLista.SelectedItems[0].SubItems[1].Text;
            var prod = listaProductos.Where(x => x.codigo == codigo).SingleOrDefault();

            //llamo al formulario de prodcuto y le paso el producto que se le dio doble clic

            var form = ServiceProvider.GetRequiredService<frmProductos>();
            form.producto = prod;
            form.ShowDialog(this);

            cargarDatos();

        }
    }
}
