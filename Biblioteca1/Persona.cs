using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Persona
    {
        public static DateTime fechaActual;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        static Persona()
        {
            fechaActual = DateTime.Today;
            Console.WriteLine($"La fecha actual es {fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}");
        }
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private int CalcularEdad(DateTime fechaDeNacimiento, DateTime fechaActualidad)
        {
            int edad;
            edad = fechaActualidad.Year - fechaDeNacimiento.Year;
            if (fechaActualidad.Month < fechaDeNacimiento.Month || (fechaActualidad.Month == fechaDeNacimiento.Month && fechaActualidad.Day < fechaDeNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
        public string Mostrar()
        {
            string mensaje;
            mensaje = $"Nombre: {nombre}| Fecha de nacimiento: {fechaDeNacimiento.Day}/{fechaDeNacimiento.Month}/{fechaDeNacimiento.Year}" +
                $"| Edad: {CalcularEdad(fechaDeNacimiento,fechaActual)}| DNI: {dni}";
            return mensaje;
        }
        public string EsMayorDeEdad()
        {
            string mensaje;
            if (CalcularEdad(fechaDeNacimiento,fechaActual) < 18)
            {
                mensaje = "Es menor";
            }
            else
            {
                mensaje = "Es mayor de edad";
            }
            return mensaje;
        }
    }
}
