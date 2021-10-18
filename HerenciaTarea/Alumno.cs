using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Alumno
    {
        public string matricula;

        public string carrera;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }



        public string Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public Alumno()
        {
            matricula = "I21050333";

            carrera = "Ingeniería en informatica";

        }

        public Alumno(string matricula, String carrera)
        {
            this.matricula = matricula;
            this.carrera = carrera;

        }

      
    }
}