using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Toyota : Vehiculo
    {

        public override void Arrancar()
        {
            Console.WriteLine("El Toyota arranca 'Doom Doom'");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El Toyota se detiene en la curva");
        }
    }
}
