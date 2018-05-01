using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona alumnoTajamar = new Persona();
            alumnoTajamar.Nombre = "Sandra";

            DateTime fechaNac = new DateTime(1985, 3, 29);
            alumnoTajamar.FechaNacimiento = fechaNac;

            alumnoTajamar.Saludar();

            //*******************************************
            PersonaInglesa alumnoBtitish = new PersonaInglesa();
            alumnoBtitish.Nombre = "Jhon";

            DateTime fechaNacI = new DateTime(1978, 8, 8);
            alumnoBtitish.FechaNacimiento = fechaNacI;

            alumnoBtitish.Saludar();

            Console.Read();

        }
    }
}
