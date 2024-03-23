using System.Text;

namespace Biblioteca3
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int telefono;
        private string direccion;
        private List<Mascota> listaMascotas;

        public Cliente(string nombre, string apellido, int telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            listaMascotas = new List<Mascota>();
        }
        public string Nombre 
        { 
            get {  return nombre; } 
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public List<Mascota> ListaDeMascotas
        {
            get { return listaMascotas; }
            set { listaMascotas = value; }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {Nombre} {Apellido}");
            sb.AppendLine($"Domicilio: {Direccion}");
            sb.AppendLine($"Teléfono: {Telefono}");
            sb.AppendLine("Mascotas:");
            foreach (var mascota in listaMascotas)
            {
                sb.AppendLine(mascota.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
