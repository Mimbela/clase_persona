using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_persona
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        private int CalcularEdad(DateTime fecha)
        {
            int año = fecha.Year;
            int actual = DateTime.Now.Year;
            return actual - año;

        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy {0} y tengo {1} años ", 
                Nombre, CalcularEdad(FechaNacimiento).ToString());
           // Console.Read();
        }
        
    }

}
