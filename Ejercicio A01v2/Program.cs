/*
De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana.

Para guardar esta información, la empresa de transporte tendrá un array de conductores.

De cada conductor se tendrá la siguiente información:

Nombre del conductor.
Kilometros recorridos por cada día de la semana. Por ejemplo:
Día 1: 200
Día 2: 599
Día 3: 899
Día 4: 0 (tiene franco)
Día 5: 256
Día 6: 0
Día 7: 0
Consigna
Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.

Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.

Luego mostrar:

El conductor que hizo más km en esa semana.
El conductor que hizo más km el día 3.
El conductor que hizo más km el día 5.
 */
using Biblioteca2;

namespace Ejercicio_A01v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Conductor conductor1 = new Conductor("Papa Musculoso Sorrestein", new int[] { 400, 300, 200, 320, 200, 0, 0 });
            Conductor conductor2 = new Conductor("Homero", new int[] { 500, 100, 500, 220, 800, 0, 0 });
            Conductor conductor3 = new Conductor("Rojo", new int[] { 900, 320, 250, 370, 250, 0, 0 });

            Conductor[] conductores = { conductor1, conductor2, conductor3 };
            Conductor conductorMasKM = conductores.OrderByDescending(c => c.SumarRecorridos()).First();
            Conductor conductorMasKMDia3 = conductores.OrderByDescending(c => c.ObtenerRecorridoDia(3)).First();
            Conductor conductorMasKMDia5 = conductores.OrderByDescending(c => c.ObtenerRecorridoDia(5)).First();
            foreach (var conductor in conductores)
            {
                Console.WriteLine($"{conductor.Nombre}");
                for (int i = 0; i < conductor.RecorridoPorDia.Length ; i++)
                {
                    Console.WriteLine($"Dia {i + 1}: {conductor.RecorridoPorDia[i]}");
                }
            }

            Console.WriteLine($"El conductor que mas Km hizo en la semana es {conductorMasKM.Nombre} con {conductorMasKM.SumarRecorridos()}");
            Console.WriteLine($"El conductor que mas Km hizo en el dia 3 es {conductorMasKMDia3.Nombre} con {conductorMasKMDia3.ObtenerRecorridoDia(3)}");
            Console.WriteLine($"El conductor que mas Km hizo en el dia 5 es {conductorMasKMDia5.Nombre} con {conductorMasKMDia5.ObtenerRecorridoDia(5)}");
        }
    }
}
