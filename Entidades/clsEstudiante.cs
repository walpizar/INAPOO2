using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEstudiante: clsPersona
    {


        //nuevas propiedades
        public string grupo { get; set; }
        public string horario { get; set; }

        public int carnet { get; set; }
        public bool estado { get; set; }



        public clsEstudiante()
        {

        }


        public clsEstudiante(int _carnet, bool _estado, string _id, string _nombre, string _apellido1, string _apellido2)
                        : base (_id,_nombre, _apellido1, _apellido2)
        {
            this.carnet = _carnet;
            this.estado = _estado;
            //seatearla
           

        }


        public string estudiar()
        {
            return "Estoy estudiando";
        }
        public string preguntar(string laPregunta)
        {
            return "Estoy preguntando";
        }

        public string preguntar()
        {
            return "Estoy preguntando";
        }

        public override string Comer()
        {
            return "estoy comeindo como estudiante";
        }

        //polimorfismo
        public override string hablar()
        {
            return "estoy hablando como estudiante";
        }
    }
}
