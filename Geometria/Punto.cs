namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
    }
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            int ladoUno = Math.Abs(vertice3.GetX() - vertice1.GetX());
            int ladoDos = Math.Abs(vertice3.GetY() - vertice1.GetY());
            int x2 = vertice3.GetX() + ladoUno;
            int y2 = vertice1.GetY();
            int x4 = vertice1.GetX();
            int y4 = vertice3.GetY() + ladoDos;
            vertice2 = new Punto(x2, y2);
            vertice4 = new Punto(x4, y4);            
        }
        public float GetArea()
        {
            return CalcularArea();
        }
        public float GetPerimetro()
        {
            return CalcularPerimetro();
        }
        public float CalcularArea()
        {
            float baseRectangulo = Math.Abs(vertice2.GetX() - vertice1.GetX());
            float altura = Math.Abs(vertice3.GetY() - vertice4.GetY());
            area = baseRectangulo * altura;
            return area;
        }
        public float CalcularPerimetro() 
        {
            float baseRectangulo = Math.Abs(vertice3.GetX() - vertice1.GetX());
            float altura = Math.Abs(vertice3.GetY() - vertice1.GetY());
            perimetro = ((baseRectangulo + altura) * 2);
            return perimetro;
        }
    }
}
