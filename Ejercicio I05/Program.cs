using Geometria;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Punto punto1 = new Punto(4, 8);
            Punto punto3 = new Punto(7, 10);                 
            Rectangulo rectanguloEze = new Rectangulo(punto1,punto3);
            MostrarRectangulo(rectanguloEze);
        }
        public static void MostrarRectangulo(Rectangulo unRectangulo)
        {
            Console.WriteLine(unRectangulo.CalcularArea());
            Console.WriteLine(unRectangulo.CalcularPerimetro());
        }
    }
}
