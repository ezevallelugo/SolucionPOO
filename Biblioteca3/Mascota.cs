using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca3
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaDeNacimiento;
        private List<string> listaVacunas;

        public Mascota(string nombre, string especie, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaDeNacimiento = fechaDeNacimiento;
            listaVacunas = new List<string>();
        }
        public string Nombre 
        { 
            get {  return nombre; } 
            set { nombre = value; }
        }
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public List<string> ListaVacunas
        {
            get { return listaVacunas; }
            set { listaVacunas = value; }
        }
        public void AgregarVacuna(string nombre)
        {
            listaVacunas.Add(nombre);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Especie: {Especie}");
            sb.AppendLine($"Fecha de nacimiento: {FechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine("Vacunas:");
            if (listaVacunas.Count() < 1)
            {
                sb.AppendLine("No tiene vacunas");

            }
            else
            {
                foreach (var vacuna in listaVacunas)
                {
                    sb.AppendLine(vacuna.ToString());
                }
            }
            
            return sb.ToString();
        }

    }
}
