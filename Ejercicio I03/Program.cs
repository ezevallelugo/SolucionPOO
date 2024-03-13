using Biblioteca1;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Estudiante estudiante1 = new Estudiante("Mariela", "Rodriguez", "115323");
            Estudiante estudiante2 = new Estudiante("Jazmin", "Benitez", "112334");
            Estudiante estudiante3 = new Estudiante("Pedrito", "Gomez", "119884");
            estudiante1.SetNotaPrimerParcial = 4;
            estudiante1.SetNotaSegundoParcial = 5;
            estudiante2.SetNotaPrimerParcial = 9;
            estudiante2.SetNotaSegundoParcial = 10;
            estudiante3.SetNotaPrimerParcial = 2;
            estudiante3.SetNotaSegundoParcial = 3;
            estudiante1.Mostrar();
            estudiante2.Mostrar();
            estudiante3.Mostrar();
        }
    }
}
