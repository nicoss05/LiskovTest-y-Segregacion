using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovTest
{
    [TestClass]
    public class RectanguloTest
    {
        [TestMethod]
        public void EnElRectanguloSiCambioElAnchoLaAlturaSeMantiene()
        {
            var altoEsperado = 8;

            var ancho = 5;
            var alto = 8;
            Rectangulo rectangulo = new Rectangulo(ancho, alto);

            rectangulo.Ancho = 10;
            Assert.AreEqual(rectangulo.Alto, altoEsperado);
        }
        [TestMethod]
        public void EnElRectanguloAreaEsBasePorAltura()
        {
            var areaEsperado = 40;

            var ancho = 5;
            var alto = 8;
            Rectangulo rectangulo = new Rectangulo(ancho, alto);

            var areaObtenida = rectangulo.Area();

            Assert.AreEqual(areaObtenida, areaEsperado);
        }
        [TestMethod]
        public void EnElCuadradoSiCambioElAnchoCambioElAlto()
        {
            var altoEsperado = 10;

            var lado = 5;

            Cuadrado cuadrado = new Cuadrado(lado);
            cuadrado.Ancho = 10;
            Assert.AreEqual(cuadrado.Alto, altoEsperado);
        }
    }
}
