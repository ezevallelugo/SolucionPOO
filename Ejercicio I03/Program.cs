﻿/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

https://programacion2.ar/assets/images/el-ejemplo-universal-diagram-9ff4c151adf0d04eaba52472e5c95fec.png

La clase Estudiante:
Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
El método privado CalcularPromedio retornará el promedio de las dos notas.
El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos.
*/

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
