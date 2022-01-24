using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmConsultaProductos : Form
    {

        //global
        int valor = 5;
        public frmConsultaProductos()
        {
            InitializeComponent();
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
             
        

            if (true)
            {

               valor = 4;
            }
            else
            {
                valor = 7;
            }



            valor = 4;

            //return 1;
        }

         






        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos producto = new frmProductos();
            producto.ShowDialog();
        }
    }
}
