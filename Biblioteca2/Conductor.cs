namespace Biblioteca2
{
    public class Conductor
    {
        private string nombre;
        private int[] recorridoPorDia;

        public Conductor(string nombre, int[] recorridoPorDia)
        {
            this.nombre = nombre;
            this.recorridoPorDia = recorridoPorDia;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int[] RecorridoPorDia
        {
            get { return recorridoPorDia; }
            set { recorridoPorDia = value; }
        }
        public int SumarRecorridos()
        {
            return recorridoPorDia.Sum();
        }
        public int ObtenerRecorridoDia(int dia)
        {
            return recorridoPorDia[dia - 1];
        }
    }
}
