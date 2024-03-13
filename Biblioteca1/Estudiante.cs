using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random numeroRandom;
        static Estudiante()
        {
            numeroRandom = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public int SetNotaPrimerParcial
        {
            set { notaPrimerParcial = value; }
        }
        public int SetNotaSegundoParcial
        {
            set { notaSegundoParcial = value; }
        }
        private double CalcularPromedio()
        {
            double retorno;
            retorno = (notaPrimerParcial + notaSegundoParcial) / 2;
            return retorno;
        }
        public int CalcularNotaFinal()
        {
            int retorno = -1;
            if (CalcularPromedio() >= 4)
            {
                retorno = numeroRandom.Next(6, 11);
            }
            return retorno;
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio():F2}");
            int resultado = CalcularNotaFinal();
            if ( resultado != -1)
            {
                sb.AppendLine($"Nota final: {resultado}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
