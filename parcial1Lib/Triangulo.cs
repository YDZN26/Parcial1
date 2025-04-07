using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
    public  class Triangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseValue, double altura)
        {
            Base = baseValue;
            Altura = altura;
        }
        public override double Area()
        {
            return (Base * Altura) / 2;
        }
        public override double Perimetro()
        {
            double hipotenusa = Math.Sqrt(Base * Base + Altura * Altura);
            return Base + Altura + hipotenusa;
        }
    }
}
