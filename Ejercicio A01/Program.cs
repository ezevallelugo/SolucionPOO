using Biblioteca1;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Conductor> listaConductores = new List<Conductor>();
            Console.WriteLine("Empieza el programa!");
            Conductor conductor1 = new Conductor("Papá Músculoso Sorrenstein");
            Conductor conductor2 = new Conductor("Homero");
            Conductor conductor3 = new Conductor("Rojo");
            listaConductores.Add(conductor1);
            listaConductores.Add(conductor2);
            listaConductores.Add(conductor3);
            conductor1.IngresarRecorridos();
            conductor2.IngresarRecorridos();
            conductor3.IngresarRecorridos();
            conductor1.RecorridoTotal = conductor1.SumarRecorridos();
            conductor2.RecorridoTotal = conductor2.SumarRecorridos();
            conductor3.RecorridoTotal = conductor3.SumarRecorridos();
            int min = conductor1.RecorridoTotal;
            int max = conductor1.RecorridoTotal;
            int indice1 = 0;
            int indice2 = 0;
            int indice3 = 0;
            int indice4 = 0;
            int indice5 = 0;
            int indice6 = 0;
            foreach (Conductor conductor in listaConductores)
            {
                Console.WriteLine(conductor);
            }
            Console.WriteLine("*********************************");
            // Calcula el que hizo mas KM en la semana
            for (int i = 0; i < listaConductores.Count; i++)
            {
                if (min > listaConductores[i].RecorridoTotal)
                {
                    min = listaConductores[i].RecorridoTotal;
                    indice1 = i;
                }
                if (max < listaConductores[i].RecorridoTotal)
                {
                    max = listaConductores[i].RecorridoTotal;
                    indice2 = i;
                }
            }
            // Calcula el que hizo mas KM el dia 3
            int min1 = conductor1.ListaRecorridos[2];
            int max1 = conductor1.ListaRecorridos[2];
            for (int i = 0; i < listaConductores.Count; i++)
            {
                if (min1 > listaConductores[i].ListaRecorridos[2])
                {
                    min1 = listaConductores[i].ListaRecorridos[2];
                    indice3 = i;
                }
                if (max1 < listaConductores[i].ListaRecorridos[2])
                {
                    max1 = listaConductores[i].ListaRecorridos[2];
                    indice4 = i;
                }
            }
            // Calcula el que hizo mas KM el dia 5
            int min2 = conductor1.ListaRecorridos[4];
            int max2 = conductor1.ListaRecorridos[4];
            for (int i = 0; i < listaConductores.Count; i++)
            {
                if (min2 > listaConductores[i].ListaRecorridos[4])
                {
                    min2 = listaConductores[i].ListaRecorridos[4];
                    indice5 = i;
                }
                if (max2 < listaConductores[i].ListaRecorridos[4])
                {
                    max2 = listaConductores[i].ListaRecorridos[4];
                    indice6 = i;
                }
            }

            Console.WriteLine($"El conductor con mas KM es {listaConductores[indice2].Nombre} con un total de {listaConductores[indice2].RecorridoTotal}");
            Console.WriteLine($"El conductor con menos KM es {listaConductores[indice1].Nombre} con un total de {listaConductores[indice1].RecorridoTotal}");
            Console.WriteLine($"El conductor que hizo mas KM el dia 3 es {listaConductores[indice4].Nombre} con un total de {listaConductores[indice4].ListaRecorridos[2]}");
            Console.WriteLine($"El conductor que hizo menos KM el dia 3 es {listaConductores[indice3].Nombre} con un total de {listaConductores[indice3].ListaRecorridos[2]}");
            Console.WriteLine($"El conductor que hizo mas KM el dia 5 es {listaConductores[indice6].Nombre} con un total de {listaConductores[indice6].ListaRecorridos[4]}");
            Console.WriteLine($"El conductor que hizo menos KM el dia 5 es {listaConductores[indice5].Nombre} con un total de {listaConductores[indice5].ListaRecorridos[4]}");
        }
    }
}