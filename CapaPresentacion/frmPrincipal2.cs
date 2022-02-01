using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class frmPrincipal2 : Form
    {

        private IServiceProvider serviceProvider { get; set; }


        public frmPrincipal2(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
           this.serviceProvider = _serviceProvider;
         
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();

            
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
          /*  if (pnlMenu.Width==200)
            {
                pnlMenu.Width = 0;

            }
            else
            {
                pnlMenu.Width = 200;
            }*/

            pnlMenu.Width = pnlMenu.Width == 200 ?  0 :  200;


        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //frmConsultaProductos frmProductos = new frmConsultaProductos();
            //frmProductos.ShowDialog();
            try
            {
                var form = serviceProvider.GetRequiredService<frmConsultaProductos>();
                form.ShowDialog(this);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en procesos contacte a no se");
            }
        





          

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            var form = serviceProvider.GetRequiredService<frmEstudiantes>();
            form.ShowDialog(this);
        }
    }
}
