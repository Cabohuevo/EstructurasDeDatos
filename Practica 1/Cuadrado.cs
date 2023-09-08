using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricalPictures
{
    public class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double Area()
        {
            return lado * lado;
        }

        public override double Perimetro()
        {
            return 4 * lado;
        }
    }
}

