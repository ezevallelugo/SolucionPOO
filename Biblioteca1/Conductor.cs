using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Conductor
    {
        private string nombre;
        private List<int> listaRecorridos;
        private int recorridoTotal;
        public Conductor(string nombre)
        {
            this.nombre = nombre;
            listaRecorridos = new List<int>();
            this.recorridoTotal = 0;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public List<int> ListaRecorridos
        {
            get { return listaRecorridos;}
        }
        public int RecorridoTotal
        {
            get { return recorridoTotal; }
            set { recorridoTotal = value;}
        }
        public void IngresarRecorridos()
        {
            int recorrido;
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese el recorrido de {nombre} (Dia {i + 1}): ");
                while (!int.TryParse(Console.ReadLine(), out recorrido) || recorrido < 0)
                {
                    Console.Write("Error. Ingrese un numero valido positivo: ");
                }
                listaRecorridos.Add(recorrido);
            }
        }
        public void MostrarConductorRecorrido()
        {
            Console.WriteLine(nombre);
            for (int i = 0; i < listaRecorridos.Count; i++)
            {
                Console.WriteLine($"Dia {i + 1}: {listaRecorridos[i]}");
            }
        }
        public int SumarRecorridos()
        {
            int suma = 0;
            for (int i = 0; i < listaRecorridos.Count; i++)
            {
                suma += listaRecorridos[i];
            }
            return suma;
        }
    }
}
