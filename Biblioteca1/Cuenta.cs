namespace Biblioteca1
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Mostrar()
        {
            string mensaje = $"Titular: {titular} | Saldo: {cantidad:C}";
            return mensaje;
        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
                Console.WriteLine($"Se ingreso {monto:C}. Su saldo actual es de {cantidad:C}");
            }
            else
            {
                Console.WriteLine("No se puede ingresar el monto menor a 1");
            }    
        }
        public void Retirar(decimal monto)
        {
            cantidad -= monto;
            Console.WriteLine($"Se retiro {monto:C}. Su saldo actual es de {cantidad:C}");
        }
    }
}