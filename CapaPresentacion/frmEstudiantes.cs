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

namespace CapaPresentacion
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {


            bool result= clsMath.verificarNumeroPar(10);



            //instancia en memoria de nuestro objeto: NEW 
            clsEstudiante estudiante = new clsEstudiante();
            estudiante.id = "666";
            estudiante.nombre = "WALTER";
            estudiante.apellido1 = "APELLIDO";
            estudiante.apellido2 = "ARGUELLO";
            estudiante.carnet = 34242;
            estudiante.estado = true;


            clsEstudiante estu = new clsEstudiante(366656, true, "6666","JUAN","ROJAS","PEREZ");

            estu.Comer();
            estu.estudiar();





        }
    }
}
