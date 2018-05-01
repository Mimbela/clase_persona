using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_persona
{
    public class PersonaInglesa:Persona
    {
        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té ");
            //Console.ReadLine();
        }

        public new void Saludar()
        {
            Console.WriteLine("Hi im {0} and i am {1} years old", Nombre, Edad);
        }
           
    }
}
