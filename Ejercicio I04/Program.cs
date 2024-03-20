using Biblioteca1;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            Console.WriteLine("Boligrafo azul");
            boligrafoAzul.Pintar(-20, out string texto1);
            boligrafoAzul.Recargar();
            Console.WriteLine("Boligrafo rojo");
            boligrafoRojo.Pintar(-110, out string texto2);
        }
    }
}
