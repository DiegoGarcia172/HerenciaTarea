using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.fecha = "26/03/2004";
            persona.nombre = "Diego Rafael Garcia Damian";
            Alumno alumno = new Alumno();
            alumno.carrera= "Ingeniería en informatica";
            alumno.matricula= "I21050333";

            Console.WriteLine( "Tu nombre es:    " + persona.nombre );
            Console.WriteLine( "Tu fecha de cumple años es:   " +    persona.fecha);
            Console.WriteLine(  "Tu carrera actual es:    "    +   alumno.carrera);
            Console.WriteLine(  "Tu matricula es:  "    +      alumno.matricula);

            Console.ReadKey();

        }
    }
}
