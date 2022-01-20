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
        public frmPrincipal2()
        {
            InitializeComponent();
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
            frmProductos frmProductos = new frmProductos();
            frmProductos.Show();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            frmEstudiantes formEstudiante = new frmEstudiantes();
            formEstudiante.Show();
        }
    }
}
