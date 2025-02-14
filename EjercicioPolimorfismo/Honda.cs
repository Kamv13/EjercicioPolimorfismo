using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Honda : Vehiculo
    {

        public override void Arrancar()
        {
            Console.WriteLine("El Honda arranca 'vroom vroom' ");
        }

        public override void Detenerse()
        {
            Console.WriteLine("El Honda se detiene en el parqueo");
        }

    }
}
