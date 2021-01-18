namespace LiskovTest
{
    internal class Rectangulo : IArea
    {
        public Rectangulo() { }
        public Rectangulo(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public int Ancho { get; set; }
        public int Alto { get; set; }
        public double Area()
        {
            return Ancho * Alto;
        }
    }


}