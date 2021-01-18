namespace LiskovTest
{
    internal class Cuadrado : IArea
    {

        public Cuadrado(int lado)
        {
            Lado = lado;
        }
        public int Lado { get; set; }
        public int Ancho
        {
            get
            {
                return Lado;
            }
            set
            {
                Lado = value;
            }

        }
        public int Alto
        {
            get
            {
                return Lado;
            }
            set
            {
                Lado = value;
            }
        }
        public double Area()
        {
            return System.Math.Pow(Lado, 2);
        }
    }

}
