using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1Lib;

namespace Parcial1Test
{
    [TestClass]
    public class TestUnitTriangulo
    {
        [TestMethod]
        public void TestAreaTriangulo()
        {
            double baseValue = 3;
            double altura = 4;
            Triangulo triangulo = new Triangulo(baseValue, altura);
            double area = triangulo.Area();

            Assert.AreEqual(6, area, 0.001, "Area incorrecta para el triangulo");
        }

        [TestMethod]
        public void TestPerimetroTriangulo()
        {
            double baseValue = 3;
            double altura = 4;
            Triangulo triangulo = new Triangulo(baseValue, altura);

            double perimetro = triangulo.Perimetro();

            Assert.AreEqual(12, perimetro, 0.001, "Perimetro incorrecto para el triangulo");
        }
    }
}
