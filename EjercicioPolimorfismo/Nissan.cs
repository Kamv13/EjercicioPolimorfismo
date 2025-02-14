using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Nissan : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("El Nisssan arranca 'doom doom'");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El Nissan se detiene en el taller");
        }
    }
}
