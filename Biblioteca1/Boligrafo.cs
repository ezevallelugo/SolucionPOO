using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor
        {
            get { return color; }
        }
        public short GetTinta
        {
            get { return tinta; }
        }
        private void SetTinta(short valor) 
        {
            int resultado = tinta + valor;
            if (resultado >= 0 && resultado <= cantidadTintaMaxima)
            {
                tinta = (short)resultado;
                Console.WriteLine($"Se ha modificado la tinta: {tinta}");
            }
            else
            {
                Console.WriteLine("No se ha modificado la tinta");
            }            
        }
        public void Recargar()
        {
            int diferencia = cantidadTintaMaxima - tinta;
            tinta += (short)diferencia;
            Console.WriteLine($"Se recargo la tinta por completo: {tinta}");
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            if (tinta + gasto < 0)
            {
                tinta = 0;
            }
            else
            {
                SetTinta(gasto);
            }
            for (int i = 0; i < (-1 * gasto); i++)
            {
                dibujo += "*";
            }
            Console.WriteLine(dibujo);
            if (tinta == 0)
            {
                Console.WriteLine("Se uso toda la tinta");
            }
            return true;
        }       
    }
}
