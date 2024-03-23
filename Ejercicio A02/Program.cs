/*
El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.

De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.

De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. 
Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas. 
De las vacunas sólo interesa conocer el nombre.

Consigna
Crear una aplicación de consola.
Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
Instanciar los siguientes objetos:
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
 */
using Biblioteca3;

namespace Ejercicio_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Cliente cliente1 = new Cliente("Juan", "Perez", 1172349833, "Av Rivadavia 4213");
            Mascota perro1 = new Mascota("Max", "Perro", new DateTime(2019, 5, 10));
            cliente1.ListaDeMascotas.Add(perro1);

            Cliente cliente2 = new Cliente("Maria", "Gomez", 1189742643, "Calle 433");
            Mascota gato1 = new Mascota("Felix", "Gato", new DateTime(2018, 10, 15));
            gato1.AgregarVacuna("Triple Felina");
            cliente2.ListaDeMascotas.Add(gato1);

            Cliente cliente3 = new Cliente("Carlos", "Rodriguez", 1142786678, "Av Corrientes 3171");
            Mascota gato2 = new Mascota("Bola de pelo", "Gato", new DateTime(2020, 3, 20));
            Mascota perro2 = new Mascota("Apestoso", "Perro", new DateTime(2021, 7, 5));
            perro2.AgregarVacuna("Rabia");
            cliente3.ListaDeMascotas.Add(gato2);
            cliente3.ListaDeMascotas.Add(perro2);

            // Mostrar los datos de los clientes y sus mascotas
            Console.WriteLine("Datos de los clientes y sus mascotas:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(cliente1.MostrarDatos());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(cliente2.MostrarDatos());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(cliente3.MostrarDatos());

        }
    }
}
