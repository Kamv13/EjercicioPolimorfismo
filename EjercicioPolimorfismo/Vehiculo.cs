

namespace EjercicioPolimorfismo
{
    public class Vehiculo
    {
        public virtual void Arrancar() {

            Console.WriteLine("El carro arranca");
        
        }

        public virtual void Detenerse() {

            Console.WriteLine("El carro se detiene");
        
        }
    }
}
