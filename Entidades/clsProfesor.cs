using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsProfesor : clsPersona
    {

        public string especialidad { get; set; }


        public clsProfesor()
        {

        }

        public clsProfesor(string _especialidad, string _id, string _nombre, string _apellido1, string _apellido2  )
            :base(_id,_nombre,_apellido1,_apellido2)
        {
            this.especialidad = _especialidad;

        }

        public string ensenar()
        {
            return "estoy enseñando";
        }
        //polimorfismo
        public override string Comer()
        {
            return "Estoy comeindo como profesor";
        }

        public override string hablar()
        {
            return "estoy hablando como profesor";
        }
    }
}
