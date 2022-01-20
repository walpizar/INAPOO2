using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class clsPersona
    {
        /*
        private string id;
        private string nombre;
        private string apellido1;
        private string apellido2;


        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        */



        //CONSTRUCTOR: PERMITE INSTANCIAR EL OBJETO EN MEMORIA, SIN VALORES POR DEFECTO
        //SOBRECARGA METODO
        public clsPersona() { 
        
        }

        //PERMITE INSTANCIAR EL OBJETO, CON VALORES POR DEFECTO
        public clsPersona(string _id,string _nombre, string _apellido1, string _apellido2)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.apellido1 = _apellido1;
            this.apellido2 = _apellido2;

        }

        //PORPIEDADES Y ENCAPSULADOS PROP

        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }


        //ACCIONES  METODOS


        public abstract string hablar();
       
        public string caminar()
        {

            return "estoy caminando como persona: ";
        }

        public abstract string Comer();
       







    }
}
