using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Persona
    {
        public string nombre;

        public string fecha;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }


        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public Persona()
        {
            nombre = "Diego Rafael Garcia Damian";
            fecha = "26/03/04";

        }

        public Persona(string Nombre, String Fecha)
        {
            this.nombre = Nombre;
            this.Fecha = fecha;

        }



    }
}