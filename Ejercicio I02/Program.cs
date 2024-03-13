/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.
 */
using Biblioteca1;
using System.Globalization;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Persona persona1 = new Persona("Matias", new DateTime(2000, 02, 22), 40923287);
            Persona persona2 = new Persona("Carlitos", new DateTime(2010, 02, 22), 40423287);
            Persona persona3 = new Persona("Alfredo", new DateTime(1990, 02, 22), 40911287);
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
        }
    }
}